using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKSatinAlmaMalKabulEmriHar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SATINALMAMALKABULEMRIHARID",
                table: "MPSTOKMALKABULLIST",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MPSATINALMAMALKABULEMRIHAR_MPSIPARISDETAY_SIPARISKALEMID",
                        column: x => x.SIPARISKALEMID,
                        principalTable: "MPSIPARISDETAY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKMALKABULLIST_SATINALMAMALKABULEMRIHARID",
                table: "MPSTOKMALKABULLIST",
                column: "SATINALMAMALKABULEMRIHARID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKMALKABULLIST_MPSATINALMAMALKABULEMRIHAR_SATINALMAMALKABULEMRIHARID",
                table: "MPSTOKMALKABULLIST",
                column: "SATINALMAMALKABULEMRIHARID",
                principalTable: "MPSATINALMAMALKABULEMRIHAR",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKMALKABULLIST_MPSATINALMAMALKABULEMRIHAR_SATINALMAMALKABULEMRIHARID",
                table: "MPSTOKMALKABULLIST");

            migrationBuilder.DropTable(
                name: "MPSATINALMAMALKABULEMRIHAR");

            migrationBuilder.DropIndex(
                name: "IX_MPSTOKMALKABULLIST_SATINALMAMALKABULEMRIHARID",
                table: "MPSTOKMALKABULLIST");

            migrationBuilder.DropColumn(
                name: "SATINALMAMALKABULEMRIHARID",
                table: "MPSTOKMALKABULLIST");
        }
    }
}
