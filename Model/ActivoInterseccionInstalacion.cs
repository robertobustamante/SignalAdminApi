using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class ActivoInterseccionInstalacion
    {
        public int ActivointerseccioninstalacionID { get; set; }
        public int ActivoID { get; set; }
        public int SemaforoID { get; set; }
        public int PosteID { get; set; }
        public int RegistroelectricoID { get; set; }
        public int CableadoID { get; set; }
        public int ModificacionID { get; set; }

        public Modificacion Modificacion { get; set; }
    }
}
