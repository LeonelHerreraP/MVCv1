using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoMVC3.Migrations
{
    public partial class MigracionAutor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    id_autor = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ciudad = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    estado = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    pais = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    cod_postal = table.Column<int>(type: "int", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.id_autor);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autores");
        }
    }
}
