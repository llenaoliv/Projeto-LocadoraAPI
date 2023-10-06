using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocadoraAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddClassesControlersAndModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carro");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Onibus",
                table: "Onibus");

            migrationBuilder.RenameTable(
                name: "Onibus",
                newName: "Veiculo");

            migrationBuilder.AlterColumn<int>(
                name: "CapacidadeDePessoas",
                table: "Veiculo",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Veiculo",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Veiculo",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "PesoDaCarga",
                table: "Veiculo",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Veiculo",
                table: "Veiculo",
                column: "Placa");

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Cpf = table.Column<string>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Cpf);
                });

            migrationBuilder.CreateTable(
                name: "Aluguel",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    CliCpf = table.Column<string>(type: "TEXT", nullable: false),
                    VeiculoAlugadoPlaca = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluguel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aluguel_Cliente_CliCpf",
                        column: x => x.CliCpf,
                        principalTable: "Cliente",
                        principalColumn: "Cpf",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Aluguel_Veiculo_VeiculoAlugadoPlaca",
                        column: x => x.VeiculoAlugadoPlaca,
                        principalTable: "Veiculo",
                        principalColumn: "Placa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aluguel_CliCpf",
                table: "Aluguel",
                column: "CliCpf");

            migrationBuilder.CreateIndex(
                name: "IX_Aluguel_VeiculoAlugadoPlaca",
                table: "Aluguel",
                column: "VeiculoAlugadoPlaca");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aluguel");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Veiculo",
                table: "Veiculo");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Veiculo");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Veiculo");

            migrationBuilder.DropColumn(
                name: "PesoDaCarga",
                table: "Veiculo");

            migrationBuilder.RenameTable(
                name: "Veiculo",
                newName: "Onibus");

            migrationBuilder.AlterColumn<string>(
                name: "CapacidadeDePessoas",
                table: "Onibus",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Onibus",
                table: "Onibus",
                column: "Placa");

            migrationBuilder.CreateTable(
                name: "Carro",
                columns: table => new
                {
                    Placa = table.Column<string>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carro", x => x.Placa);
                });
        }
    }
}
