using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contas.EfCore.Migrations
{
    public partial class tipolancamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into tipo_lancamento (id, descricao) values (1, 'SALÁRIO')");
            migrationBuilder.Sql("insert into tipo_lancamento (id, descricao) values (2, 'VALE')");
            migrationBuilder.Sql("insert into tipo_lancamento (id, descricao) values (3, 'PARCELAMENTO NUBANK')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
