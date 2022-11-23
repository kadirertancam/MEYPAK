using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class KasaHar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BELGE_NO",
                table: "MPKASAHAR",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FATURAID",
                table: "MPKASAHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IO",
                table: "MPKASAHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IRSALIYEID",
                table: "MPKASAHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KASAID",
                table: "MPKASAHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "MIKTAR",
                table: "MPKASAHAR",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "STOKID",
                table: "MPKASAHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BELGE_NO",
                table: "MPKASAHAR");

            migrationBuilder.DropColumn(
                name: "FATURAID",
                table: "MPKASAHAR");

            migrationBuilder.DropColumn(
                name: "IO",
                table: "MPKASAHAR");

            migrationBuilder.DropColumn(
                name: "IRSALIYEID",
                table: "MPKASAHAR");

            migrationBuilder.DropColumn(
                name: "KASAID",
                table: "MPKASAHAR");

            migrationBuilder.DropColumn(
                name: "MIKTAR",
                table: "MPKASAHAR");

            migrationBuilder.DropColumn(
                name: "STOKID",
                table: "MPKASAHAR");
        }
    }
}
