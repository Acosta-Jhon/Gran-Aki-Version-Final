using System;
using System.Collections.Generic;
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

        public int CategoriaId { get; set; }
        public string CategoriaNombre { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }
}
