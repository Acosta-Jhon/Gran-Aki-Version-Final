using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Gran_Aki_Version_Final.Models;

namespace Gran_Aki_Version_Final.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<DetalleProductosFactura> DetalleProductosFactura { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Producto> Producto { get; set; }
    }
}
