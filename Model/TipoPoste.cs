using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class TipoPoste
    {
        public int TipoposteID { get; set; }
        public string Descripcion { get; set; }
        public string NumParte { get; set; }
        public string Fabricante { get; set; }
        public int ModificacionID { get; set; }

        public Modificacion Modificacion { get; set; }
    }
}