using Microsoft.EntityFrameworkCore.Migrations;

namespace Desafio.Infraestrutura.Dados.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Desafio");

            migrationBuilder.CreateTable(
                name: "sala",
                schema: "Desafio",
                columns: table => new
                {
                    id_sala = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo_sala = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    nome_sala = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ordem_matriz = table.Column<int>(type: "int", nullable: false),
                    tipo_sala = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    tamanho_sala = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sala", x => x.id_sala);
                });

            migrationBuilder.CreateTable(
                name: "tamanho_sala",
                schema: "Desafio",
                columns: table => new
                {
                    id_tamanho_sala = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao_tamanho_sala = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tamanho_sala", x => x.id_tamanho_sala);
                });

            migrationBuilder.CreateTable(
                name: "tipo_sala",
                schema: "Desafio",
                columns: table => new
                {
                    id_sala = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao_tipo_sala = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_sala", x => x.id_sala);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sala",
                schema: "Desafio");

            migrationBuilder.DropTable(
                name: "tamanho_sala",
                schema: "Desafio");

            migrationBuilder.DropTable(
                name: "tipo_sala",
                schema: "Desafio");
        }
    }
}
