using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Tarefas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 21, 20, 29, 47, 846, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 22, 20, 29, 47, 846, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 23, 20, 29, 47, 846, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 1,
                columns: new[] { "CriadoEm", "Status" },
                values: new object[] { new DateTime(2023, 11, 27, 20, 29, 47, 846, DateTimeKind.Local).AddTicks(3580), "Não iniciada" });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 2,
                columns: new[] { "CriadoEm", "Status" },
                values: new object[] { new DateTime(2023, 11, 23, 20, 29, 47, 846, DateTimeKind.Local).AddTicks(3580), "Não iniciada" });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 3,
                columns: new[] { "CriadoEm", "Status" },
                values: new object[] { new DateTime(2023, 12, 4, 20, 29, 47, 846, DateTimeKind.Local).AddTicks(3590), "Não iniciada" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Tarefas");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 21, 18, 37, 42, 5, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 22, 18, 37, 42, 5, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 23, 18, 37, 42, 5, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 27, 18, 37, 42, 5, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 23, 18, 37, 42, 5, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2023, 12, 4, 18, 37, 42, 5, DateTimeKind.Local).AddTicks(9890));
        }
    }
}
