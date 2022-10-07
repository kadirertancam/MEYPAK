using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKSiparisKdv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DONEM",
                table: "MPSTOKFIYATLIST",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DONEM",
                table: "MPSTOK",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "KDVTUTARI",
                table: "MPSIPARISDETAY",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "DONEM",
                table: "MPSIPARIS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DONEM",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DONEM",
                table: "MPKATEGORI",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DONEM",
                table: "MPHIZMET",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                    DURUM = table.Column<int>(type: "int", nullable: false),
                    DONEM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPDEPOTRANSFER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPDEPOTRANSFERBILGI",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DEPOTRANSFERID = table.Column<int>(type: "int", nullable: false),
                    STOKID = table.Column<int>(type: "int", nullable: false),
                    MIKTAR = table.Column<int>(type: "int", nullable: false),
                    DURUM = table.Column<int>(type: "int", nullable: false),
                    DONEM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPDEPOTRANSFERBILGI", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MPDEPOTRANSFERBILGI_MPDEPOTRANSFER_DEPOTRANSFERID",
                        column: x => x.DEPOTRANSFERID,
                        principalTable: "MPDEPOTRANSFER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MPDEPOTRANSFERBILGI_MPSTOK_STOKID",
                        column: x => x.STOKID,
                        principalTable: "MPSTOK",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MPDEPOTRANSFERBILGI_DEPOTRANSFERID",
                table: "MPDEPOTRANSFERBILGI",
                column: "DEPOTRANSFERID");

            migrationBuilder.CreateIndex(
                name: "IX_MPDEPOTRANSFERBILGI_STOKID",
                table: "MPDEPOTRANSFERBILGI",
                column: "STOKID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPDEPOTRANSFERBILGI");

            migrationBuilder.DropTable(
                name: "MPDEPOTRANSFER");

            migrationBuilder.DropColumn(
                name: "DONEM",
                table: "MPSTOKFIYATLIST");

            migrationBuilder.DropColumn(
                name: "DONEM",
                table: "MPSTOK");

            migrationBuilder.DropColumn(
                name: "KDVTUTARI",
                table: "MPSIPARISDETAY");

            migrationBuilder.DropColumn(
                name: "DONEM",
                table: "MPSIPARIS");

            migrationBuilder.DropColumn(
                name: "DONEM",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "DONEM",
                table: "MPKATEGORI");

            migrationBuilder.DropColumn(
                name: "DONEM",
                table: "MPHIZMET");
        }
    }
}
