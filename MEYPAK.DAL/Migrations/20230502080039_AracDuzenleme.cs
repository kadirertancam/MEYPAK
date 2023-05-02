using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class AracDuzenleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EGZOZBASTAR",
                table: "MPARAC");

            migrationBuilder.DropColumn(
                name: "EGZOZBITTAR",
                table: "MPARAC");

            migrationBuilder.DropColumn(
                name: "KASACENTEADI",
                table: "MPARAC");

            migrationBuilder.DropColumn(
                name: "KASBASTAR",
                table: "MPARAC");

            migrationBuilder.DropColumn(
                name: "KASBITTAR",
                table: "MPARAC");

            migrationBuilder.DropColumn(
                name: "KASPOLICENO",
                table: "MPARAC");

            migrationBuilder.DropColumn(
                name: "MUAYENEBASTAR",
                table: "MPARAC");

            migrationBuilder.DropColumn(
                name: "MUAYENEBITTAR",
                table: "MPARAC");

            migrationBuilder.DropColumn(
                name: "SIGACENTEADI",
                table: "MPARAC");

            migrationBuilder.DropColumn(
                name: "SIGBASTAR",
                table: "MPARAC");

            migrationBuilder.DropColumn(
                name: "SIGBITTAR",
                table: "MPARAC");

            migrationBuilder.DropColumn(
                name: "SIGPOLICENO",
                table: "MPARAC");

            migrationBuilder.AddColumn<string>(
                name: "DOSYATIP",
                table: "MPARACSIGORTARESIM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SIGACENTEADI",
                table: "MPARACSIGORTARESIM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "SIGBASTAR",
                table: "MPARACSIGORTARESIM",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SIGBITTAR",
                table: "MPARACSIGORTARESIM",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SIGPOLICENO",
                table: "MPARACSIGORTARESIM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DOSYATIP",
                table: "MPARACRUHSATRESIM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DOSYATIP",
                table: "MPARACKASKORESIM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "KASACENTEADI",
                table: "MPARACKASKORESIM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "KASBASTAR",
                table: "MPARACKASKORESIM",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "KASBITTAR",
                table: "MPARACKASKORESIM",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "KASPOLICENO",
                table: "MPARACKASKORESIM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "DURUM",
                table: "MPARAC",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "TEKERSAYISI",
                table: "MPARAC",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "YEDEKTEKERSAYISI",
                table: "MPARAC",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.CreateTable(
                name: "MPARACMUAYENERESIM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ARACID = table.Column<int>(type: "int", nullable: false),
                    MUAYENEBASTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MUAYENEBITTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EGZOZBASTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EGZOZBITTAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NUM = table.Column<int>(type: "int", nullable: false),
                    DOSYATIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMG = table.Column<string>(type: "ntext", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false),
                    USERID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPARACMUAYENERESIM", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPARACMUAYENERESIM");

            migrationBuilder.DropColumn(
                name: "DOSYATIP",
                table: "MPARACSIGORTARESIM");

            migrationBuilder.DropColumn(
                name: "SIGACENTEADI",
                table: "MPARACSIGORTARESIM");

            migrationBuilder.DropColumn(
                name: "SIGBASTAR",
                table: "MPARACSIGORTARESIM");

            migrationBuilder.DropColumn(
                name: "SIGBITTAR",
                table: "MPARACSIGORTARESIM");

            migrationBuilder.DropColumn(
                name: "SIGPOLICENO",
                table: "MPARACSIGORTARESIM");

            migrationBuilder.DropColumn(
                name: "DOSYATIP",
                table: "MPARACRUHSATRESIM");

            migrationBuilder.DropColumn(
                name: "DOSYATIP",
                table: "MPARACKASKORESIM");

            migrationBuilder.DropColumn(
                name: "KASACENTEADI",
                table: "MPARACKASKORESIM");

            migrationBuilder.DropColumn(
                name: "KASBASTAR",
                table: "MPARACKASKORESIM");

            migrationBuilder.DropColumn(
                name: "KASBITTAR",
                table: "MPARACKASKORESIM");

            migrationBuilder.DropColumn(
                name: "KASPOLICENO",
                table: "MPARACKASKORESIM");

            migrationBuilder.DropColumn(
                name: "DURUM",
                table: "MPARAC");

            migrationBuilder.DropColumn(
                name: "TEKERSAYISI",
                table: "MPARAC");

            migrationBuilder.DropColumn(
                name: "YEDEKTEKERSAYISI",
                table: "MPARAC");

            migrationBuilder.AddColumn<DateTime>(
                name: "EGZOZBASTAR",
                table: "MPARAC",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EGZOZBITTAR",
                table: "MPARAC",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "KASACENTEADI",
                table: "MPARAC",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "KASBASTAR",
                table: "MPARAC",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "KASBITTAR",
                table: "MPARAC",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "KASPOLICENO",
                table: "MPARAC",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "MUAYENEBASTAR",
                table: "MPARAC",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "MUAYENEBITTAR",
                table: "MPARAC",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SIGACENTEADI",
                table: "MPARAC",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "SIGBASTAR",
                table: "MPARAC",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SIGBITTAR",
                table: "MPARAC",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SIGPOLICENO",
                table: "MPARAC",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
