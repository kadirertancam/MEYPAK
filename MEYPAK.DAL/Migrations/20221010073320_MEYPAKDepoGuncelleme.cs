using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKDepoGuncelleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPDEPOHAR");

            migrationBuilder.AddColumn<decimal>(
                name: "BEKLEYENMIKTAR",
                table: "MPSIPARISSEVKEMRIHAR",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DEPOMIKTAR",
                table: "MPSIPARISSEVKEMRIHAR",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_MPDEPOEMIR_SIPARISID",
                table: "MPDEPOEMIR",
                column: "SIPARISID");

            migrationBuilder.AddForeignKey(
                name: "FK_MPDEPOEMIR_MPSIPARIS_SIPARISID",
                table: "MPDEPOEMIR",
                column: "SIPARISID",
                principalTable: "MPSIPARIS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPDEPOEMIR_MPSIPARIS_SIPARISID",
                table: "MPDEPOEMIR");

            migrationBuilder.DropIndex(
                name: "IX_MPDEPOEMIR_SIPARISID",
                table: "MPDEPOEMIR");

            migrationBuilder.DropColumn(
                name: "BEKLEYENMIKTAR",
                table: "MPSIPARISSEVKEMRIHAR");

            migrationBuilder.DropColumn(
                name: "DEPOMIKTAR",
                table: "MPSIPARISSEVKEMRIHAR");

            migrationBuilder.CreateTable(
                name: "MPDEPOHAR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BIRIM = table.Column<int>(type: "int", nullable: false),
                    CDEPOID = table.Column<int>(type: "int", nullable: false),
                    CSUBEID = table.Column<int>(type: "int", nullable: false),
                    EMIRID = table.Column<int>(type: "int", nullable: false),
                    EMIRMIKTAR = table.Column<int>(type: "int", nullable: false),
                    GDEPOID = table.Column<int>(type: "int", nullable: false),
                    GDEPOKODU = table.Column<int>(type: "int", nullable: false),
                    GSUBEID = table.Column<int>(type: "int", nullable: false),
                    GSUBEKODU = table.Column<int>(type: "int", nullable: false),
                    MIKTAR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SIPARISID = table.Column<int>(type: "int", nullable: false),
                    SIPARISKALEMID = table.Column<int>(type: "int", nullable: false),
                    SIPARISMIKTARI = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    STOKHARID = table.Column<int>(type: "int", nullable: false),
                    STOKKODU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TRANSFERHARID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPDEPOHAR", x => x.ID);
                });
        }
    }
}
