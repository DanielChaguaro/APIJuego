using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIJuego.Migrations
{
    /// <inheritdoc />
    public partial class CreateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "fechasganada",
                columns: table => new
                {
                    IdJuego = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechaganada = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fechasganada", x => x.IdJuego);
                });

            migrationBuilder.InsertData(
                table: "fechasganada",
                columns: new[] { "IdJuego", "fechaganada" },
                values: new object[] { 1, new DateTime(2024, 1, 24, 9, 6, 11, 945, DateTimeKind.Local).AddTicks(6591) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "fechasganada");
        }
    }
}
