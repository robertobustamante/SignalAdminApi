using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Service
{
    public interface IUsuarioService
    {
        Usuario GetUserByToken(string token);
        Usuario Autenticar(string usr, string psw);
    }
    public class UsuarioService : IUsuarioService
    {
        private readonly Helpers.AppSettings _appSettings;
        private readonly SiguesCoreDbContext _dbContext;
        public UsuarioService(SiguesCoreDbContext usuarioDbContext, IOptions<Helpers.AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
            _dbContext = usuarioDbContext;
        }

        public Usuario GetUserByToken(string token)
        {
            var result = new Usuario();
            try
            {
                result = _dbContext.Usuario.Single(x => x.Token == token);
            }
            catch(System.Exception ex) { }
            return result;
        }
        public Usuario Autenticar(string usr, string psw)
        {
            var _usuario = _dbContext.Usuario.SingleOrDefault(x => x.NombreUsuario == usr || x.Email == usr);
            if (_usuario != null)
            {
                var _usuarioSec = _dbContext.UsuarioSec.SingleOrDefault(x => x.UsuarioID == _usuario.UsuarioID && x.Psw == psw);
                if (_usuarioSec != null)
                {
                    if (_usuarioSec.BloqueoLogin == true)
                    {
                        _usuario.Token = "<error>Usuario bloqueado";
                        return _usuario;
                    }
                    if (_usuarioSec.IntentosFallidosLogin >= 5)
                    {
                        _usuario.Token = "<error>Numero de intentos de inicio de sesion superados";
                        return _usuario;
                    }
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var key = Encoding.ASCII.GetBytes(_appSettings.SecretKey);
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                            new Claim("UserData", _usuario.UsuarioID.ToString())
                        }),
                        Expires = System.DateTime.UtcNow.AddDays(7),
                        NotBefore = System.DateTime.UtcNow,
                        Issuer = _appSettings.Issuer,
                        Audience = _appSettings.Audience,
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                    };
                    var token = tokenHandler.CreateToken(tokenDescriptor);
                    _usuario.Token = tokenHandler.WriteToken(token);
                }
                else
                {
                    //aumentar numero de inicios de sesion fallidos
                    _usuario.Token = "<error>Password incorrecto";
                }
            }
            else
                return new Usuario { Token = "<error>Usuario incorrecto" };

            return _usuario;
        }
    }
}
