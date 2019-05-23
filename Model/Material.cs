using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Material
    {
        public int MaterialID { get; set; }
        public string Clave { get; set; }
        public string Descripcion { get; set; }
        public string UnidadMedida { get; set; }
        public int Existencia { get; set; }
        public string Dimensiones { get; set; }
        public int ModificacionID { get; set; }
    }
}
