using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AulasAspNetMVC.Migrations
{
    public partial class AdicionandoNovoCampo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Pontos",
                table: "FilmesNovo",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pontos",
                table: "FilmesNovo");
        }
    }
}
