using System;

namespace Model
{
    public class Modificacion
    {
        public int ModificacionID { get; set; }
        public int CreadoPor { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int ModificadoPor { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int EliminadoPor { get; set; }
        public DateTime FechaEliminacion { get; set; }
        public bool Eliminado { get; set; }

        public Activo Activo { get; set; }
        public ActivoInterseccionControl ActivoInterseccionControl { get; set; }
        public ActivoInterseccionInstalacion ActivoInterseccionInstalacion { get; set; }
        public ActivoSensor ActivoSensor { get; set; }
        public ActivoSV ActivoSV { get; set; }
        public ActivoSVAE ActivoSVAE { get; set; }
        public Cableado Cableado { get; set; }
        public Control Control { get; set; }
        public Material Material { get; set; }
        public Permiso Permiso { get; set; }
        public Poste Poste { get; set; }
        public RegistroElectrico RegistroElectrico { get; set; }
        public Rol Rol { get; set; }
        public Semaforo Semaforo { get; set; }
        public TipoActivo TipoActivo { get; set; }
        public TipoControl TipoControl { get; set; }
        public TipoPoste TipoPoste { get; set; }
        public TipoSemaforo TipoSemaforo { get; set; }
        public TipoSenalamiento TipoSenalamiento { get; set; }
        public TipoSensor TipoSensor { get; set; }
        public Usuario Usuario { get; set; }

    }
}
