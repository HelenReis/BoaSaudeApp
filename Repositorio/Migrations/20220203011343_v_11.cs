using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositorio.Migrations
{
    public partial class v_11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeUsuario",
                table: "Prestador");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Prestador");

            migrationBuilder.DropColumn(
                name: "NomeUsuario",
                table: "Conveniado");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Conveniado");

            migrationBuilder.DropColumn(
                name: "NomeUsuario",
                table: "Associado");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Associado");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Prestador",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Conveniado",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Associado",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Prestador");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Conveniado");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Associado");

            migrationBuilder.AddColumn<string>(
                name: "NomeUsuario",
                table: "Prestador",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Prestador",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeUsuario",
                table: "Conveniado",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Conveniado",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeUsuario",
                table: "Associado",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Associado",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
