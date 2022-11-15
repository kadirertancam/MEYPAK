using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MPARACveResimlerEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MPARAC",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PLAKA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MARKA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MODEL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YAKITTURU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SOFORID = table.Column<int>(type: "int", nullable: false),
                    SOFOR2ID = table.Column<int>(type: "int", nullable: false),
                    SIGACENTEADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIGPOLICENO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIGBASTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SIGBITTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KASACENTEADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KASPOLICENO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KASBASTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KASBITTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MUAYENEBASTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MUAYENEBITTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EGZOZBASTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EGZOZBITTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPARAC", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPARACKASKORESIM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ARACID = table.Column<int>(type: "int", nullable: false),
                    NUM = table.Column<int>(type: "int", nullable: false),
                    IMG = table.Column<string>(type: "ntext", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPARACKASKORESIM", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPARACRESIM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ARACID = table.Column<int>(type: "int", nullable: false),
                    NUM = table.Column<int>(type: "int", nullable: false),
                    IMG = table.Column<string>(type: "ntext", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPARACRESIM", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPARACRUHSATRESIM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ARACID = table.Column<int>(type: "int", nullable: false),
                    NUM = table.Column<int>(type: "int", nullable: false),
                    IMG = table.Column<string>(type: "ntext", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPARACRUHSATRESIM", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPARACSIGORTARESIM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ARACID = table.Column<int>(type: "int", nullable: false),
                    NUM = table.Column<int>(type: "int", nullable: false),
                    IMG = table.Column<string>(type: "ntext", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPARACSIGORTARESIM", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPARAC");

            migrationBuilder.DropTable(
                name: "MPARACKASKORESIM");

            migrationBuilder.DropTable(
                name: "MPARACRESIM");

            migrationBuilder.DropTable(
                name: "MPARACRUHSATRESIM");

            migrationBuilder.DropTable(
                name: "MPARACSIGORTARESIM");
        }
    }
}
