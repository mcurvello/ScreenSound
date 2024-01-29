using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopulateTable6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoLancamento", "ArtistaId" }, new object[] { "Oceano", 1989, 1 });

            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoLancamento", "ArtistaId" }, new object[] { "Flor de Lis", 1976, 2 });

            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoLancamento", "ArtistaId" }, new object[] { "Samurai", 1982, 2 });

            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoLancamento", "ArtistaId" }, new object[] { "Se", 1992, 4 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
