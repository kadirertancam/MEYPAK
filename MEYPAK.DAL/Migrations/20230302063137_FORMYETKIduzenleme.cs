using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class FORMYETKIduzenleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KULLANICIID",
                table: "MPFORMYETKI",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "MPDEKONT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CARIID = table.Column<int>(type: "int", nullable: false),
                    BANKAID = table.Column<int>(type: "int", nullable: false),
                    PERSONELID = table.Column<int>(type: "int", nullable: false),
                    KASAID = table.Column<int>(type: "int", nullable: false),
                    MUHASEBEID = table.Column<int>(type: "int", nullable: false),
                    BELGENO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ALTHESAPID = table.Column<int>(type: "int", nullable: false),
                    BORC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ALACAK = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KDV = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KDVDAHILEDILSIN = table.Column<bool>(type: "bit", nullable: false),
                    DEPO = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false),
                    USERID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPDEKONT", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPEFATURAPARAM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KULADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIFRE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false),
                    USERID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPEFATURAPARAM", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPPERSONELBELGE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PERSONELID = table.Column<int>(type: "int", nullable: false),
                    NUM = table.Column<int>(type: "int", nullable: false),
                    IMG = table.Column<string>(type: "ntext", nullable: false),
                    BELGETIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false),
                    USERID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPPERSONELBELGE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPSOFOR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ADI = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SOYADI = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TELEFON = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CEPNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBASTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ISBITTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false),
                    USERID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSOFOR", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPDEKONT");

            migrationBuilder.DropTable(
                name: "MPEFATURAPARAM");

            migrationBuilder.DropTable(
                name: "MPPERSONELBELGE");

            migrationBuilder.DropTable(
                name: "MPSOFOR");

            migrationBuilder.DropColumn(
                name: "KULLANICIID",
                table: "MPFORMYETKI");
        }
    }
}
