using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class Degisiklikler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MUSTAHSILCARIID",
                table: "MPSTOKKASAHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MUSTAHSILDETAYID",
                table: "MPSTOKKASAHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MUSTAHSILID",
                table: "MPSTOKKASAHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MUSTAHSILDETAYID",
                table: "MPSTOKHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MUSTAHSILID",
                table: "MPSTOKHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DORSEID",
                table: "MPIRSALIYE",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MUSTAHSILDETAYID",
                table: "MPHIZMETHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MUSTAHSILID",
                table: "MPHIZMETHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MPDESTEKSERVISS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SOYAD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BASLIK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DEPARTMAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MESAJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ONCELIK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BELGE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false),
                    USERID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPDESTEKSERVISS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPFATURASTOKOLCUBR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OLCUBRID = table.Column<int>(type: "int", nullable: false),
                    KISA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false),
                    USERID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPFATURASTOKOLCUBR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPGIDENFATURALAR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FATURAID = table.Column<int>(type: "int", nullable: false),
                    BELGENO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TIP = table.Column<int>(type: "int", nullable: false),
                    HATAKODU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DURUM = table.Column<int>(type: "int", nullable: false),
                    ETTNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false),
                    USERID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPGIDENFATURALAR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPGIDENIRSALIYELER",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IRSALIYEID = table.Column<int>(type: "int", nullable: false),
                    BELGENO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TIP = table.Column<int>(type: "int", nullable: false),
                    HATAKODU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DURUM = table.Column<int>(type: "int", nullable: false),
                    ETTNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false),
                    USERID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPGIDENIRSALIYELER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPGIDENMUSTAHSILMAKBUZLARI",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MUSTAHSILID = table.Column<int>(type: "int", nullable: false),
                    BELGENO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TIP = table.Column<int>(type: "int", nullable: false),
                    HATAKODU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DURUM = table.Column<int>(type: "int", nullable: false),
                    ETTNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false),
                    USERID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPGIDENMUSTAHSILMAKBUZLARI", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPMUSTAHSIL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SIRKETID = table.Column<int>(type: "int", nullable: false),
                    SUBEID = table.Column<int>(type: "int", nullable: false),
                    DEPOID = table.Column<int>(type: "int", nullable: false),
                    MUSTAHSILCARIID = table.Column<int>(type: "int", nullable: false),
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
                    KDVDAHIL = table.Column<bool>(type: "bit", nullable: false),
                    NETTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KDVTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ALTISKONTO1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ALTISKONTO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ALTISKONTO3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    ESKIID = table.Column<int>(type: "int", nullable: false),
                    USERID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPMUSTAHSIL", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPMUSTAHSILCARI",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KOD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TCNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SOYADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ILCE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    POSTAKODU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TELEFON1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TELEFON2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false),
                    USERID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPMUSTAHSILCARI", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPMUSTAHSILCARIHAR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MUSTAHSILID = table.Column<int>(type: "int", nullable: false),
                    HAREKETTIPI = table.Column<int>(type: "int", nullable: false),
                    BORC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ALACAK = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TUTAR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BELGE_NO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HAREKETTARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PARABIRIMID = table.Column<int>(type: "int", nullable: false),
                    KUR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false),
                    USERID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPMUSTAHSILCARIHAR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPMUSTAHSILDETAY",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MUSTAHSILID = table.Column<int>(type: "int", nullable: false),
                    STOKID = table.Column<int>(type: "int", nullable: false),
                    BIRIMID = table.Column<int>(type: "int", nullable: false),
                    DOVIZID = table.Column<int>(type: "int", nullable: false),
                    LISTEFIYATID = table.Column<int>(type: "int", nullable: false),
                    KULLANICIID = table.Column<int>(type: "int", nullable: false),
                    KASAID = table.Column<int>(type: "int", nullable: false),
                    NUM = table.Column<int>(type: "int", nullable: false),
                    TIP = table.Column<byte>(type: "tinyint", nullable: false),
                    STOKADI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    KASAMIKTAR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DARALI = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DARA = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SAFI = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ISKONTO1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ISKONTO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ISKONTO3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ISKTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BIRIMFIYAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NETFIYAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BRUTFIYAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NETTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BRUTTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BEKLEYENMIKTAR = table.Column<int>(type: "int", nullable: false),
                    HAREKETDURUMU = table.Column<byte>(type: "tinyint", nullable: false),
                    KDV = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KDVTUTARI = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KUNYE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false),
                    USERID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPMUSTAHSILDETAY", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPDESTEKSERVISS");

            migrationBuilder.DropTable(
                name: "MPFATURASTOKOLCUBR");

            migrationBuilder.DropTable(
                name: "MPGIDENFATURALAR");

            migrationBuilder.DropTable(
                name: "MPGIDENIRSALIYELER");

            migrationBuilder.DropTable(
                name: "MPGIDENMUSTAHSILMAKBUZLARI");

            migrationBuilder.DropTable(
                name: "MPMUSTAHSIL");

            migrationBuilder.DropTable(
                name: "MPMUSTAHSILCARI");

            migrationBuilder.DropTable(
                name: "MPMUSTAHSILCARIHAR");

            migrationBuilder.DropTable(
                name: "MPMUSTAHSILDETAY");

            migrationBuilder.DropColumn(
                name: "MUSTAHSILCARIID",
                table: "MPSTOKKASAHAR");

            migrationBuilder.DropColumn(
                name: "MUSTAHSILDETAYID",
                table: "MPSTOKKASAHAR");

            migrationBuilder.DropColumn(
                name: "MUSTAHSILID",
                table: "MPSTOKKASAHAR");

            migrationBuilder.DropColumn(
                name: "MUSTAHSILDETAYID",
                table: "MPSTOKHAR");

            migrationBuilder.DropColumn(
                name: "MUSTAHSILID",
                table: "MPSTOKHAR");

            migrationBuilder.DropColumn(
                name: "DORSEID",
                table: "MPIRSALIYE");

            migrationBuilder.DropColumn(
                name: "MUSTAHSILDETAYID",
                table: "MPHIZMETHAR");

            migrationBuilder.DropColumn(
                name: "MUSTAHSILID",
                table: "MPHIZMETHAR");
        }
    }
}
