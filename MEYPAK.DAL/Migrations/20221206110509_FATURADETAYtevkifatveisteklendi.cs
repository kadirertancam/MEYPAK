using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class FATURADETAYtevkifatveisteklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ISTISNANO",
                table: "MPFATURADETAY",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TEVKIFATNO",
                table: "MPFATURADETAY",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ISTISNANO",
                table: "MPFATURADETAY");

            migrationBuilder.DropColumn(
                name: "TEVKIFATNO",
                table: "MPFATURADETAY");
        }
    }
}
