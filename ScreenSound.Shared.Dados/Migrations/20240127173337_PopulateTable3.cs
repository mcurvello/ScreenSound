using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopulateTable3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "FotoPerfil", "Bio" }, new object[] { "Foo Fighters", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png", "Foo Fighters é uma banda de rock alternativo americana formada por Dave Grohl em 1995." });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "FotoPerfil", "Bio" }, new object[] { "Pitty", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png", "Priscilla Novaes Leone, mais conhecida como Pitty, é uma cantora, compositora, produtora, escritora, empresária, apresentadora e multi-instrumentista brasileira." });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "FotoPerfil", "Bio" }, new object[] { "Gilberto Gil", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png", "Gilberto Passos Gil Moreira é um cantor, compositor, multi-instrumentista, produtor musical, político e escritor brasileiro." });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "FotoPerfil", "Bio" }, new object[] { "Foo Fighters", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png", "Foo Fighters é uma banda de rock alternativo americana formada por Dave Grohl em 1995." });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "FotoPerfil", "Bio" }, new object[] { "Pitty", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png", "Priscilla Novaes Leone, mais conhecida como Pitty, é uma cantora, compositora, produtora, escritora, empresária, apresentadora e multi-instrumentista brasileira." });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "FotoPerfil", "Bio" }, new object[] { "Roque Abílio", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png", "Recriando músicas famosas com uma reviravolta rockabilly, a Roque Abílio cativa o público com uma explosão autêntica do passado que ainda faz todo mundo dançar no presente." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
