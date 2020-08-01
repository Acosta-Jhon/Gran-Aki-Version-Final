using Microsoft.EntityFrameworkCore.Migrations;

namespace Gran_Aki_Version_Final.Data.Migrations
{
    public partial class SaveImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Persona",
                type: "nvarchar(100)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Persona");
        }
    }
}
