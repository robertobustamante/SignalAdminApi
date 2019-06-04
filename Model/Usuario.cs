using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Usuario
    {
        public string UsuarioID { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public int RolID { get; set; }
        public string Token { get; set; }
        public int ModificacionID { get; set; }

        public Modificacion Modificacion { get; set; }
        public UsuarioSec UsuarioSec { get; set; }
        public Rol Rol { get; set; }
    }
}
