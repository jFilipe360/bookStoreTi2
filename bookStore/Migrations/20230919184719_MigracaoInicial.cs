using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bookStore.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Editoras",
                columns: table => new
                {
                    EditoraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    URLFoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeEditora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnoFundacao = table.Column<int>(type: "int", nullable: false),
                    Slogan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editoras", x => x.EditoraId);
                });

            migrationBuilder.CreateTable(
                name: "Escritores",
                columns: table => new
                {
                    EscritorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    URLFoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Biografia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escritores", x => x.EscritorId);
                });

            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Epigrafe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    URlImagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataLancamento = table.Column<int>(type: "int", nullable: false),
                    LivroCategora = table.Column<int>(type: "int", nullable: false),
                    EditoraID = table.Column<int>(type: "int", nullable: false),
                    EscritorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Livros_Editoras_EditoraID",
                        column: x => x.EditoraID,
                        principalTable: "Editoras",
                        principalColumn: "EditoraId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Livros_Escritores_EscritorID",
                        column: x => x.EscritorID,
                        principalTable: "Escritores",
                        principalColumn: "EscritorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Livros_EditoraID",
                table: "Livros",
                column: "EditoraID");

            migrationBuilder.CreateIndex(
                name: "IX_Livros_EscritorID",
                table: "Livros",
                column: "EscritorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livros");

            migrationBuilder.DropTable(
                name: "Editoras");

            migrationBuilder.DropTable(
                name: "Escritores");
        }
    }
}
