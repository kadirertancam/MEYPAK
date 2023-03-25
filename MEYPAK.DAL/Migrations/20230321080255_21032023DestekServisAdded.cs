using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class _21032023DestekServisAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AD",
                table: "MPDESTEKSERVISS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SOYAD",
                table: "MPDESTEKSERVISS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AD",
                table: "MPDESTEKSERVISS");

            migrationBuilder.DropColumn(
                name: "SOYAD",
                table: "MPDESTEKSERVISS");
        }
    }
}
