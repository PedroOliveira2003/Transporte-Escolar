using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Transporte.Migrations
{
    /// <inheritdoc />
    public partial class Agendamentov1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agendamento",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    horario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estudanteid = table.Column<int>(type: "int", nullable: false),
                    veiculoid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamento", x => x.id);
                    table.ForeignKey(
                        name: "FK_Agendamento_Estudantes_estudanteid",
                        column: x => x.estudanteid,
                        principalTable: "Estudantes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agendamento_Veiculos_veiculoid",
                        column: x => x.veiculoid,
                        principalTable: "Veiculos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_estudanteid",
                table: "Agendamento",
                column: "estudanteid");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_veiculoid",
                table: "Agendamento",
                column: "veiculoid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendamento");
        }
    }
}
