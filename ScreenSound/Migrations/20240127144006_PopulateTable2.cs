using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopulateTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "FotoPerfil", "Bio" }, new object[] { "Djavan", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png", "Djavan Caetano Viana é um cantor, compositor, arranjador, produtor musical, empresário, violonista e ex-futebolista brasileiro." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artistas");
        }
    }
}
