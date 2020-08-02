using Microsoft.EntityFrameworkCore.Migrations;

namespace JM_Api.Migrations
{
    public partial class m10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotasEntrega",
                table: "Pedidos");

            migrationBuilder.AddColumn<string>(
                name: "NotasEntrega",
                table: "Transacciones",
                maxLength: 150,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotasEntrega",
                table: "Transacciones");

            migrationBuilder.AddColumn<string>(
                name: "NotasEntrega",
                table: "Pedidos",
                type: "varchar(150) CHARACTER SET utf8mb4",
                maxLength: 150,
                nullable: true);
        }
    }
}
