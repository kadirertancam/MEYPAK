using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class FaturalaraDaraSafiEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DARA",
                table: "MPSIPARISDETAY",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DARALI",
                table: "MPSIPARISDETAY",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

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

            migrationBuilder.AddColumn<decimal>(
                name: "SAFI",
                table: "MPSIPARISDETAY",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DARA",
                table: "MPSIPARISDETAY");

            migrationBuilder.DropColumn(
                name: "DARALI",
                table: "MPSIPARISDETAY");

            migrationBuilder.DropColumn(
                name: "KASAID",
                table: "MPSIPARISDETAY");

            migrationBuilder.DropColumn(
                name: "KASAMIKTAR",
                table: "MPSIPARISDETAY");

            migrationBuilder.DropColumn(
                name: "SAFI",
                table: "MPSIPARISDETAY");
        }
    }
}
