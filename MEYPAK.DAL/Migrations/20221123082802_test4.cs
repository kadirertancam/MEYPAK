using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "MPSTOKKASAHAR",
                newName: "STOKID");

            migrationBuilder.AddColumn<string>(
                name: "BELGE_NO",
                table: "MPSTOKKASAHAR",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FATURAID",
                table: "MPSTOKKASAHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IO",
                table: "MPSTOKKASAHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IRSALIYEID",
                table: "MPSTOKKASAHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KASAID",
                table: "MPSTOKKASAHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "MIKTAR",
                table: "MPSTOKKASAHAR",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "MPFATURA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SIPARISID = table.Column<int>(type: "int", nullable: false),
                    SIRKETID = table.Column<int>(type: "int", nullable: false),
                    SUBEID = table.Column<int>(type: "int", nullable: false),
                    DEPOID = table.Column<int>(type: "int", nullable: false),
                    CARIID = table.Column<int>(type: "int", nullable: false),
                    ALTHESAPID = table.Column<int>(type: "int", nullable: false),
                    KULLANICIID = table.Column<int>(type: "int", nullable: false),
                    FATURATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VADETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KULLANICITIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    CARIADI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VADEGUNU = table.Column<int>(type: "int", nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EKACIKLAMA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DOVIZID = table.Column<int>(type: "int", nullable: false),
                    KUR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SERINO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BELGENO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KDVDAHİL = table.Column<bool>(type: "bit", nullable: false),
                    NETTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KDVTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ISKONTOTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BRUTTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GENELTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ARACID = table.Column<int>(type: "int", nullable: false),
                    PERSONELID = table.Column<int>(type: "int", nullable: false),
                    TIP = table.Column<int>(type: "int", nullable: false),
                    DURUM = table.Column<bool>(type: "bit", nullable: false),
                    DONEM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPFATURA", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPFATURA");

            migrationBuilder.DropColumn(
                name: "BELGE_NO",
                table: "MPSTOKKASAHAR");

            migrationBuilder.DropColumn(
                name: "FATURAID",
                table: "MPSTOKKASAHAR");

            migrationBuilder.DropColumn(
                name: "IO",
                table: "MPSTOKKASAHAR");

            migrationBuilder.DropColumn(
                name: "IRSALIYEID",
                table: "MPSTOKKASAHAR");

            migrationBuilder.DropColumn(
                name: "KASAID",
                table: "MPSTOKKASAHAR");

            migrationBuilder.DropColumn(
                name: "MIKTAR",
                table: "MPSTOKKASAHAR");

            migrationBuilder.RenameColumn(
                name: "STOKID",
                table: "MPSTOKKASAHAR",
                newName: "MyProperty");
        }
    }
}
