using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class TipoSenalamiento
    {
        public int TiposenalamientoID { get; set; }
        public string Descripcion { get; set; }
        public int ModificacionID { get; set; }

        public Modificacion Modificacion { get; set; }
    }
}
