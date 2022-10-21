using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKKontrol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MPARACLAR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OLUTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SIRKETID = table.Column<int>(type: "int", nullable: false),
                    SUBEID = table.Column<int>(type: "int", nullable: false),
                    PLAKA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MARKA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MODEL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    YIL = table.Column<int>(type: "int", nullable: false),
                    PERSONELID = table.Column<int>(type: "int", nullable: false),
                    ARACKM = table.Column<int>(type: "int", nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    SERVISTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MUAYENETAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPARACLAR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPDEPO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SIRKETID = table.Column<int>(type: "int", nullable: false),
                    DEPOKODU = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DEPOADI = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPDEPO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPDEPOTRANSFER",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CIKTIDEPOID = table.Column<int>(type: "int", nullable: false),
                    HEDEFDEPOID = table.Column<int>(type: "int", nullable: false),
                    DURUM = table.Column<byte>(type: "tinyint", nullable: false),
                    DONEM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPDEPOTRANSFER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPHIZMET",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KOD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ADI = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    KDV = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OTV = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GRUPKODU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ACIKLAMA1 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ACIKLAMA2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ACIKLAMA3 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ACIKLAMA4 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ACIKLAMA5 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ACIKLAMA6 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ACIKLAMA7 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ACIKLAMA8 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ACIKLAMA9 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    KATEGORIID = table.Column<int>(type: "int", nullable: false),
                    RAPORKODU1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RAPORKODU2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RAPORKODU3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RAPORKODU4 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RAPORKODU5 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RAPORKODU6 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RAPORKODU7 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RAPORKODU8 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RAPORKODU9 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DONEM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPHIZMET", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPKATEGORI",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UstId = table.Column<int>(type: "int", nullable: false),
                    AltID = table.Column<int>(type: "int", nullable: false),
                    Acıklama = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DONEM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPKATEGORI", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPMARKA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADI = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPMARKA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPOLCUBR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ADI = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BIRIM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KULLANICIID = table.Column<int>(type: "int", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPOLCUBR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPPERSONEL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SIRKETID = table.Column<int>(type: "int", nullable: false),
                    SUBEID = table.Column<int>(type: "int", nullable: false),
                    TC = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    ADI = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SOYADI = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SGKSICIL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DOGUMTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ISBASTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ISBITTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RESIM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EHLIYETNO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TEL = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KANGRUBU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ADRES = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    GOREVI = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SCR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PSIKOTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MEDENIDURUM = table.Column<int>(type: "int", nullable: false),
                    ASKERLIK = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DURUM = table.Column<byte>(type: "tinyint", nullable: false),
                    PSD = table.Column<int>(type: "int", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    DONEM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPPERSONEL", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPSTOK",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SIRKETID = table.Column<int>(type: "int", nullable: false),
                    SUBEID = table.Column<int>(type: "int", nullable: false),
                    DEPOID = table.Column<int>(type: "int", nullable: false),
                    KASAID = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KOD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ADI = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MARKAID = table.Column<int>(type: "int", nullable: false),
                    KATEGORIID = table.Column<int>(type: "int", nullable: false),
                    OLCUBR1 = table.Column<int>(type: "int", nullable: false),
                    SDOVIZID = table.Column<int>(type: "int", nullable: false),
                    ADOVIZID = table.Column<int>(type: "int", nullable: false),
                    SFIYAT1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SFIYAT2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SFIYAT3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SFIYAT4 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SFIYAT5 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AFIYAT1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AFIYAT2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AFIYAT3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AFIYAT4 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AFIYAT5 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SATISKDV = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ALISKDV = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SATISOTV = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ALISOTV = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GRUPKODU = table.Column<int>(type: "int", nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ACIKLAMA1 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ACIKLAMA2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ACIKLAMA3 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ACIKLAMA4 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ACIKLAMA5 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SACIKLAMA = table.Column<int>(type: "int", nullable: false),
                    SACIKLAMA1 = table.Column<int>(type: "int", nullable: false),
                    SACIKLAMA2 = table.Column<int>(type: "int", nullable: false),
                    SACIKLAMA3 = table.Column<int>(type: "int", nullable: false),
                    SACIKLAMA4 = table.Column<int>(type: "int", nullable: false),
                    SACIKLAMA5 = table.Column<int>(type: "int", nullable: false),
                    RAPORKODU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RAPORKODU1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RAPORKODU2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RAPORKODU3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RAPORKODU4 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RAPORKODU5 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RAPORKODU6 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RAPORKODU7 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RAPORKODU8 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RAPORKODU9 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GTIN = table.Column<int>(type: "int", nullable: false),
                    KULLANICIID = table.Column<int>(type: "int", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    DONEM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSTOK", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPSTOKFIYATLIST",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SIRKETID = table.Column<int>(type: "int", nullable: false),
                    SUBEID = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FIYATLISTADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BASTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BITTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KULLANICIID = table.Column<int>(type: "int", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    DONEM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSTOKFIYATLIST", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPSTOKKASA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SIRKETID = table.Column<int>(type: "int", nullable: false),
                    SUBEID = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KASAKODU = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KASAADI = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AKTIF = table.Column<byte>(type: "tinyint", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSTOKKASA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPSTOKSAYIM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIRMAID = table.Column<int>(type: "int", nullable: false),
                    SUBEID = table.Column<int>(type: "int", nullable: false),
                    DEPOID = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SAYIMTARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DURUM = table.Column<int>(type: "int", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSTOKSAYIM", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPSIPARIS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SIRKETID = table.Column<int>(type: "int", nullable: false),
                    SUBEID = table.Column<int>(type: "int", nullable: false),
                    DEPOID = table.Column<int>(type: "int", nullable: false),
                    CARIID = table.Column<int>(type: "int", nullable: false),
                    ALTHESAPID = table.Column<int>(type: "int", nullable: false),
                    KULLANICIID = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SIPARISTARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SEVKIYATTARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VADETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KULLANICITIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    CARIADI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TIP = table.Column<int>(type: "int", nullable: false),
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
                    DURUM = table.Column<bool>(type: "bit", nullable: false),
                    DONEM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSIPARIS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MPSIPARIS_MPDEPO_DEPOID",
                        column: x => x.DEPOID,
                        principalTable: "MPDEPO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MPDEPOTRANSFERHAR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DEPOTRANSFERID = table.Column<int>(type: "int", nullable: false),
                    STOKID = table.Column<int>(type: "int", nullable: false),
                    MIKTAR = table.Column<int>(type: "int", nullable: false),
                    DURUM = table.Column<byte>(type: "tinyint", nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DONEM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPDEPOTRANSFERHAR", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MPDEPOTRANSFERHAR_MPDEPOTRANSFER_DEPOTRANSFERID",
                        column: x => x.DEPOTRANSFERID,
                        principalTable: "MPDEPOTRANSFER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MPDEPOTRANSFERHAR_MPSTOK_STOKID",
                        column: x => x.STOKID,
                        principalTable: "MPSTOK",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MPSTOKHAR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    STOKID = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HAREKETTURU = table.Column<int>(type: "int", nullable: false),
                    SIRKETID = table.Column<int>(type: "int", nullable: false),
                    SUBEID = table.Column<int>(type: "int", nullable: false),
                    DEPOID = table.Column<int>(type: "int", nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    BELGE_NO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FATURAID = table.Column<int>(type: "int", nullable: false),
                    KDV = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IO = table.Column<int>(type: "int", nullable: false),
                    NETFIYAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MIKTAR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BIRIM = table.Column<int>(type: "int", nullable: false),
                    NETTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BRUTTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SAYIMID = table.Column<int>(type: "int", nullable: false),
                    KULLANICIID = table.Column<int>(type: "int", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSTOKHAR", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MPSTOKHAR_MPSTOK_STOKID",
                        column: x => x.STOKID,
                        principalTable: "MPSTOK",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MPSTOKOLCUBR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NUM = table.Column<int>(type: "int", nullable: false),
                    KATSAYI = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KULLANICIID = table.Column<int>(type: "int", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    STOKID = table.Column<int>(type: "int", nullable: false),
                    OLCUBRID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSTOKOLCUBR", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MPSTOKOLCUBR_MPOLCUBR_OLCUBRID",
                        column: x => x.OLCUBRID,
                        principalTable: "MPOLCUBR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MPSTOKOLCUBR_MPSTOK_STOKID",
                        column: x => x.STOKID,
                        principalTable: "MPSTOK",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MPSTOKFIYATLISTHAR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SIRKETID = table.Column<int>(type: "int", nullable: false),
                    SUBEID = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DOVIZID = table.Column<int>(type: "int", nullable: false),
                    KUR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NETFIYAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ISKONTO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KULLANICIID = table.Column<int>(type: "int", nullable: false),
                    AKTIF = table.Column<int>(type: "int", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    STOKID = table.Column<int>(type: "int", nullable: false),
                    FIYATLISTID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSTOKFIYATLISTHAR", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MPSTOKFIYATLISTHAR_MPSTOK_STOKID",
                        column: x => x.STOKID,
                        principalTable: "MPSTOK",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MPSTOKFIYATLISTHAR_MPSTOKFIYATLIST_FIYATLISTID",
                        column: x => x.FIYATLISTID,
                        principalTable: "MPSTOKFIYATLIST",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MPSTOKSAYIMHAR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIRMAID = table.Column<int>(type: "int", nullable: false),
                    SUBEID = table.Column<int>(type: "int", nullable: false),
                    DEPOID = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    STOKSAYIMID = table.Column<int>(type: "int", nullable: false),
                    MIKTAR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FIYAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PARABR = table.Column<int>(type: "int", nullable: false),
                    KUR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    STOKID = table.Column<int>(type: "int", nullable: false),
                    BIRIMID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSTOKSAYIMHAR", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MPSTOKSAYIMHAR_MPOLCUBR_BIRIMID",
                        column: x => x.BIRIMID,
                        principalTable: "MPOLCUBR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MPSTOKSAYIMHAR_MPSTOK_STOKID",
                        column: x => x.STOKID,
                        principalTable: "MPSTOK",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MPSTOKSAYIMHAR_MPSTOKSAYIM_STOKSAYIMID",
                        column: x => x.STOKSAYIMID,
                        principalTable: "MPSTOKSAYIM",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MPDEPOEMIR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SIRA = table.Column<int>(type: "int", nullable: false),
                    DEPOID = table.Column<int>(type: "int", nullable: false),
                    TIP = table.Column<int>(type: "int", nullable: false),
                    SIPARISID = table.Column<int>(type: "int", nullable: false),
                    DURUM = table.Column<int>(type: "int", nullable: false),
                    MIKTAR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPDEPOEMIR", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MPDEPOEMIR_MPDEPO_DEPOID",
                        column: x => x.DEPOID,
                        principalTable: "MPDEPO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MPDEPOEMIR_MPSIPARIS_SIPARISID",
                        column: x => x.SIPARISID,
                        principalTable: "MPSIPARIS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MPIRSALIYE",
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
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    ISKONTOTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BRUTTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GENELTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ARACID = table.Column<int>(type: "int", nullable: false),
                    PERSONELID = table.Column<int>(type: "int", nullable: false),
                    DURUM = table.Column<bool>(type: "bit", nullable: false),
                    DONEM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPIRSALIYE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MPIRSALIYE_MPSIPARIS_SIPARISID",
                        column: x => x.SIPARISID,
                        principalTable: "MPSIPARIS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MPIRSALIYEDETAY",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SIPARISID = table.Column<int>(type: "int", nullable: false),
                    BIRIMID = table.Column<int>(type: "int", nullable: false),
                    DOVIZID = table.Column<int>(type: "int", nullable: false),
                    LISTEFIYATID = table.Column<int>(type: "int", nullable: false),
                    KULLANICIID = table.Column<int>(type: "int", nullable: false),
                    KASAID = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TIP = table.Column<byte>(type: "tinyint", nullable: false),
                    STOKADI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MIKTAR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ISTKONTO1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ISTKONTO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ISTKONTO3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NETFIYAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BRUTFIYAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NETTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BRUTTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BEKLEYENMIKTAR = table.Column<int>(type: "int", nullable: false),
                    HAREKETDURUMU = table.Column<byte>(type: "tinyint", nullable: false),
                    KDV = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KDVTUTARI = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPIRSALIYEDETAY", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MPIRSALIYEDETAY_MPSIPARIS_SIPARISID",
                        column: x => x.SIPARISID,
                        principalTable: "MPSIPARIS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MPSIPARISDETAY",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SIPARISID = table.Column<int>(type: "int", nullable: false),
                    IRSALIYEID = table.Column<int>(type: "int", nullable: false),
                    BIRIMID = table.Column<int>(type: "int", nullable: false),
                    STOKID = table.Column<int>(type: "int", nullable: false),
                    DOVIZID = table.Column<int>(type: "int", nullable: false),
                    LISTEFIYATID = table.Column<int>(type: "int", nullable: false),
                    KULLANICIID = table.Column<int>(type: "int", nullable: false),
                    KASAID = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TIP = table.Column<byte>(type: "tinyint", nullable: false),
                    STOKADI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MIKTAR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ISTKONTO1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ISTKONTO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ISTKONTO3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NETFIYAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BRUTFIYAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NETTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BRUTTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BEKLEYENMIKTAR = table.Column<int>(type: "int", nullable: false),
                    HAREKETDURUMU = table.Column<byte>(type: "tinyint", nullable: false),
                    KDV = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KDVTUTARI = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSIPARISDETAY", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MPSIPARISDETAY_MPIRSALIYE_IRSALIYEID",
                        column: x => x.IRSALIYEID,
                        principalTable: "MPIRSALIYE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MPSIPARISDETAY_MPSIPARIS_SIPARISID",
                        column: x => x.SIPARISID,
                        principalTable: "MPSIPARIS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MPSIPARISDETAY_MPSTOK_STOKID",
                        column: x => x.STOKID,
                        principalTable: "MPSTOK",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MPDEPOEMIRSIPARISKALEMILISKI",
                columns: table => new
                {
                    DEPOEMIRID = table.Column<int>(type: "int", nullable: false),
                    SIPARISDETAYID = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPDEPOEMIRSIPARISKALEMILISKI", x => new { x.DEPOEMIRID, x.SIPARISDETAYID });
                    table.ForeignKey(
                        name: "FK_MPDEPOEMIRSIPARISKALEMILISKI_MPDEPOEMIR_DEPOEMIRID",
                        column: x => x.DEPOEMIRID,
                        principalTable: "MPDEPOEMIR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MPDEPOEMIRSIPARISKALEMILISKI_MPSIPARISDETAY_SIPARISDETAYID",
                        column: x => x.SIPARISDETAYID,
                        principalTable: "MPSIPARISDETAY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MPIRSALIYESIPARISDETAYILISKI",
                columns: table => new
                {
                    SIPARISDETAYID = table.Column<int>(type: "int", nullable: false),
                    IRSALIYEDETAYID = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPIRSALIYESIPARISDETAYILISKI", x => new { x.IRSALIYEDETAYID, x.SIPARISDETAYID });
                    table.ForeignKey(
                        name: "FK_MPIRSALIYESIPARISDETAYILISKI_MPIRSALIYEDETAY_IRSALIYEDETAYID",
                        column: x => x.IRSALIYEDETAYID,
                        principalTable: "MPIRSALIYEDETAY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MPIRSALIYESIPARISDETAYILISKI_MPSIPARISDETAY_SIPARISDETAYID",
                        column: x => x.SIPARISDETAYID,
                        principalTable: "MPSIPARISDETAY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MPSIPARISSEVKEMRIHAR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TIP = table.Column<int>(type: "int", nullable: false),
                    KULLANICIID = table.Column<int>(type: "int", nullable: false),
                    EMIRID = table.Column<int>(type: "int", nullable: false),
                    SIPARISID = table.Column<int>(type: "int", nullable: false),
                    SIPARISKALEMID = table.Column<int>(type: "int", nullable: false),
                    SIPARISMIKTARI = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EMIRMIKTARI = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSIPARISSEVKEMRIHAR", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MPSIPARISSEVKEMRIHAR_MPDEPOEMIR_EMIRID",
                        column: x => x.EMIRID,
                        principalTable: "MPDEPOEMIR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MPSIPARISSEVKEMRIHAR_MPSIPARIS_SIPARISID",
                        column: x => x.SIPARISID,
                        principalTable: "MPSIPARIS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MPSIPARISSEVKEMRIHAR_MPSIPARISDETAY_SIPARISKALEMID",
                        column: x => x.SIPARISKALEMID,
                        principalTable: "MPSIPARISDETAY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MPSTOKMALKABULLIST",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SIRKETID = table.Column<int>(type: "int", nullable: false),
                    SUBEID = table.Column<int>(type: "int", nullable: false),
                    DEPOID = table.Column<int>(type: "int", nullable: false),
                    STOKID = table.Column<int>(type: "int", nullable: false),
                    BIRIMID = table.Column<int>(type: "int", nullable: false),
                    SIPARISDETAYID = table.Column<int>(type: "int", nullable: false),
                    SIPARISMIKTARI = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MIKTAR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EMIRID = table.Column<int>(type: "int", nullable: false),
                    KULLANICIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSTOKMALKABULLIST", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MPSTOKMALKABULLIST_MPDEPOEMIR_EMIRID",
                        column: x => x.EMIRID,
                        principalTable: "MPDEPOEMIR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MPSTOKMALKABULLIST_MPOLCUBR_BIRIMID",
                        column: x => x.BIRIMID,
                        principalTable: "MPOLCUBR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MPSTOKMALKABULLIST_MPSIPARISDETAY_SIPARISDETAYID",
                        column: x => x.SIPARISDETAYID,
                        principalTable: "MPSIPARISDETAY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MPSTOKMALKABULLIST_MPSTOK_STOKID",
                        column: x => x.STOKID,
                        principalTable: "MPSTOK",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MPSTOKSEVKİYATLİST",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SIRKETID = table.Column<int>(type: "int", nullable: false),
                    SUBEID = table.Column<int>(type: "int", nullable: false),
                    DEPOID = table.Column<int>(type: "int", nullable: false),
                    STOKID = table.Column<int>(type: "int", nullable: false),
                    BIRIMID = table.Column<int>(type: "int", nullable: false),
                    SIPARISDETAYID = table.Column<int>(type: "int", nullable: false),
                    SIPARISMIKTARI = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MIKTAR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EMIRID = table.Column<int>(type: "int", nullable: false),
                    KULLANICIID = table.Column<int>(type: "int", nullable: false),
                    SEVKEMRIHARID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSTOKSEVKİYATLİST", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MPSTOKSEVKİYATLİST_MPDEPOEMIR_EMIRID",
                        column: x => x.EMIRID,
                        principalTable: "MPDEPOEMIR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MPSTOKSEVKİYATLİST_MPOLCUBR_BIRIMID",
                        column: x => x.BIRIMID,
                        principalTable: "MPOLCUBR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MPSTOKSEVKİYATLİST_MPSIPARISDETAY_SIPARISDETAYID",
                        column: x => x.SIPARISDETAYID,
                        principalTable: "MPSIPARISDETAY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MPSTOKSEVKİYATLİST_MPSIPARISSEVKEMRIHAR_SEVKEMRIHARID",
                        column: x => x.SEVKEMRIHARID,
                        principalTable: "MPSIPARISSEVKEMRIHAR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MPSTOKSEVKİYATLİST_MPSTOK_STOKID",
                        column: x => x.STOKID,
                        principalTable: "MPSTOK",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MPDEPOEMIR_DEPOID",
                table: "MPDEPOEMIR",
                column: "DEPOID");

            migrationBuilder.CreateIndex(
                name: "IX_MPDEPOEMIR_SIPARISID",
                table: "MPDEPOEMIR",
                column: "SIPARISID");

            migrationBuilder.CreateIndex(
                name: "IX_MPDEPOEMIRSIPARISKALEMILISKI_SIPARISDETAYID",
                table: "MPDEPOEMIRSIPARISKALEMILISKI",
                column: "SIPARISDETAYID");

            migrationBuilder.CreateIndex(
                name: "IX_MPDEPOTRANSFERHAR_DEPOTRANSFERID",
                table: "MPDEPOTRANSFERHAR",
                column: "DEPOTRANSFERID");

            migrationBuilder.CreateIndex(
                name: "IX_MPDEPOTRANSFERHAR_STOKID",
                table: "MPDEPOTRANSFERHAR",
                column: "STOKID");

            migrationBuilder.CreateIndex(
                name: "IX_MPIRSALIYE_SIPARISID",
                table: "MPIRSALIYE",
                column: "SIPARISID");

            migrationBuilder.CreateIndex(
                name: "IX_MPIRSALIYEDETAY_SIPARISID",
                table: "MPIRSALIYEDETAY",
                column: "SIPARISID");

            migrationBuilder.CreateIndex(
                name: "IX_MPIRSALIYESIPARISDETAYILISKI_SIPARISDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI",
                column: "SIPARISDETAYID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSIPARIS_DEPOID",
                table: "MPSIPARIS",
                column: "DEPOID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSIPARISDETAY_IRSALIYEID",
                table: "MPSIPARISDETAY",
                column: "IRSALIYEID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSIPARISDETAY_SIPARISID",
                table: "MPSIPARISDETAY",
                column: "SIPARISID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSIPARISDETAY_STOKID",
                table: "MPSIPARISDETAY",
                column: "STOKID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSIPARISSEVKEMRIHAR_EMIRID",
                table: "MPSIPARISSEVKEMRIHAR",
                column: "EMIRID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSIPARISSEVKEMRIHAR_SIPARISID",
                table: "MPSIPARISSEVKEMRIHAR",
                column: "SIPARISID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSIPARISSEVKEMRIHAR_SIPARISKALEMID",
                table: "MPSIPARISSEVKEMRIHAR",
                column: "SIPARISKALEMID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKFIYATLISTHAR_FIYATLISTID",
                table: "MPSTOKFIYATLISTHAR",
                column: "FIYATLISTID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKFIYATLISTHAR_STOKID",
                table: "MPSTOKFIYATLISTHAR",
                column: "STOKID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKHAR_STOKID",
                table: "MPSTOKHAR",
                column: "STOKID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKMALKABULLIST_BIRIMID",
                table: "MPSTOKMALKABULLIST",
                column: "BIRIMID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKMALKABULLIST_EMIRID",
                table: "MPSTOKMALKABULLIST",
                column: "EMIRID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKMALKABULLIST_SIPARISDETAYID",
                table: "MPSTOKMALKABULLIST",
                column: "SIPARISDETAYID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKMALKABULLIST_STOKID",
                table: "MPSTOKMALKABULLIST",
                column: "STOKID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKOLCUBR_OLCUBRID",
                table: "MPSTOKOLCUBR",
                column: "OLCUBRID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKOLCUBR_STOKID",
                table: "MPSTOKOLCUBR",
                column: "STOKID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKSAYIMHAR_BIRIMID",
                table: "MPSTOKSAYIMHAR",
                column: "BIRIMID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKSAYIMHAR_STOKID",
                table: "MPSTOKSAYIMHAR",
                column: "STOKID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKSAYIMHAR_STOKSAYIMID",
                table: "MPSTOKSAYIMHAR",
                column: "STOKSAYIMID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKSEVKİYATLİST_BIRIMID",
                table: "MPSTOKSEVKİYATLİST",
                column: "BIRIMID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKSEVKİYATLİST_EMIRID",
                table: "MPSTOKSEVKİYATLİST",
                column: "EMIRID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKSEVKİYATLİST_SEVKEMRIHARID",
                table: "MPSTOKSEVKİYATLİST",
                column: "SEVKEMRIHARID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKSEVKİYATLİST_SIPARISDETAYID",
                table: "MPSTOKSEVKİYATLİST",
                column: "SIPARISDETAYID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKSEVKİYATLİST_STOKID",
                table: "MPSTOKSEVKİYATLİST",
                column: "STOKID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPARACLAR");

            migrationBuilder.DropTable(
                name: "MPDEPOEMIRSIPARISKALEMILISKI");

            migrationBuilder.DropTable(
                name: "MPDEPOTRANSFERHAR");

            migrationBuilder.DropTable(
                name: "MPHIZMET");

            migrationBuilder.DropTable(
                name: "MPIRSALIYESIPARISDETAYILISKI");

            migrationBuilder.DropTable(
                name: "MPKATEGORI");

            migrationBuilder.DropTable(
                name: "MPMARKA");

            migrationBuilder.DropTable(
                name: "MPPERSONEL");

            migrationBuilder.DropTable(
                name: "MPSTOKFIYATLISTHAR");

            migrationBuilder.DropTable(
                name: "MPSTOKHAR");

            migrationBuilder.DropTable(
                name: "MPSTOKKASA");

            migrationBuilder.DropTable(
                name: "MPSTOKMALKABULLIST");

            migrationBuilder.DropTable(
                name: "MPSTOKOLCUBR");

            migrationBuilder.DropTable(
                name: "MPSTOKSAYIMHAR");

            migrationBuilder.DropTable(
                name: "MPSTOKSEVKİYATLİST");

            migrationBuilder.DropTable(
                name: "MPDEPOTRANSFER");

            migrationBuilder.DropTable(
                name: "MPIRSALIYEDETAY");

            migrationBuilder.DropTable(
                name: "MPSTOKFIYATLIST");

            migrationBuilder.DropTable(
                name: "MPSTOKSAYIM");

            migrationBuilder.DropTable(
                name: "MPOLCUBR");

            migrationBuilder.DropTable(
                name: "MPSIPARISSEVKEMRIHAR");

            migrationBuilder.DropTable(
                name: "MPDEPOEMIR");

            migrationBuilder.DropTable(
                name: "MPSIPARISDETAY");

            migrationBuilder.DropTable(
                name: "MPIRSALIYE");

            migrationBuilder.DropTable(
                name: "MPSTOK");

            migrationBuilder.DropTable(
                name: "MPSIPARIS");

            migrationBuilder.DropTable(
                name: "MPDEPO");
        }
    }
}
