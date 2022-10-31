using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKCARIKART : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ADRESLIST");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MPMARKA",
                table: "MPMARKA");

            migrationBuilder.RenameTable(
                name: "MPMARKA",
                newName: "MPSTOKMARKA");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MPSTOKMARKA",
                table: "MPSTOKMARKA",
                column: "ID");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPCARIKART");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MPSTOKMARKA",
                table: "MPSTOKMARKA");

            migrationBuilder.RenameTable(
                name: "MPSTOKMARKA",
                newName: "MPMARKA");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MPMARKA",
                table: "MPMARKA",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "ADRESLIST",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mahalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    il = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ilçe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    semt_bucak_belde = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADRESLIST", x => x.ID);
                });
        }
    }
}
