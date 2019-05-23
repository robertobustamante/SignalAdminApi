using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Permiso
    {
        public int PermisoID { get; set; }
        public int RolID { get; set; }
        public string Descripcion { get; set; } //Usar prefijos <Controller> Nombre_del_controlador o <View> Nombre_de_la_vista
        public bool View { get; set; }
        public bool Create { get; set; }
        public bool Read { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}
