using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MPCEKSENETUSTSB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MPCEKSENETUSTSB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BELGETIP = table.Column<int>(type: "int", nullable: false),
                    FISTIP = table.Column<int>(type: "int", nullable: false),
                    TARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BELGENO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CARIID = table.Column<int>(type: "int", nullable: false),
                    ALTHESAPID = table.Column<int>(type: "int", nullable: false),
                    BANKAID = table.Column<int>(type: "int", nullable: false),
                    BANKAHESAPID = table.Column<int>(type: "int", nullable: false),
                    KASAID = table.Column<int>(type: "int", nullable: false),
                    ADET = table.Column<int>(type: "int", nullable: false),
                    TOPLAM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ORTVADE = table.Column<int>(type: "int", nullable: false),
                    ORTVADETARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ACIKLAMA1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ACIKLAMA2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SUBEID = table.Column<int>(type: "int", nullable: false),
                    CARIHARID = table.Column<int>(type: "int", nullable: false),
                    BANKAHARID = table.Column<int>(type: "int", nullable: false),
                    DOVIZID = table.Column<int>(type: "int", nullable: false),
                    KUR = table.Column<int>(type: "int", nullable: false),
                    DOVIZTUTAR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KASAHARID = table.Column<int>(type: "int", nullable: false),
                    PROTESTOCARIID = table.Column<int>(type: "int", nullable: false),
                    PROTESTOBANKAHARID = table.Column<int>(type: "int", nullable: false),
                    PROTESTOCIROCARIHARID = table.Column<int>(type: "int", nullable: false),
                    PROTESTOCIROMASRAFID = table.Column<int>(type: "int", nullable: false),
                    MUHASEBEID = table.Column<int>(type: "int", nullable: false),
                    DONEM = table.Column<int>(type: "int", nullable: false),
                    ISLEMTIPI = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPCEKSENETUSTSB", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPCEKSENETUSTSB");
        }
    }
}
