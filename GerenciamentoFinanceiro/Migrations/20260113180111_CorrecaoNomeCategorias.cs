using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciamentoFinanceiro.Migrations
{
    /// <inheritdoc />
    public partial class CorrecaoNomeCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "comissao",
                column: "Nome",
                value: "Comissão");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "educacao",
                column: "Nome",
                value: "Educação");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "comissao",
                column: "Nome",
                value: "Comissao");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "educacao",
                column: "Nome",
                value: "Educacao");
        }
    }
}
