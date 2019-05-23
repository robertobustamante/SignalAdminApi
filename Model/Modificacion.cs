using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Modificacion
    {
        public int ModificacionID { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string EliminadoPor { get; set; }
        public DateTime FechaEliminacion { get; set; }
        public bool Activo { get; set; }

        public Cableado Cableado { get; set; }
    }
}
