using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class CariAltHesapAdresEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
