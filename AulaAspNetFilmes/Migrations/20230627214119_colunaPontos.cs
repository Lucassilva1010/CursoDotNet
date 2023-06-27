using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AulaAspNetFilmes.Migrations
{
    /// <inheritdoc />
    public partial class colunaPontos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Pontos",
                table: "Filme",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pontos",
                table: "Filme");
        }
    }
}
