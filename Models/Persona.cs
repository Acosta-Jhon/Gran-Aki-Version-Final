using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gran_Aki_Version_Final.Models
{
    public class Persona
    {
        public Persona()
        {
            Factura = new HashSet<Factura>();
        }
        //Propidades
        [Key]
        [DisplayName("Id")]
        public int PersonaId { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage ="Nombre Obligatorio")]
        public string PersonaNombre { get; set; }

        [DisplayName("Apellido")]
        [Required(ErrorMessage = "Apellido Obligatorio")]
        public string PersonaApellido { get; set; }

        [DisplayName("Emial")]
        [Required(ErrorMessage = "Email Obligatorio")]
        public string PersonaEmail { get; set; }

        [DisplayName("Fecha Naciemiento")]
        public DateTime? PersonaFechaNacimiento { get; set; }

        [DisplayName("Telefono")]
        [Required(ErrorMessage = "Telefono Obligatorio")]
        public string PersonaTelefono { get; set; }

        //Relacion FK
        public virtual ICollection<Factura> Factura { get; set; }

        [NotMapped]
        [DisplayName("Imagen Cargada")]
        public IFormFile ImageFile { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Fotografia")]
        public string ImageName { get; set; }

       // public virtual List<Producto> Productos { get; set; } = new List<Producto>();
    }
}
