using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Transporte.Migrations
{
    /// <inheritdoc />
    public partial class Agendamentov2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamento_Estudantes_estudanteid",
                table: "Agendamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Agendamento_Veiculos_veiculoid",
                table: "Agendamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Agendamento",
                table: "Agendamento");

            migrationBuilder.DropIndex(
                name: "IX_Agendamento_estudanteid",
                table: "Agendamento");

            migrationBuilder.DropIndex(
                name: "IX_Agendamento_veiculoid",
                table: "Agendamento");

            migrationBuilder.RenameTable(
                name: "Agendamento",
                newName: "Agendamentos");

            migrationBuilder.RenameColumn(
                name: "veiculoid",
                table: "Agendamentos",
                newName: "idVeiculo");

            migrationBuilder.RenameColumn(
                name: "estudanteid",
                table: "Agendamentos",
                newName: "IdEstudante");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "horario",
                table: "Agendamentos",
                type: "time",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "data",
                table: "Agendamentos",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agendamentos",
                table: "Agendamentos",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Agendamentos",
                table: "Agendamentos");

            migrationBuilder.RenameTable(
                name: "Agendamentos",
                newName: "Agendamento");

            migrationBuilder.RenameColumn(
                name: "idVeiculo",
                table: "Agendamento",
                newName: "veiculoid");

            migrationBuilder.RenameColumn(
                name: "IdEstudante",
                table: "Agendamento",
                newName: "estudanteid");

            migrationBuilder.AlterColumn<string>(
                name: "horario",
                table: "Agendamento",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<string>(
                name: "data",
                table: "Agendamento",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agendamento",
                table: "Agendamento",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_estudanteid",
                table: "Agendamento",
                column: "estudanteid");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_veiculoid",
                table: "Agendamento",
                column: "veiculoid");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamento_Estudantes_estudanteid",
                table: "Agendamento",
                column: "estudanteid",
                principalTable: "Estudantes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamento_Veiculos_veiculoid",
                table: "Agendamento",
                column: "veiculoid",
                principalTable: "Veiculos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
