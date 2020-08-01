using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gran_Aki_Version_Final.Data.Migrations
{
    public partial class DbFactura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaNombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    PersonaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaNombre = table.Column<string>(nullable: false),
                    PersonaApellido = table.Column<string>(nullable: false),
                    PersonaEmail = table.Column<string>(nullable: false),
                    PersonaFechaNacimiento = table.Column<DateTime>(nullable: true),
                    PersonaTelefono = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.PersonaId);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    ProductosId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductosNombre = table.Column<string>(nullable: false),
                    ProductosPrecio = table.Column<double>(nullable: false),
                    CategoriaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.ProductosId);
                    table.ForeignKey(
                        name: "FK_Producto_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    FacturaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacturaDescripcion = table.Column<string>(nullable: true),
                    FacturaFecha = table.Column<DateTime>(nullable: true),
                    PersonaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.FacturaId);
                    table.ForeignKey(
                        name: "FK_Factura_Persona_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Persona",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleProductosFactura",
                columns: table => new
                {
                    DetalleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetalleCantidad = table.Column<int>(nullable: true),
                    DetalleIva = table.Column<double>(nullable: true),
                    DetallePrecioUnitario = table.Column<double>(nullable: true),
                    DetallePrecioTotal = table.Column<double>(nullable: true),
                    DetalleSubTotal = table.Column<double>(nullable: true),
                    FacturaId = table.Column<int>(nullable: true),
                    ProductosId = table.Column<int>(nullable: true),
                    ProductosId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleProductosFactura", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_DetalleProductosFactura_Factura_FacturaId",
                        column: x => x.FacturaId,
                        principalTable: "Factura",
                        principalColumn: "FacturaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleProductosFactura_Producto_ProductosId1",
                        column: x => x.ProductosId1,
                        principalTable: "Producto",
                        principalColumn: "ProductosId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetalleProductosFactura_FacturaId",
                table: "DetalleProductosFactura",
                column: "FacturaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleProductosFactura_ProductosId1",
                table: "DetalleProductosFactura",
                column: "ProductosId1");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_PersonaId",
                table: "Factura",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_CategoriaId",
                table: "Producto",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleProductosFactura");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
