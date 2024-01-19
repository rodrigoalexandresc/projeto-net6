using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Contas.EfCore.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tipo-lancamento",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tipo-lancamento", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "lancamento",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "text", nullable: false),
                    tipolancamentoid = table.Column<int>(name: "tipo-lancamento-id", type: "integer", nullable: false),
                    data = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_lancamento", x => x.id);
                    table.ForeignKey(
                        name: "fk_lancamento_tipo-lancamento_tipo-lancamento-id",
                        column: x => x.tipolancamentoid,
                        principalTable: "tipo-lancamento",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_lancamento_tipo-lancamento-id",
                table: "lancamento",
                column: "tipo-lancamento-id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lancamento");

            migrationBuilder.DropTable(
                name: "tipo-lancamento");
        }
    }
}
