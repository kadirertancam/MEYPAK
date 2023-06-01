using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class aktifvers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BILDIRIMTURU",
                table: "MPIRSALIYE",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BILDIRIMTURUID",
                table: "MPIRSALIYE",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TIP",
                table: "MPFATURASTOKESLE",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BELDE",
                table: "MPCARIKART",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BELDEID",
                table: "MPCARIKART",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ISLETMETURU",
                table: "MPCARIKART",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ISLETMETURUID",
                table: "MPCARIKART",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SIFAT",
                table: "MPCARIKART",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SIFATID",
                table: "MPCARIKART",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SUBE",
                table: "MPCARIKART",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SUBEID",
                table: "MPCARIKART",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MPARACBELGE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ARACID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_MPARACBELGE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPARACZIMMET",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ARACID = table.Column<int>(type: "int", nullable: false),
                    ZIMMETTARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TESLIMTARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MARKAMODEL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SERINO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MIKTAR = table.Column<int>(type: "int", nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TESLIMALINDI = table.Column<bool>(type: "bit", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false),
                    USERID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPARACZIMMET", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPFATURADETAYTASLAK",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FATURATASLAKID = table.Column<int>(type: "int", nullable: false),
                    STOKID = table.Column<int>(type: "int", nullable: false),
                    BIRIMID = table.Column<int>(type: "int", nullable: false),
                    DOVIZID = table.Column<int>(type: "int", nullable: false),
                    LISTEFIYATID = table.Column<int>(type: "int", nullable: false),
                    KULLANICIID = table.Column<int>(type: "int", nullable: false),
                    NUM = table.Column<int>(type: "int", nullable: false),
                    TIP = table.Column<byte>(type: "tinyint", nullable: false),
                    STOKADI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TEVKIFATNO = table.Column<int>(type: "int", nullable: false),
                    ISTISNANO = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_MPFATURADETAYTASLAK", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPFATURATASLAKACBELGE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TASLAKADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IRSALIYEID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_MPFATURATASLAKACBELGE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPIRSALIYEDETAYTASLAK",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IRSALIYEDETAYID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_MPIRSALIYEDETAYTASLAK", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPIRSALIYETASLAK",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TASLAKADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIPARISID = table.Column<int>(type: "int", nullable: false),
                    SIRKETID = table.Column<int>(type: "int", nullable: false),
                    SUBEID = table.Column<int>(type: "int", nullable: false),
                    DEPOID = table.Column<int>(type: "int", nullable: false),
                    CARIID = table.Column<int>(type: "int", nullable: false),
                    ALTHESAPID = table.Column<int>(type: "int", nullable: false),
                    KULLANICIID = table.Column<int>(type: "int", nullable: false),
                    IRSALIYETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SEVKIYATTARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    ALTISKONTO1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ALTISKONTO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ALTISKONTO3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ISKONTOTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BRUTTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GENELTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ARACID = table.Column<int>(type: "int", nullable: false),
                    DORSEID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_MPIRSALIYETASLAK", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPARACBELGE");

            migrationBuilder.DropTable(
                name: "MPARACZIMMET");

            migrationBuilder.DropTable(
                name: "MPFATURADETAYTASLAK");

            migrationBuilder.DropTable(
                name: "MPFATURATASLAKACBELGE");

            migrationBuilder.DropTable(
                name: "MPIRSALIYEDETAYTASLAK");

            migrationBuilder.DropTable(
                name: "MPIRSALIYETASLAK");

            migrationBuilder.DropColumn(
                name: "BILDIRIMTURU",
                table: "MPIRSALIYE");

            migrationBuilder.DropColumn(
                name: "BILDIRIMTURUID",
                table: "MPIRSALIYE");

            migrationBuilder.DropColumn(
                name: "TIP",
                table: "MPFATURASTOKESLE");

            migrationBuilder.DropColumn(
                name: "BELDE",
                table: "MPCARIKART");

            migrationBuilder.DropColumn(
                name: "BELDEID",
                table: "MPCARIKART");

            migrationBuilder.DropColumn(
                name: "ISLETMETURU",
                table: "MPCARIKART");

            migrationBuilder.DropColumn(
                name: "ISLETMETURUID",
                table: "MPCARIKART");

            migrationBuilder.DropColumn(
                name: "SIFAT",
                table: "MPCARIKART");

            migrationBuilder.DropColumn(
                name: "SIFATID",
                table: "MPCARIKART");

            migrationBuilder.DropColumn(
                name: "SUBE",
                table: "MPCARIKART");

            migrationBuilder.DropColumn(
                name: "SUBEID",
                table: "MPCARIKART");
        }
    }
}
