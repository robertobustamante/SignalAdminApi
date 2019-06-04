using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Rol
    {
        public int RolID { get; set; }
        public string Descripcion { get; set; }
        public int ModificacionID { get; set; }

        public Modificacion Modificacion { get; set; }
        public Usuario Usuario { get; set; }
        public Permiso Permiso { get; set; }
    }
}