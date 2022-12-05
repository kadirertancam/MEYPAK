using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class FATURADETAYISKTOPLAMeklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ISTKONTO3",
                table: "MPFATURADETAY",
                newName: "ISKTOPLAM");

            migrationBuilder.RenameColumn(
                name: "ISTKONTO2",
                table: "MPFATURADETAY",
                newName: "ISKONTO3");

            migrationBuilder.RenameColumn(
                name: "ISTKONTO1",
                table: "MPFATURADETAY",
                newName: "ISKONTO2");

            migrationBuilder.AddColumn<decimal>(
                name: "ISKONTO1",
                table: "MPFATURADETAY",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ISKONTO1",
                table: "MPFATURADETAY");

            migrationBuilder.RenameColumn(
                name: "ISKTOPLAM",
                table: "MPFATURADETAY",
                newName: "ISTKONTO3");

            migrationBuilder.RenameColumn(
                name: "ISKONTO3",
                table: "MPFATURADETAY",
                newName: "ISTKONTO2");

            migrationBuilder.RenameColumn(
                name: "ISKONTO2",
                table: "MPFATURADETAY",
                newName: "ISTKONTO1");
        }
    }
}
