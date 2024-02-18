using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GTH.API.Migrations
{
    public partial class SecondMigrationIncludeFlagAdm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SobreNome",
                table: "Usuarios",
                newName: "SOBRENOME");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "Usuarios",
                newName: "SENHA");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Usuarios",
                newName: "NOME");

            migrationBuilder.RenameColumn(
                name: "Endereco",
                table: "Usuarios",
                newName: "ENDERECO");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Usuarios",
                newName: "EMAIL");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Usuarios",
                newName: "ID");

            migrationBuilder.AddColumn<bool>(
                name: "ADMINISTRADOR",
                table: "Usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ADMINISTRADOR",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "SOBRENOME",
                table: "Usuarios",
                newName: "SobreNome");

            migrationBuilder.RenameColumn(
                name: "SENHA",
                table: "Usuarios",
                newName: "Senha");

            migrationBuilder.RenameColumn(
                name: "NOME",
                table: "Usuarios",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "ENDERECO",
                table: "Usuarios",
                newName: "Endereco");

            migrationBuilder.RenameColumn(
                name: "EMAIL",
                table: "Usuarios",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Usuarios",
                newName: "Id");
        }
    }
}
