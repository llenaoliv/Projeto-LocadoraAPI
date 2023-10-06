using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocadoraAPI.Migrations
{
    /// <inheritdoc />
    public partial class TrabalhoFinalTesteMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Aviao_CapacidadeDePessoas",
                table: "Veiculo",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CapacidadeCarga",
                table: "Veiculo",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cavalos",
                table: "Veiculo",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Motores",
                table: "Veiculo",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Onibus_CapacidadeDePessoas",
                table: "Veiculo",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aviao_CapacidadeDePessoas",
                table: "Veiculo");

            migrationBuilder.DropColumn(
                name: "CapacidadeCarga",
                table: "Veiculo");

            migrationBuilder.DropColumn(
                name: "Cavalos",
                table: "Veiculo");

            migrationBuilder.DropColumn(
                name: "Motores",
                table: "Veiculo");

            migrationBuilder.DropColumn(
                name: "Onibus_CapacidadeDePessoas",
                table: "Veiculo");
        }
    }
}
