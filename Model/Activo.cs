using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Activo
    {
        public int ActivoID { get; set; }
        public int TipoactivoID { get; set; }
        public string NumSerie { get; set; }
        public string CodigoBarras { get; set; }
        public int VialidadID { get; set; }
        public string Ubicacion { get; set; }
        public string Tramo { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string NumPlano { get; set; }
        public string PathPlano { get; set; }
        public string PathImagen { get; set; }
        public string PathDiagrama { get; set; }
        public string Estado { get; set; }
        public int ModificacionID { get; set; }

        public Modificacion Modificacion { get; set; }
    }
}