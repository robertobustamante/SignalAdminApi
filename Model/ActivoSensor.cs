using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class ActivoSensor
    {
        public int ActivosensorID { get; set; }
        public int ActivoID { get; set; }
        public int RouterID { get; set; }
        public int CamaraID { get; set; }
        public string Concepto { get; set; }
        public string CTM { get; set; }
        public string Sentido { get; set; }
        public string Certificado { get; set; }
        public string Carriles { get; set; }
        public string NoSerieInfotekTMS { get; set; }
        public string NoSerieVideoTrack { get; set; }
        public string NoSerieCamara { get; set; }
        public string NoSerieControlCarga { get; set; }
        public DateTime FInstPoste { get; set; }
        public DateTime FInstChip { get; set; }
        public DateTime FInstCeldaSolar { get; set; }
        public int TiposensorID { get; set; } //RTMS/VideoDetector
        public int ModificacionID { get; set; }
    }
}
