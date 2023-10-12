using Microsoft.EntityFrameworkCore.Migrations;

namespace Letra.Migrations
{
    public partial class letra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(nullable: true),
                    Sifre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ekibimiz",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UyeAdSoyad = table.Column<string>(nullable: true),
                    UyePozisyon = table.Column<string>(nullable: true),
                    UyeFotograf = table.Column<string>(nullable: true),
                    UyeLinkedin = table.Column<string>(nullable: true),
                    UyeGithub = table.Column<string>(nullable: true),
                    UyeMail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ekibimiz", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hakkimizda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    Logo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hakkimizda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "İletisim",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(nullable: true),
                    MailAdresi = table.Column<string>(nullable: true),
                    Mesaj = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_İletisim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Oyunlarimiz",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OyunAdi = table.Column<string>(nullable: true),
                    OyunAciklamasi = table.Column<string>(nullable: true),
                    OyunFotografi = table.Column<string>(nullable: true),
                    OyunLinki = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oyunlarimiz", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Ekibimiz");

            migrationBuilder.DropTable(
                name: "Hakkimizda");

            migrationBuilder.DropTable(
                name: "İletisim");

            migrationBuilder.DropTable(
                name: "Oyunlarimiz");
        }
    }
}
