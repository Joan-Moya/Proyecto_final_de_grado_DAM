using Microsoft.EntityFrameworkCore.Migrations;

namespace JM_Api.Migrations
{
    public partial class m12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Transacciones",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(12) CHARACTER SET utf8mb4",
                oldMaxLength: 12,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Transacciones",
                type: "varchar(12) CHARACTER SET utf8mb4",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 25,
                oldNullable: true);
        }
    }
}
