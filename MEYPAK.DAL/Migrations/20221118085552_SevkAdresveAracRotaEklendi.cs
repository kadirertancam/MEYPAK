using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class SevkAdresveAracRotaEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ADRES",
                table: "MPCARIALTHES");

            migrationBuilder.DropColumn(
                name: "IL",
                table: "MPCARIALTHES");

            migrationBuilder.DropColumn(
                name: "ILCE",
                table: "MPCARIALTHES");

            migrationBuilder.AddColumn<int>(
                name: "TIP",
                table: "MPIRSALIYE",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MPARACROTA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ARACID = table.Column<int>(type: "int", nullable: false),
                    TARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HAREKETSAATI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CIKISID = table.Column<int>(type: "int", nullable: false),
                    HEDEFID = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPARACROTA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPSEVKADRES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ALTHESAPID = table.Column<int>(type: "int", nullable: false),
                    KODU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ILCE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MAHALLE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SOKAK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    APARTMAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DAIRE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSEVKADRES", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPARACROTA");

            migrationBuilder.DropTable(
                name: "MPSEVKADRES");

            migrationBuilder.DropColumn(
                name: "TIP",
                table: "MPIRSALIYE");

            migrationBuilder.AddColumn<string>(
                name: "ADRES",
                table: "MPCARIALTHES",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IL",
                table: "MPCARIALTHES",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ILCE",
                table: "MPCARIALTHES",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
