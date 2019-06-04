using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class TipoActivo
    {
        public int TipoactivoID { get; set; }
        public string Descripcion { get; set; }
        public string Clave { get; set; }
        public int ModificacionID { get; set; }

        public Modificacion Modificacion { get; set; }
    }
}
