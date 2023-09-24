using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bookStore.Migrations
{
    /// <inheritdoc />
    public partial class nomesVariaveisUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Editoras_EditoraID",
                table: "Livros");

            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Escritores_EscritorID",
                table: "Livros");

            migrationBuilder.RenameColumn(
                name: "EscritorID",
                table: "Livros",
                newName: "EscritorId");

            migrationBuilder.RenameColumn(
                name: "EditoraID",
                table: "Livros",
                newName: "EditoraId");

            migrationBuilder.RenameIndex(
                name: "IX_Livros_EscritorID",
                table: "Livros",
                newName: "IX_Livros_EscritorId");

            migrationBuilder.RenameIndex(
                name: "IX_Livros_EditoraID",
                table: "Livros",
                newName: "IX_Livros_EditoraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Editoras_EditoraId",
                table: "Livros",
                column: "EditoraId",
                principalTable: "Editoras",
                principalColumn: "EditoraId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Escritores_EscritorId",
                table: "Livros",
                column: "EscritorId",
                principalTable: "Escritores",
                principalColumn: "EscritorId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Editoras_EditoraId",
                table: "Livros");

            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Escritores_EscritorId",
                table: "Livros");

            migrationBuilder.RenameColumn(
                name: "EscritorId",
                table: "Livros",
                newName: "EscritorID");

            migrationBuilder.RenameColumn(
                name: "EditoraId",
                table: "Livros",
                newName: "EditoraID");

            migrationBuilder.RenameIndex(
                name: "IX_Livros_EscritorId",
                table: "Livros",
                newName: "IX_Livros_EscritorID");

            migrationBuilder.RenameIndex(
                name: "IX_Livros_EditoraId",
                table: "Livros",
                newName: "IX_Livros_EditoraID");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Editoras_EditoraID",
                table: "Livros",
                column: "EditoraID",
                principalTable: "Editoras",
                principalColumn: "EditoraId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Escritores_EscritorID",
                table: "Livros",
                column: "EscritorID",
                principalTable: "Escritores",
                principalColumn: "EscritorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
