using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gran_Aki_Version_Final.Models
{
    public class EdicionRol
    {
        [DisplayName("Rol")]
        public IdentityRole Rol { get; set; }

        [DisplayName("Miembros")]
        public IEnumerable<IdentityUser> miembros { get; set; }

        [DisplayName("No miembros")]
        public IEnumerable<IdentityUser> noMiembros { get; set; }
    }
}
