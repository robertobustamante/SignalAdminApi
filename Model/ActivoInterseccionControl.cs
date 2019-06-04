using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class ActivoInterseccionControl
    {
        public int ActivointerseccioncontrolID { get; set; }
        public int ActivoID { get; set; }
        public int ControlID { get; set; }
        public int ModificacionID { get; set; }

        public Modificacion Modificacion { get; set; }
    }
}
