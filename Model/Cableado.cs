using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Cableado
    {
        public int CableadoID { get; set; }
        public string Descripcion { get; set; }
        public string NumParte { get; set; }
        public int ModificacionID { get; set; }

        public Modificacion Modificacion { get; set; }
    }
}
