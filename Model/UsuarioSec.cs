using System;

namespace Model
{
    public class UsuarioSec
    {
        public int UsuariosecID { get; set; }
        public string UsuarioID { get; set; }
        public string Psw { get; set; }
        public string PreguntaPsw { get; set; }
        public string RespuestaPsw { get; set; }
        public int IntentosFallidosLogin { get; set; }
        public bool BloqueoLogin { get; set; }
        public int IntentosFallidosPregunta { get; set; }
        public bool BloqueoPregunta { get; set; }
        public DateTime UltimoAcceso { get; set; }

        public Usuario Usuario { get; set; }
    }
}
