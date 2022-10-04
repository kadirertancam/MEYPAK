using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKServerGuncelleme : Migration
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
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    SERVISTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MUAYENETAR = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    RAPORKODU9 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPHIZMET", x => x.ID);
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
                    KAYITTIPI = table.Column<int>(type: "int", nullable: false)
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
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BIRIM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KAYITTIPI = table.Column<int>(type: "int", nullable: false),
                    KULLANICIID = table.Column<int>(type: "int", nullable: false)
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
                    ASKERLIK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KAYITTIPI = table.Column<int>(type: "int", nullable: false),
                    DURUM = table.Column<int>(type: "int", nullable: false),
                    PSD = table.Column<int>(type: "int", nullable: false)
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
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false)
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
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    STOKID = table.Column<int>(type: "int", nullable: false),
                    NUM = table.Column<int>(type: "int", nullable: false),
                    NETFIYAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ISKONTO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KULLANICIID = table.Column<int>(type: "int", nullable: false),
                    KAYITTIPI = table.Column<int>(type: "int", nullable: false),
                    AKTIF = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSTOKFIYATLIST", x => x.ID);
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
                    ACIKLAMA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KAYITTIPI = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSTOKSAYIM", x => x.ID);
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
                    STOKID = table.Column<int>(type: "int", nullable: false),
                    BIRIMID = table.Column<int>(type: "int", nullable: false),
                    MIKTAR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FIYAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PARABR = table.Column<int>(type: "int", nullable: false),
                    KUR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KAYITTIPI = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSTOKSAYIMHAR", x => x.ID);
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

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKHAR_STOKID",
                table: "MPSTOKHAR",
                column: "STOKID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKOLCUBR_OLCUBRID",
                table: "MPSTOKOLCUBR",
                column: "OLCUBRID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKOLCUBR_STOKID",
                table: "MPSTOKOLCUBR",
                column: "STOKID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPARACLAR");

            migrationBuilder.DropTable(
                name: "MPDEPO");

            migrationBuilder.DropTable(
                name: "MPHIZMET");

            migrationBuilder.DropTable(
                name: "MPMARKA");

            migrationBuilder.DropTable(
                name: "MPPERSONEL");

            migrationBuilder.DropTable(
                name: "MPSTOKFIYATLIST");

            migrationBuilder.DropTable(
                name: "MPSTOKHAR");

            migrationBuilder.DropTable(
                name: "MPSTOKOLCUBR");

            migrationBuilder.DropTable(
                name: "MPSTOKSAYIM");

            migrationBuilder.DropTable(
                name: "MPSTOKSAYIMHAR");

            migrationBuilder.DropTable(
                name: "MPOLCUBR");

            migrationBuilder.DropTable(
                name: "MPSTOK");
        }
    }
}
