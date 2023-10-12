using Microsoft.EntityFrameworkCore.Migrations;

namespace Letra.Migrations
{
    public partial class RenameLogoToLogoLinkInHakkimizdaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Hakkimizda");

            migrationBuilder.AddColumn<string>(
                name: "LogoLink",
                table: "Hakkimizda",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LogoLink",
                table: "Hakkimizda");

            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "Hakkimizda",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
