using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocadoraAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddClassesControlersAndModelsaltereiNaoNulos : Migration
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

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cliente",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "VeiculoAlugadoPlaca",
                table: "Aluguel",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "CliCpf",
                table: "Aluguel",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluguel_Cliente_CliCpf",
                table: "Aluguel");

            migrationBuilder.DropForeignKey(
                name: "FK_Aluguel_Veiculo_VeiculoAlugadoPlaca",
                table: "Aluguel");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cliente",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VeiculoAlugadoPlaca",
                table: "Aluguel",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CliCpf",
                table: "Aluguel",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Aluguel_Cliente_CliCpf",
                table: "Aluguel",
                column: "CliCpf",
                principalTable: "Cliente",
                principalColumn: "Cpf",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Aluguel_Veiculo_VeiculoAlugadoPlaca",
                table: "Aluguel",
                column: "VeiculoAlugadoPlaca",
                principalTable: "Veiculo",
                principalColumn: "Placa",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
