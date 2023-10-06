using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocadoraAPI.Migrations
{
    /// <inheritdoc />
    public partial class AtualizandoClasseOnibus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "descricao",
                table: "Carro",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "placa",
                table: "Carro",
                newName: "Placa");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Carro",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.CreateTable(
                name: "Onibus",
                columns: table => new
                {
                    Placa = table.Column<string>(type: "TEXT", nullable: false),
                    CapacidadeDePessoas = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Onibus", x => x.Placa);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Onibus");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Carro",
                newName: "descricao");

            migrationBuilder.RenameColumn(
                name: "Placa",
                table: "Carro",
                newName: "placa");

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "Carro",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
