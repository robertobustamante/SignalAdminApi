using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class ActivoSVAE
    {
        public int ActivosvaeID { get; set; }
        public int ActivoID { get; set; }
        public int EstacionmonitoreoID { get; set; }
        public int RouterID { get; set; }
        public string CableAcometida { get; set; }
        public string CTM { get; set; }
        public string Concepto { get; set; }
        public int ModificacionID { get; set; }
    }
}
