using Microsoft.EntityFrameworkCore.Migrations;

namespace JM_Api.Migrations
{
    public partial class m7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_DireccionesEnvio_DireccionEnvioId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_DireccionEnvioId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "DireccionEnvioId",
                table: "Pedidos");

            migrationBuilder.AddColumn<int>(
                name: "DireccionEnvioId",
                table: "Transacciones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Transacciones_DireccionEnvioId",
                table: "Transacciones",
                column: "DireccionEnvioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transacciones_DireccionesEnvio_DireccionEnvioId",
                table: "Transacciones",
                column: "DireccionEnvioId",
                principalTable: "DireccionesEnvio",
                principalColumn: "DireccionEnvioId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transacciones_DireccionesEnvio_DireccionEnvioId",
                table: "Transacciones");

            migrationBuilder.DropIndex(
                name: "IX_Transacciones_DireccionEnvioId",
                table: "Transacciones");

            migrationBuilder.DropColumn(
                name: "DireccionEnvioId",
                table: "Transacciones");

            migrationBuilder.AddColumn<int>(
                name: "DireccionEnvioId",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_DireccionEnvioId",
                table: "Pedidos",
                column: "DireccionEnvioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_DireccionesEnvio_DireccionEnvioId",
                table: "Pedidos",
                column: "DireccionEnvioId",
                principalTable: "DireccionesEnvio",
                principalColumn: "DireccionEnvioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
