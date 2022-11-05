using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class Identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SOYAD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MPARACLAR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    muId = table.Column<int>(type: "int", nullable: false),
                    companyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fleetId = table.Column<int>(type: "int", nullable: false),
                    fleetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    groupId = table.Column<int>(type: "int", nullable: false),
                    groupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    plate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    timezone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deviceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    canbusProfile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    networkId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hardwareVersion = table.Column<int>(type: "int", nullable: false),
                    softwareVersion = table.Column<int>(type: "int", nullable: false),
                    softwareSubVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPARACLAR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPCARIHAR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CARIID = table.Column<int>(type: "int", nullable: false),
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
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPCARIHAR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPCARIKART",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KOD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SOYADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UNVAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VERGIDAIRESI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VERGINO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TCNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TIPI = table.Column<int>(type: "int", nullable: false),
                    ADRES = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ILCE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MAHALLE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SOKAK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    APT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DAIRE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    POSTAKOD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VADEGUNU = table.Column<int>(type: "int", nullable: false),
                    FIYATNUM = table.Column<int>(type: "int", nullable: false),
                    MUH_KOD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TELEFON = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TELEFON2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CEPTEL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FAX = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WEB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EPOSTA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GRUPKODU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KATEGORI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AMUHKOD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SMUHKOD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ACIKLAMA1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ACIKLAMA2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ACIKLAMA3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ACIKLAMA4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ACIKLAMA5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ACIKLAMA6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ACIKLAMA7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ACIKLAMA8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ACIKLAMA9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SACIKLAMA1 = table.Column<int>(type: "int", nullable: false),
                    SACIKLAMA2 = table.Column<int>(type: "int", nullable: false),
                    SACIKLAMA3 = table.Column<int>(type: "int", nullable: false),
                    SACIKLAMA4 = table.Column<int>(type: "int", nullable: false),
                    SACIKLAMA5 = table.Column<int>(type: "int", nullable: false),
                    SACIKLAMA6 = table.Column<int>(type: "int", nullable: false),
                    SACIKLAMA7 = table.Column<int>(type: "int", nullable: false),
                    SACIKLAMA8 = table.Column<int>(type: "int", nullable: false),
                    SACIKLAMA9 = table.Column<int>(type: "int", nullable: false),
                    RAPORKOD1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAPORKOD2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAPORKOD3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAPORKOD4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAPORKOD5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAPORKOD6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAPORKOD7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAPORKOD8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAPORKOD9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPCARIKART", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPDEPO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SIRKETID = table.Column<int>(type: "int", nullable: false),
                    DEPOKODU = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DEPOADI = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPDEPO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPDEPOCEKILIST",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISEMRIID = table.Column<int>(type: "int", nullable: false),
                    STOKID = table.Column<int>(type: "int", nullable: false),
                    BIRIMID = table.Column<int>(type: "int", nullable: false),
                    MIKTAR = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPDEPOCEKILIST", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPDEPOTRANSFER",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CIKTIDEPOID = table.Column<int>(type: "int", nullable: false),
                    HEDEFDEPOID = table.Column<int>(type: "int", nullable: false),
                    DURUM = table.Column<byte>(type: "tinyint", nullable: false),
                    DONEM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
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
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPHIZMET", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPOLCUBR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADI = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BIRIM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KULLANICIID = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPOLCUBR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPPARABIRIM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KISAADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AKTIF = table.Column<byte>(type: "tinyint", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPPARABIRIM", x => x.ID);
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
                    DONEM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
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
                    KASAID = table.Column<int>(type: "int", nullable: false),
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
                    DONEM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
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
                    FIYATLISTADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BASTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BITTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KULLANICIID = table.Column<int>(type: "int", nullable: false),
                    DONEM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
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
                    KASAKODU = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KASAADI = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AKTIF = table.Column<byte>(type: "tinyint", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSTOKKASA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPSTOKKATEGORI",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UstId = table.Column<int>(type: "int", nullable: false),
                    AltID = table.Column<int>(type: "int", nullable: false),
                    Acıklama = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DONEM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSTOKKATEGORI", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPSTOKMARKA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADI = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSTOKMARKA", x => x.ID);
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
                    SAYIMTARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DURUM = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSTOKSAYIM", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
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
                    DEPOTRANSFERID = table.Column<int>(type: "int", nullable: false),
                    STOKID = table.Column<int>(type: "int", nullable: false),
                    MIKTAR = table.Column<int>(type: "int", nullable: false),
                    DURUM = table.Column<byte>(type: "tinyint", nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DONEM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
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
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
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
                    NUM = table.Column<int>(type: "int", nullable: false),
                    KATSAYI = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KULLANICIID = table.Column<int>(type: "int", nullable: false),
                    STOKID = table.Column<int>(type: "int", nullable: false),
                    OLCUBRID = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
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
                    DOVIZID = table.Column<int>(type: "int", nullable: false),
                    KUR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NETFIYAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ISKONTO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KULLANICIID = table.Column<int>(type: "int", nullable: false),
                    AKTIF = table.Column<int>(type: "int", nullable: false),
                    STOKID = table.Column<int>(type: "int", nullable: false),
                    FIYATLISTID = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
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
                    STOKSAYIMID = table.Column<int>(type: "int", nullable: false),
                    MIKTAR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FIYAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PARABR = table.Column<int>(type: "int", nullable: false),
                    KUR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    STOKID = table.Column<int>(type: "int", nullable: false),
                    BIRIMID = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
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
                    ACIKLAMA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPDEPOEMIR", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MPDEPOEMIR_MPDEPO_DEPOID",
                        column: x => x.DEPOID,
                        principalTable: "MPDEPO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPIRSALIYE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MPIRSALIYE_MPSIPARIS_SIPARISID",
                        column: x => x.SIPARISID,
                        principalTable: "MPSIPARIS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
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
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSIPARISDETAY", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MPSIPARISDETAY_MPIRSALIYE_IRSALIYEID",
                        column: x => x.IRSALIYEID,
                        principalTable: "MPIRSALIYE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MPSIPARISDETAY_MPSIPARIS_SIPARISID",
                        column: x => x.SIPARISID,
                        principalTable: "MPSIPARIS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DEPOEMIRID = table.Column<int>(type: "int", nullable: false),
                    MPDEPOEMIRID = table.Column<int>(type: "int", nullable: false),
                    SIPARISDETAYID = table.Column<int>(type: "int", nullable: false),
                    MPSIPARISDETAYID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPDEPOEMIRSIPARISKALEMILISKI", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MPDEPOEMIRSIPARISKALEMILISKI_MPDEPOEMIR_MPDEPOEMIRID",
                        column: x => x.MPDEPOEMIRID,
                        principalTable: "MPDEPOEMIR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MPDEPOEMIRSIPARISKALEMILISKI_MPSIPARISDETAY_MPSIPARISDETAYID",
                        column: x => x.MPSIPARISDETAYID,
                        principalTable: "MPSIPARISDETAY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MPIRSALIYESIPARISDETAYILISKI",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SIPARISDETAYID = table.Column<int>(type: "int", nullable: false),
                    MPSIPARISDETAYID = table.Column<int>(type: "int", nullable: false),
                    IRSALIYEDETAYID = table.Column<int>(type: "int", nullable: false),
                    MPIRSALIYEDETAYID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPIRSALIYESIPARISDETAYILISKI", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MPIRSALIYESIPARISDETAYILISKI_MPIRSALIYEDETAY_MPIRSALIYEDETAYID",
                        column: x => x.MPIRSALIYEDETAYID,
                        principalTable: "MPIRSALIYEDETAY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MPIRSALIYESIPARISDETAYILISKI_MPSIPARISDETAY_MPSIPARISDETAYID",
                        column: x => x.MPSIPARISDETAYID,
                        principalTable: "MPSIPARISDETAY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MPSATINALMAMALKABULEMRIHAR",
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
                    EMIRMIKTARI = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSATINALMAMALKABULEMRIHAR", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MPSATINALMAMALKABULEMRIHAR_MPDEPOEMIR_EMIRID",
                        column: x => x.EMIRID,
                        principalTable: "MPDEPOEMIR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MPSATINALMAMALKABULEMRIHAR_MPSIPARIS_SIPARISID",
                        column: x => x.SIPARISID,
                        principalTable: "MPSIPARIS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MPSATINALMAMALKABULEMRIHAR_MPSIPARISDETAY_SIPARISKALEMID",
                        column: x => x.SIPARISKALEMID,
                        principalTable: "MPSIPARISDETAY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    EMIRMIKTARI = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSIPARISSEVKEMRIHAR", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MPSIPARISSEVKEMRIHAR_MPDEPOEMIR_EMIRID",
                        column: x => x.EMIRID,
                        principalTable: "MPDEPOEMIR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MPSIPARISSEVKEMRIHAR_MPSIPARIS_SIPARISID",
                        column: x => x.SIPARISID,
                        principalTable: "MPSIPARIS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MPSIPARISSEVKEMRIHAR_MPSIPARISDETAY_SIPARISKALEMID",
                        column: x => x.SIPARISKALEMID,
                        principalTable: "MPSIPARISDETAY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    SATINALMAMALKABULEMRIHARID = table.Column<int>(type: "int", nullable: false),
                    SIPARISMIKTARI = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MIKTAR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EMIRID = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSTOKMALKABULLIST", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MPSTOKMALKABULLIST_MPDEPOEMIR_EMIRID",
                        column: x => x.EMIRID,
                        principalTable: "MPDEPOEMIR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MPSTOKMALKABULLIST_MPOLCUBR_BIRIMID",
                        column: x => x.BIRIMID,
                        principalTable: "MPOLCUBR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MPSTOKMALKABULLIST_MPSATINALMAMALKABULEMRIHAR_SATINALMAMALKABULEMRIHARID",
                        column: x => x.SATINALMAMALKABULEMRIHARID,
                        principalTable: "MPSATINALMAMALKABULEMRIHAR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MPSTOKMALKABULLIST_MPSIPARISDETAY_SIPARISDETAYID",
                        column: x => x.SIPARISDETAYID,
                        principalTable: "MPSIPARISDETAY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MPSTOKMALKABULLIST_MPSTOK_STOKID",
                        column: x => x.STOKID,
                        principalTable: "MPSTOK",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    SEVKEMRIHARID = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MPSTOKSEVKİYATLİST_MPSIPARISSEVKEMRIHAR_SEVKEMRIHARID",
                        column: x => x.SEVKEMRIHARID,
                        principalTable: "MPSIPARISSEVKEMRIHAR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MPSTOKSEVKİYATLİST_MPSTOK_STOKID",
                        column: x => x.STOKID,
                        principalTable: "MPSTOK",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MPDEPOEMIR_DEPOID",
                table: "MPDEPOEMIR",
                column: "DEPOID");

            migrationBuilder.CreateIndex(
                name: "IX_MPDEPOEMIR_SIPARISID",
                table: "MPDEPOEMIR",
                column: "SIPARISID");

            migrationBuilder.CreateIndex(
                name: "IX_MPDEPOEMIRSIPARISKALEMILISKI_MPDEPOEMIRID",
                table: "MPDEPOEMIRSIPARISKALEMILISKI",
                column: "MPDEPOEMIRID");

            migrationBuilder.CreateIndex(
                name: "IX_MPDEPOEMIRSIPARISKALEMILISKI_MPSIPARISDETAYID",
                table: "MPDEPOEMIRSIPARISKALEMILISKI",
                column: "MPSIPARISDETAYID");

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
                name: "IX_MPIRSALIYESIPARISDETAYILISKI_MPIRSALIYEDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI",
                column: "MPIRSALIYEDETAYID");

            migrationBuilder.CreateIndex(
                name: "IX_MPIRSALIYESIPARISDETAYILISKI_MPSIPARISDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI",
                column: "MPSIPARISDETAYID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSATINALMAMALKABULEMRIHAR_EMIRID",
                table: "MPSATINALMAMALKABULEMRIHAR",
                column: "EMIRID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSATINALMAMALKABULEMRIHAR_SIPARISID",
                table: "MPSATINALMAMALKABULEMRIHAR",
                column: "SIPARISID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSATINALMAMALKABULEMRIHAR_SIPARISKALEMID",
                table: "MPSATINALMAMALKABULEMRIHAR",
                column: "SIPARISKALEMID");

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
                name: "IX_MPSTOKMALKABULLIST_SATINALMAMALKABULEMRIHARID",
                table: "MPSTOKMALKABULLIST",
                column: "SATINALMAMALKABULEMRIHARID");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "MPARACLAR");

            migrationBuilder.DropTable(
                name: "MPCARIHAR");

            migrationBuilder.DropTable(
                name: "MPCARIKART");

            migrationBuilder.DropTable(
                name: "MPDEPOCEKILIST");

            migrationBuilder.DropTable(
                name: "MPDEPOEMIRSIPARISKALEMILISKI");

            migrationBuilder.DropTable(
                name: "MPDEPOTRANSFERHAR");

            migrationBuilder.DropTable(
                name: "MPHIZMET");

            migrationBuilder.DropTable(
                name: "MPIRSALIYESIPARISDETAYILISKI");

            migrationBuilder.DropTable(
                name: "MPPARABIRIM");

            migrationBuilder.DropTable(
                name: "MPPERSONEL");

            migrationBuilder.DropTable(
                name: "MPSTOKFIYATLISTHAR");

            migrationBuilder.DropTable(
                name: "MPSTOKHAR");

            migrationBuilder.DropTable(
                name: "MPSTOKKASA");

            migrationBuilder.DropTable(
                name: "MPSTOKKATEGORI");

            migrationBuilder.DropTable(
                name: "MPSTOKMALKABULLIST");

            migrationBuilder.DropTable(
                name: "MPSTOKMARKA");

            migrationBuilder.DropTable(
                name: "MPSTOKOLCUBR");

            migrationBuilder.DropTable(
                name: "MPSTOKSAYIMHAR");

            migrationBuilder.DropTable(
                name: "MPSTOKSEVKİYATLİST");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "MPDEPOTRANSFER");

            migrationBuilder.DropTable(
                name: "MPIRSALIYEDETAY");

            migrationBuilder.DropTable(
                name: "MPSTOKFIYATLIST");

            migrationBuilder.DropTable(
                name: "MPSATINALMAMALKABULEMRIHAR");

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
