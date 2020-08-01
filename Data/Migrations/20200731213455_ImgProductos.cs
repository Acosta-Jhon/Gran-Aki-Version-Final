using Microsoft.EntityFrameworkCore.Migrations;

namespace Gran_Aki_Version_Final.Data.Migrations
{
    public partial class ImgProductos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Producto",
                type: "nvarchar(100)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Producto");
        }
    }
}
