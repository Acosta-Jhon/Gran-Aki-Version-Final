using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Gran_Aki_Version_Final.Models
{
    public class ModificacionRol
    {
        [DisplayName("Nombre Rol")]
        public string RoleName { get; set; }

        [DisplayName("Id Rol")]
        public string RoleId { get; set; }

        [DisplayName("Agregar rRol")]
        public string[] AumentarIds { get; set; }

        [DisplayName("Eliminar Rol")]
        public string[] BorrarIds { get; set; }
    }
}
