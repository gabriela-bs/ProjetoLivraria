using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    public partial class refazendobanco001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    IdLivro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Subtitulo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Resumo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    QuantPaginas = table.Column<int>(type: "int", nullable: false),
                    DataPublicacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Editora = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Edicao = table.Column<int>(type: "int", nullable: true),
                    QuantLivros = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.IdLivro);
                });

            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    IdAutor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeAutor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LivroID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.IdAutor);
                    table.ForeignKey(
                        name: "FK_Autores_Livros_LivroID",
                        column: x => x.LivroID,
                        principalTable: "Livros",
                        principalColumn: "IdLivro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Autores_LivroID",
                table: "Autores",
                column: "LivroID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autores");

            migrationBuilder.DropTable(
                name: "Livros");
        }
    }
}
