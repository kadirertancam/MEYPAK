using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class FATURADETAYSafiEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DARA",
                table: "MPFATURADETAY",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DARALI",
                table: "MPFATURADETAY",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SAFI",
                table: "MPFATURADETAY",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DARA",
                table: "MPFATURADETAY");

            migrationBuilder.DropColumn(
                name: "DARALI",
                table: "MPFATURADETAY");

            migrationBuilder.DropColumn(
                name: "SAFI",
                table: "MPFATURADETAY");
        }
    }
}
