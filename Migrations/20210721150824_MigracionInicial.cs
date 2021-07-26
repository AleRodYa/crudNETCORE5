using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudAspNetCore5.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Libro",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TITULO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DESCRIPCION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FECHA_LANZAMIENTO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AUTOR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PRECIO = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libro", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Libro");
        }
    }
}
