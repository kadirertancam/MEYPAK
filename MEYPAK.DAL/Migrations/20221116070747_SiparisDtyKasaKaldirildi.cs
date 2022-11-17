using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class SiparisDtyKasaKaldirildi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KASAID",
                table: "MPSIPARISDETAY");

            migrationBuilder.DropColumn(
                name: "KASAMIKTAR",
                table: "MPSIPARISDETAY");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KASAID",
                table: "MPSIPARISDETAY",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "KASAMIKTAR",
                table: "MPSIPARISDETAY",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
