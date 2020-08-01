using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gran_Aki_Version_Final.Models
{
    public class DetalleProductosFactura
    {
        //Propiedades
        [Key]
        public int DetalleId { get; set; }

        [DisplayName("Cantidad")]
        public int? DetalleCantidad { get; set; }

        [DisplayName("Iva")]
        public double? DetalleIva { get; set; }

        [DisplayName("Precio Unitario")]
        public double? DetallePrecioUnitario { get; set; }

        [DisplayName("Precio Total")]
        public double? DetallePrecioTotal { get; set; }

        [DisplayName("Sub total")]
        public double? DetalleSubTotal { get; set; }

        [DisplayName("Factura Id")]
        public int? FacturaId { get; set; }

        [DisplayName("Producto Id")]
        public int? ProductosId { get; set; }

        //Relaciones FKs
        public virtual Factura Factura { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
