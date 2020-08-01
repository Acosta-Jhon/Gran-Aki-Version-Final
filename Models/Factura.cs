using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gran_Aki_Version_Final.Models
{
    public class Factura
    {
        public Factura()
        {
            DetalleProductosFactura = new HashSet<DetalleProductosFactura>();
        }
        //Propiedades
        [Key]
        public int FacturaId { get; set; }

        [DisplayName("Descripcion")]
        public string FacturaDescripcion { get; set; }

        [DisplayName("Fecha Transaccion")]
        public DateTime? FacturaFecha { get; set; }

        [DisplayName("Identificador")]
        public int? PersonaId { get; set; }

        //Relacion
        public virtual Persona Persona { get; set; }
        public virtual ICollection<DetalleProductosFactura> DetalleProductosFactura { get; set; }
    }
}
