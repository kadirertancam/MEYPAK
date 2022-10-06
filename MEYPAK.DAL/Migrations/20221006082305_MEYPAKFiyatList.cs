using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKFiyatList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AKTIF",
                table: "MPSTOKFIYATLIST");

            migrationBuilder.DropColumn(
                name: "ISKONTO",
                table: "MPSTOKFIYATLIST");

            migrationBuilder.DropColumn(
                name: "NETFIYAT",
                table: "MPSTOKFIYATLIST");

            migrationBuilder.RenameColumn(
                name: "STOKID",
                table: "MPSTOKFIYATLIST",
                newName: "SUBEID");

            migrationBuilder.RenameColumn(
                name: "NUM",
                table: "MPSTOKFIYATLIST",
                newName: "SIRKETID");

            migrationBuilder.AddColumn<DateTime>(
                name: "BASTAR",
                table: "MPSTOKFIYATLIST",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "BITTAR",
                table: "MPSTOKFIYATLIST",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FIYATLISTADI",
                table: "MPSTOKFIYATLIST",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                    TIP = table.Column<byte>(type: "tinyint", nullable: false),
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
                    ISKONTO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NETTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KDVTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ISKONTOTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BRUTTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GENELTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DURUM = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSIPARIS", x => x.ID);
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
                    STOKID = table.Column<int>(type: "int", nullable: false),
                    FIYATLISTID = table.Column<int>(type: "int", nullable: false),
                    NETFIYAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ISKONTO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KULLANICIID = table.Column<int>(type: "int", nullable: false),
                    KAYITTIPI = table.Column<int>(type: "int", nullable: false),
                    AKTIF = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSTOKFIYATLISTHAR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPSIPARISDETAY",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SIPARISID = table.Column<int>(type: "int", nullable: false),
                    BIRIMID = table.Column<int>(type: "int", nullable: false),
                    STOKID = table.Column<int>(type: "int", nullable: false),
                    DOVIZID = table.Column<int>(type: "int", nullable: false),
                    LISTEFIYATID = table.Column<int>(type: "int", nullable: false),
                    KULLANICIID = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TIP = table.Column<byte>(type: "tinyint", nullable: false),
                    STOKADI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MIKTAR = table.Column<int>(type: "int", nullable: false),
                    ISTKONTO1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ISTKONTO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ISTKONTO3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NETFIYAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BRUTFIYAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NETTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BRUTTOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BEKLEYENMIKTAR = table.Column<int>(type: "int", nullable: false),
                    HARIKETDURUMU = table.Column<byte>(type: "tinyint", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    KDV = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSIPARISDETAY", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MPSIPARISDETAY_MPSIPARIS_SIPARISID",
                        column: x => x.SIPARISID,
                        principalTable: "MPSIPARIS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MPSIPARISDETAY_SIPARISID",
                table: "MPSIPARISDETAY",
                column: "SIPARISID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPSIPARISDETAY");

            migrationBuilder.DropTable(
                name: "MPSTOKFIYATLISTHAR");

            migrationBuilder.DropTable(
                name: "MPSIPARIS");

            migrationBuilder.DropColumn(
                name: "BASTAR",
                table: "MPSTOKFIYATLIST");

            migrationBuilder.DropColumn(
                name: "BITTAR",
                table: "MPSTOKFIYATLIST");

            migrationBuilder.DropColumn(
                name: "FIYATLISTADI",
                table: "MPSTOKFIYATLIST");

            migrationBuilder.RenameColumn(
                name: "SUBEID",
                table: "MPSTOKFIYATLIST",
                newName: "STOKID");

            migrationBuilder.RenameColumn(
                name: "SIRKETID",
                table: "MPSTOKFIYATLIST",
                newName: "NUM");

            migrationBuilder.AddColumn<int>(
                name: "AKTIF",
                table: "MPSTOKFIYATLIST",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "ISKONTO",
                table: "MPSTOKFIYATLIST",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "NETFIYAT",
                table: "MPSTOKFIYATLIST",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
