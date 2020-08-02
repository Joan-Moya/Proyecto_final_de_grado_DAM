using Microsoft.EntityFrameworkCore.Migrations;

namespace JM_Api.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Productos");

            migrationBuilder.AddColumn<string>(
                name: "Cristal",
                table: "Productos",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Diametro",
                table: "Productos",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Marca",
                table: "Productos",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Modelo",
                table: "Productos",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoCorrea",
                table: "Productos",
                maxLength: 20,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cristal",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Diametro",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Marca",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Modelo",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "TipoCorrea",
                table: "Productos");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Productos",
                type: "varchar(30) CHARACTER SET utf8mb4",
                maxLength: 30,
                nullable: true);
        }
    }
}
