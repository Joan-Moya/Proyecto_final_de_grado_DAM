using Microsoft.EntityFrameworkCore.Migrations;

namespace JM_Api.Migrations
{
    public partial class m6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EsCarrito",
                table: "ProductosPedidos");

            migrationBuilder.AddColumn<bool>(
                name: "EsCarrito",
                table: "Pedidos",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EsCarrito",
                table: "Pedidos");

            migrationBuilder.AddColumn<bool>(
                name: "EsCarrito",
                table: "ProductosPedidos",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
