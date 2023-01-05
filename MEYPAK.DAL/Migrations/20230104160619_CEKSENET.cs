using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class CEKSENET : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ACIKLAMA",
                table: "MPHESAPHAREKET",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ISLEMTURU",
                table: "MPHESAPHAREKET",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "MPFIRMACEKHAR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CEKID = table.Column<int>(type: "int", nullable: false),
                    TARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ISLEM = table.Column<int>(type: "int", nullable: false),
                    CARIID = table.Column<int>(type: "int", nullable: false),
                    BANKAID = table.Column<int>(type: "int", nullable: false),
                    KASAID = table.Column<int>(type: "int", nullable: false),
                    MASRAFID = table.Column<int>(type: "int", nullable: false),
                    MUHASEBEID = table.Column<int>(type: "int", nullable: false),
                    ALTHESAPID = table.Column<int>(type: "int", nullable: false),
                    USTID = table.Column<int>(type: "int", nullable: false),
                    DURUM = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPFIRMACEKHAR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPFIRMACEKNO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SERINO = table.Column<int>(type: "int", nullable: false),
                    CEKNO = table.Column<int>(type: "int", nullable: false),
                    VERBORDRONO = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPFIRMACEKNO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPFIRMACEKSB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USTID = table.Column<int>(type: "int", nullable: false),
                    BORDRONO = table.Column<int>(type: "int", nullable: false),
                    CEKNO = table.Column<int>(type: "int", nullable: false),
                    CARIID = table.Column<int>(type: "int", nullable: false),
                    CIKISTARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VADETARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ODEMETARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TUTAR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DOVIZID = table.Column<int>(type: "int", nullable: false),
                    KUR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DOVIZTUTAR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BANKA = table.Column<int>(type: "int", nullable: false),
                    SUBE = table.Column<int>(type: "int", nullable: false),
                    HESAPNO = table.Column<int>(type: "int", nullable: false),
                    SERINO = table.Column<int>(type: "int", nullable: false),
                    IBANNO = table.Column<int>(type: "int", nullable: false),
                    MUHASEBEID = table.Column<int>(type: "int", nullable: false),
                    ISLEM = table.Column<int>(type: "int", nullable: false),
                    DURUM = table.Column<int>(type: "int", nullable: false),
                    ACIKLAMA1 = table.Column<int>(type: "int", nullable: false),
                    ACIKLAMA2 = table.Column<int>(type: "int", nullable: false),
                    AKTIF = table.Column<int>(type: "int", nullable: false),
                    BANKAID = table.Column<int>(type: "int", nullable: false),
                    SONUSTID = table.Column<int>(type: "int", nullable: false),
                    ISLEMTIPI = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPFIRMACEKSB", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPFIRMASENETHAR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SENETID = table.Column<int>(type: "int", nullable: false),
                    TARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ISLEM = table.Column<int>(type: "int", nullable: false),
                    CARIID = table.Column<int>(type: "int", nullable: false),
                    BANKAID = table.Column<int>(type: "int", nullable: false),
                    KASAID = table.Column<int>(type: "int", nullable: false),
                    MASRAFID = table.Column<int>(type: "int", nullable: false),
                    MUHASEBEID = table.Column<int>(type: "int", nullable: false),
                    ALTHESAPID = table.Column<int>(type: "int", nullable: false),
                    USTID = table.Column<int>(type: "int", nullable: false),
                    DURUM = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPFIRMASENETHAR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPFIRMASENETNO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SERINO = table.Column<int>(type: "int", nullable: false),
                    SENETNO = table.Column<int>(type: "int", nullable: false),
                    VERBORDRONO = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPFIRMASENETNO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPFIRMASENETSB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USTID = table.Column<int>(type: "int", nullable: false),
                    BORDRONO = table.Column<int>(type: "int", nullable: false),
                    SENETNO = table.Column<int>(type: "int", nullable: false),
                    CARIID = table.Column<int>(type: "int", nullable: false),
                    CIKISTARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VADETARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ODEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TUTAR = table.Column<int>(type: "int", nullable: false),
                    DOVIZID = table.Column<int>(type: "int", nullable: false),
                    KUR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DOVIZTUTAR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    YERI = table.Column<int>(type: "int", nullable: false),
                    MUHASEBEID = table.Column<int>(type: "int", nullable: false),
                    ISLEM = table.Column<int>(type: "int", nullable: false),
                    DURUM = table.Column<int>(type: "int", nullable: false),
                    ACIKLAMA1 = table.Column<int>(type: "int", nullable: false),
                    ACIKLAMA2 = table.Column<int>(type: "int", nullable: false),
                    AKTIF = table.Column<int>(type: "int", nullable: false),
                    SONUSTID = table.Column<int>(type: "int", nullable: false),
                    ISLEMTIPI = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPFIRMASENETSB", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPKREDIKART",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BANKAID = table.Column<int>(type: "int", nullable: false),
                    KARTNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ACIKLAMA = table.Column<int>(type: "int", nullable: false),
                    AKTIFMI = table.Column<bool>(type: "bit", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPKREDIKART", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPMUSTERICEKHAR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CEKID = table.Column<int>(type: "int", nullable: false),
                    TARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CARID = table.Column<int>(type: "int", nullable: false),
                    ISLEM = table.Column<int>(type: "int", nullable: false),
                    BANKAID = table.Column<int>(type: "int", nullable: false),
                    KASAID = table.Column<int>(type: "int", nullable: false),
                    MASRAFID = table.Column<int>(type: "int", nullable: false),
                    MUHASEBEID = table.Column<int>(type: "int", nullable: false),
                    ALTHESID = table.Column<int>(type: "int", nullable: false),
                    USID = table.Column<int>(type: "int", nullable: false),
                    PROTESTOCARIID = table.Column<int>(type: "int", nullable: false),
                    PROTESTOBANKAID = table.Column<int>(type: "int", nullable: false),
                    DURUM = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPMUSTERICEKHAR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPMUSTERICEKNO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SERINO = table.Column<int>(type: "int", nullable: false),
                    CEKNO = table.Column<int>(type: "int", nullable: false),
                    VERBORDONO = table.Column<int>(type: "int", nullable: false),
                    ALBORDONO = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPMUSTERICEKNO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPMUSTERICEKSB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USTID = table.Column<int>(type: "int", nullable: false),
                    BORDRONO = table.Column<int>(type: "int", nullable: false),
                    CEKNO = table.Column<int>(type: "int", nullable: false),
                    CARIID = table.Column<int>(type: "int", nullable: false),
                    GIRISTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ASIL = table.Column<int>(type: "int", nullable: false),
                    CIROEDEN = table.Column<int>(type: "int", nullable: false),
                    VADETARIH = table.Column<int>(type: "int", nullable: false),
                    ODEMETARIH = table.Column<int>(type: "int", nullable: false),
                    TUTAR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DOVIZID = table.Column<int>(type: "int", nullable: false),
                    KUR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DOVTUTAR = table.Column<int>(type: "int", nullable: false),
                    BANKA = table.Column<int>(type: "int", nullable: false),
                    SUBE = table.Column<int>(type: "int", nullable: false),
                    HESAPNO = table.Column<int>(type: "int", nullable: false),
                    SERINO = table.Column<int>(type: "int", nullable: false),
                    IBANNO = table.Column<int>(type: "int", nullable: false),
                    MUHASEBEID = table.Column<int>(type: "int", nullable: false),
                    ISLEM = table.Column<int>(type: "int", nullable: false),
                    DURUM = table.Column<int>(type: "int", nullable: false),
                    ACIKLAMA1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ACIKLAMA2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AKTIF = table.Column<int>(type: "int", nullable: false),
                    IL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ILCE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VERILENID = table.Column<int>(type: "int", nullable: false),
                    VERILENBORDRONO = table.Column<int>(type: "int", nullable: false),
                    SONUSTID = table.Column<int>(type: "int", nullable: false),
                    CIROCARIID = table.Column<int>(type: "int", nullable: false),
                    CIROBANKAID = table.Column<int>(type: "int", nullable: false),
                    ISLTEMTIP = table.Column<int>(type: "int", nullable: false),
                    CIROEDENVKNTC = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPMUSTERICEKSB", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPMUSTERICEKSENET",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BELGETIP = table.Column<int>(type: "int", nullable: false),
                    FISTIP = table.Column<int>(type: "int", nullable: false),
                    TARIH = table.Column<int>(type: "int", nullable: false),
                    BELGENO = table.Column<int>(type: "int", nullable: false),
                    CARIID = table.Column<int>(type: "int", nullable: false),
                    ALTHESAPID = table.Column<int>(type: "int", nullable: false),
                    BANKAID = table.Column<int>(type: "int", nullable: false),
                    BANKAHESAPID = table.Column<int>(type: "int", nullable: false),
                    KASAID = table.Column<int>(type: "int", nullable: false),
                    ADET = table.Column<int>(type: "int", nullable: false),
                    TOPLAM = table.Column<int>(type: "int", nullable: false),
                    ORTALAMAVADE = table.Column<int>(type: "int", nullable: false),
                    ORTALAMAVADETARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CARHARID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BANKAHARID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOVIZID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KUR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOVIZTUTAR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KASAHARID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PROTESTOCARHARID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PROTESTOBANKAHARID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PROTESTOCIROCARIHARID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PROTESTOCIROMASRAFHARID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MUHASEBEID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISLEMTIPI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPMUSTERICEKSENET", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPMUSTERISENETHAR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SENETID = table.Column<int>(type: "int", nullable: false),
                    TARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ISLEM = table.Column<int>(type: "int", nullable: false),
                    CARIID = table.Column<int>(type: "int", nullable: false),
                    BANKAID = table.Column<int>(type: "int", nullable: false),
                    KASAID = table.Column<int>(type: "int", nullable: false),
                    MASRAFID = table.Column<int>(type: "int", nullable: false),
                    MUHASEBEID = table.Column<int>(type: "int", nullable: false),
                    ALTHESAPID = table.Column<int>(type: "int", nullable: false),
                    PROTESTOCARIID = table.Column<int>(type: "int", nullable: false),
                    PROTESTOBANKAID = table.Column<int>(type: "int", nullable: false),
                    USTID = table.Column<int>(type: "int", nullable: false),
                    PROTESTOCIROCARIID = table.Column<int>(type: "int", nullable: false),
                    PROTESTOCIROMASRAFCARIID = table.Column<int>(type: "int", nullable: false),
                    DURUM = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPMUSTERISENETHAR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPMUSTERISENETNO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SERINO = table.Column<int>(type: "int", nullable: false),
                    SENETNO = table.Column<int>(type: "int", nullable: false),
                    VERBORDRONO = table.Column<int>(type: "int", nullable: false),
                    ALBORDRONO = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPMUSTERISENETNO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPMUSTERISENETSB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USTID = table.Column<int>(type: "int", nullable: false),
                    BORDRONO = table.Column<int>(type: "int", nullable: false),
                    SENETNO = table.Column<int>(type: "int", nullable: false),
                    CARIID = table.Column<int>(type: "int", nullable: false),
                    GIRISTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ASIL = table.Column<int>(type: "int", nullable: false),
                    CIROEDEN = table.Column<int>(type: "int", nullable: false),
                    VADETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ODEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TUTAR = table.Column<int>(type: "int", nullable: false),
                    DOVIZID = table.Column<int>(type: "int", nullable: false),
                    KUR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DOVIZTUTAR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    YERI = table.Column<int>(type: "int", nullable: false),
                    MUHASEBEID = table.Column<int>(type: "int", nullable: false),
                    ISLEM = table.Column<int>(type: "int", nullable: false),
                    DURUM = table.Column<int>(type: "int", nullable: false),
                    ACIKLAMA1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ACIKLAMA2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AKTIF = table.Column<int>(type: "int", nullable: false),
                    VERILENID = table.Column<int>(type: "int", nullable: false),
                    SONUSTID = table.Column<int>(type: "int", nullable: false),
                    VERBORDRONO = table.Column<int>(type: "int", nullable: false),
                    CIROCARIID = table.Column<int>(type: "int", nullable: false),
                    CIROBANKAID = table.Column<int>(type: "int", nullable: false),
                    ISLEMTIPI = table.Column<int>(type: "int", nullable: false),
                    CIROEDENVKNTC = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPMUSTERISENETSB", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPFIRMACEKHAR");

            migrationBuilder.DropTable(
                name: "MPFIRMACEKNO");

            migrationBuilder.DropTable(
                name: "MPFIRMACEKSB");

            migrationBuilder.DropTable(
                name: "MPFIRMASENETHAR");

            migrationBuilder.DropTable(
                name: "MPFIRMASENETNO");

            migrationBuilder.DropTable(
                name: "MPFIRMASENETSB");

            migrationBuilder.DropTable(
                name: "MPKREDIKART");

            migrationBuilder.DropTable(
                name: "MPMUSTERICEKHAR");

            migrationBuilder.DropTable(
                name: "MPMUSTERICEKNO");

            migrationBuilder.DropTable(
                name: "MPMUSTERICEKSB");

            migrationBuilder.DropTable(
                name: "MPMUSTERICEKSENET");

            migrationBuilder.DropTable(
                name: "MPMUSTERISENETHAR");

            migrationBuilder.DropTable(
                name: "MPMUSTERISENETNO");

            migrationBuilder.DropTable(
                name: "MPMUSTERISENETSB");

            migrationBuilder.DropColumn(
                name: "ACIKLAMA",
                table: "MPHESAPHAREKET");

            migrationBuilder.DropColumn(
                name: "ISLEMTURU",
                table: "MPHESAPHAREKET");
        }
    }
}
