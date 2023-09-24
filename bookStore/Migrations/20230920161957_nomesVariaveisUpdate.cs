using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bookStore.Migrations
{
    /// <inheritdoc />
    public partial class nomesVariaveisUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Epigrafe",
                table: "Livros",
                newName: "Sinopse");

            migrationBuilder.RenameColumn(
                name: "URLFoto",
                table: "Editoras",
                newName: "URLLogo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sinopse",
                table: "Livros",
                newName: "Epigrafe");

            migrationBuilder.RenameColumn(
                name: "URLLogo",
                table: "Editoras",
                newName: "URLFoto");
        }
    }
}
