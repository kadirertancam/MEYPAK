using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKIrsaliye : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IRSALIYEID",
                table: "MPSIPARISDETAY",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKSEVKİYATLİST_BIRIMID",
                table: "MPSTOKSEVKİYATLİST",
                column: "BIRIMID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKSEVKİYATLİST_EMIRID",
                table: "MPSTOKSEVKİYATLİST",
                column: "EMIRID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKSEVKİYATLİST_STOKID",
                table: "MPSTOKSEVKİYATLİST",
                column: "STOKID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSIPARISDETAY_IRSALIYEID",
                table: "MPSIPARISDETAY",
                column: "IRSALIYEID");

            migrationBuilder.CreateIndex(
                name: "IX_MPIRSALIYE_SIPARISID",
                table: "MPIRSALIYE",
                column: "SIPARISID");

            migrationBuilder.CreateIndex(
                name: "IX_MPIRSALIYEDETAY_SIPARISID",
                table: "MPIRSALIYEDETAY",
                column: "SIPARISID");
 
            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKSEVKİYATLİST_MPDEPOEMIR_EMIRID",
                table: "MPSTOKSEVKİYATLİST",
                column: "EMIRID",
                principalTable: "MPDEPOEMIR",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKSEVKİYATLİST_MPOLCUBR_BIRIMID",
                table: "MPSTOKSEVKİYATLİST",
                column: "BIRIMID",
                principalTable: "MPOLCUBR",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKSEVKİYATLİST_MPSTOK_STOKID",
                table: "MPSTOKSEVKİYATLİST",
                column: "STOKID",
                principalTable: "MPSTOK",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPSIPARISDETAY_MPIRSALIYE_IRSALIYEID",
                table: "MPSIPARISDETAY");

            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKSEVKİYATLİST_MPDEPOEMIR_EMIRID",
                table: "MPSTOKSEVKİYATLİST");

            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKSEVKİYATLİST_MPOLCUBR_BIRIMID",
                table: "MPSTOKSEVKİYATLİST");

            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKSEVKİYATLİST_MPSTOK_STOKID",
                table: "MPSTOKSEVKİYATLİST");

            migrationBuilder.DropTable(
                name: "MPIRSALIYE");

            migrationBuilder.DropTable(
                name: "MPIRSALIYEDETAY");

            migrationBuilder.DropIndex(
                name: "IX_MPSTOKSEVKİYATLİST_BIRIMID",
                table: "MPSTOKSEVKİYATLİST");

            migrationBuilder.DropIndex(
                name: "IX_MPSTOKSEVKİYATLİST_EMIRID",
                table: "MPSTOKSEVKİYATLİST");

            migrationBuilder.DropIndex(
                name: "IX_MPSTOKSEVKİYATLİST_STOKID",
                table: "MPSTOKSEVKİYATLİST");

            migrationBuilder.DropIndex(
                name: "IX_MPSIPARISDETAY_IRSALIYEID",
                table: "MPSIPARISDETAY");

            migrationBuilder.DropColumn(
                name: "IRSALIYEID",
                table: "MPSIPARISDETAY");
        }
    }
}
