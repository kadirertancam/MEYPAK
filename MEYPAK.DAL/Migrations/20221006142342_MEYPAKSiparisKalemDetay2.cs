using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKSiparisKalemDetay2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VW_SIPARISKALEM");

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
                    MIKTAR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    KDV = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_MPSIPARISDETAY_MPSTOK_STOKID",
                        column: x => x.STOKID,
                        principalTable: "MPSTOK",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MPSIPARISDETAY_SIPARISID",
                table: "MPSIPARISDETAY",
                column: "SIPARISID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSIPARISDETAY_STOKID",
                table: "MPSIPARISDETAY",
                column: "STOKID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPSIPARISDETAY");

            migrationBuilder.CreateTable(
                name: "VW_SIPARISKALEM",
                columns: table => new
                {
                    StokId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Acıklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrütToplam = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Doviz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kdv = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Miktar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetToplam = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StokAdı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StokKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İskonto1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    İskonto2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    İskonto3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VW_SIPARISKALEM", x => x.StokId);
                });
        }
    }
}
