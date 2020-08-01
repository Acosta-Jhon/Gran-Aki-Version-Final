using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gran_Aki_Version_Final.Models
{
    public class Categoria
    {
        public Categoria()
        {
            Producto = new HashSet<Producto>();
        }
        [Key]
        public int CategoriaId { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Nombre Obligatorio")]
        public string CategoriaNombre { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }
}
