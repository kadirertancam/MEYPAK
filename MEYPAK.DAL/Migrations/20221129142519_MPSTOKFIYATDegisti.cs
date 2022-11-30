using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MPSTOKFIYATDegisti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.AddColumn<string>(
                name: "MUHALIS",
                table: "MPHIZMET",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MUHIADE",
                table: "MPHIZMET",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MUHSATIS",
                table: "MPHIZMET",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "MPSTOKFIYAT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIRMAID = table.Column<int>(type: "int", nullable: false),
                    SUBEID = table.Column<int>(type: "int", nullable: false),
                    CARIID = table.Column<int>(type: "int", nullable: false),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BASLANGICTARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BITISTARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AKTIF = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSTOKFIYAT", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPSTOKFIYATHAR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIRMAID = table.Column<int>(type: "int", nullable: false),
                    SUBEID = table.Column<int>(type: "int", nullable: false),
                    STOKFIYATID = table.Column<int>(type: "int", nullable: false),
                    STOKID = table.Column<int>(type: "int", nullable: false),
                    PARABIRIMID = table.Column<int>(type: "int", nullable: false),
                    KUR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FIYAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BIRIMID = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSTOKFIYATHAR", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPSTOKFIYAT");

            migrationBuilder.DropTable(
                name: "MPSTOKFIYATHAR");

            migrationBuilder.DropColumn(
                name: "MUHALIS",
                table: "MPHIZMET");

            migrationBuilder.DropColumn(
                name: "MUHIADE",
                table: "MPHIZMET");

            migrationBuilder.DropColumn(
                name: "MUHSATIS",
                table: "MPHIZMET");

           

           
        }
    }
}
