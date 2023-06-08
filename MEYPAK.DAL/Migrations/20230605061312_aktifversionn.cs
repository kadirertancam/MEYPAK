using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class aktifversionn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TUTAR",
                table: "MPMUSTERISENETSB",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CARIADI",
                table: "MPFATURA",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "EK",
                table: "MPFATURA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "APTNO",
                table: "MPEFATURAPARAM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DAIRENO",
                table: "MPEFATURAPARAM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IL",
                table: "MPEFATURAPARAM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ILCE",
                table: "MPEFATURAPARAM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MERSISNO",
                table: "MPEFATURAPARAM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SOKAK",
                table: "MPEFATURAPARAM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TICSICILNO",
                table: "MPEFATURAPARAM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ULKE",
                table: "MPEFATURAPARAM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UNVAN",
                table: "MPEFATURAPARAM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VD",
                table: "MPEFATURAPARAM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VNO",
                table: "MPEFATURAPARAM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EK",
                table: "MPFATURA");

            migrationBuilder.DropColumn(
                name: "APTNO",
                table: "MPEFATURAPARAM");

            migrationBuilder.DropColumn(
                name: "DAIRENO",
                table: "MPEFATURAPARAM");

            migrationBuilder.DropColumn(
                name: "IL",
                table: "MPEFATURAPARAM");

            migrationBuilder.DropColumn(
                name: "ILCE",
                table: "MPEFATURAPARAM");

            migrationBuilder.DropColumn(
                name: "MERSISNO",
                table: "MPEFATURAPARAM");

            migrationBuilder.DropColumn(
                name: "SOKAK",
                table: "MPEFATURAPARAM");

            migrationBuilder.DropColumn(
                name: "TICSICILNO",
                table: "MPEFATURAPARAM");

            migrationBuilder.DropColumn(
                name: "ULKE",
                table: "MPEFATURAPARAM");

            migrationBuilder.DropColumn(
                name: "UNVAN",
                table: "MPEFATURAPARAM");

            migrationBuilder.DropColumn(
                name: "VD",
                table: "MPEFATURAPARAM");

            migrationBuilder.DropColumn(
                name: "VNO",
                table: "MPEFATURAPARAM");

            migrationBuilder.AlterColumn<int>(
                name: "TUTAR",
                table: "MPMUSTERISENETSB",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "CARIADI",
                table: "MPFATURA",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);
        }
    }
}
