using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocadoraAPI.Migrations
{
    /// <inheritdoc />
    public partial class PrimeiroTesteFinal3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluguel_Veiculo_VeiculoPlaca",
                table: "Aluguel");

            migrationBuilder.RenameColumn(
                name: "VeiculoPlaca",
                table: "Aluguel",
                newName: "PlacaVeiculo");

            migrationBuilder.RenameIndex(
                name: "IX_Aluguel_VeiculoPlaca",
                table: "Aluguel",
                newName: "IX_Aluguel_PlacaVeiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluguel_Veiculo_PlacaVeiculo",
                table: "Aluguel",
                column: "PlacaVeiculo",
                principalTable: "Veiculo",
                principalColumn: "Placa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluguel_Veiculo_PlacaVeiculo",
                table: "Aluguel");

            migrationBuilder.RenameColumn(
                name: "PlacaVeiculo",
                table: "Aluguel",
                newName: "VeiculoPlaca");

            migrationBuilder.RenameIndex(
                name: "IX_Aluguel_PlacaVeiculo",
                table: "Aluguel",
                newName: "IX_Aluguel_VeiculoPlaca");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluguel_Veiculo_VeiculoPlaca",
                table: "Aluguel",
                column: "VeiculoPlaca",
                principalTable: "Veiculo",
                principalColumn: "Placa");
        }
    }
}
