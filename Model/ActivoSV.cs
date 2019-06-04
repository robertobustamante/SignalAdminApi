using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class ActivoSV
    {
        public int ActivosvID { get; set; }
        public int ActivoID { get; set; }
        public string Medida { get; set; }
        public string Leyenda { get; set; }
        public string CuentaSenales { get; set; }
        public string Concepto { get; set; }
        public string CTM { get; set; }
        public string Comentarios { get; set; }
        public int TiposenalamientoID { get; set; }
        public int ModificacionID { get; set; }

        public Modificacion Modificacion { get; set; }
    }
}
