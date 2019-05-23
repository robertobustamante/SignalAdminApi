using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Service;
using Model;

namespace SiguesCore.Controllers
{
  [Authorize]
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [AllowAnonymous]
        [HttpPost("autenticar")]
        public IActionResult Authenticate([FromBody] Login model)
        {
            var usuario = _usuarioService.Autenticar(model.Usr, model.Psw);
            if (usuario != null)
            {
                if (usuario.Token.StartsWith("<error>"))
                    return BadRequest(new { messsage = usuario.Token.Replace("<error>", "") });
                return Ok(usuario);
            }
                
            else
                return BadRequest(new { message = "Usuario o password incorrecto" });
        }
    }
}