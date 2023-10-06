using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocadoraAPI.Migrations
{
    /// <inheritdoc />
    public partial class TrabalhoFinalAlteredeCadastrarAlugel09 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluguel_Cliente_CliCpf",
                table: "Aluguel");

            migrationBuilder.DropForeignKey(
                name: "FK_Aluguel_Veiculo_VeiculoAlugadoPlaca",
                table: "Aluguel");

            migrationBuilder.RenameColumn(
                name: "VeiculoAlugadoPlaca",
                table: "Aluguel",
                newName: "VeiculoPlaca");

            migrationBuilder.RenameColumn(
                name: "CliCpf",
                table: "Aluguel",
                newName: "ClienteCpf");

            migrationBuilder.RenameIndex(
                name: "IX_Aluguel_VeiculoAlugadoPlaca",
                table: "Aluguel",
                newName: "IX_Aluguel_VeiculoPlaca");

            migrationBuilder.RenameIndex(
                name: "IX_Aluguel_CliCpf",
                table: "Aluguel",
                newName: "IX_Aluguel_ClienteCpf");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluguel_Cliente_ClienteCpf",
                table: "Aluguel",
                column: "ClienteCpf",
                principalTable: "Cliente",
                principalColumn: "Cpf");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluguel_Veiculo_VeiculoPlaca",
                table: "Aluguel",
                column: "VeiculoPlaca",
                principalTable: "Veiculo",
                principalColumn: "Placa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluguel_Cliente_ClienteCpf",
                table: "Aluguel");

            migrationBuilder.DropForeignKey(
                name: "FK_Aluguel_Veiculo_VeiculoPlaca",
                table: "Aluguel");

            migrationBuilder.RenameColumn(
                name: "VeiculoPlaca",
                table: "Aluguel",
                newName: "VeiculoAlugadoPlaca");

            migrationBuilder.RenameColumn(
                name: "ClienteCpf",
                table: "Aluguel",
                newName: "CliCpf");

            migrationBuilder.RenameIndex(
                name: "IX_Aluguel_VeiculoPlaca",
                table: "Aluguel",
                newName: "IX_Aluguel_VeiculoAlugadoPlaca");

            migrationBuilder.RenameIndex(
                name: "IX_Aluguel_ClienteCpf",
                table: "Aluguel",
                newName: "IX_Aluguel_CliCpf");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluguel_Cliente_CliCpf",
                table: "Aluguel",
                column: "CliCpf",
                principalTable: "Cliente",
                principalColumn: "Cpf");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluguel_Veiculo_VeiculoAlugadoPlaca",
                table: "Aluguel",
                column: "VeiculoAlugadoPlaca",
                principalTable: "Veiculo",
                principalColumn: "Placa");
        }
    }
}
