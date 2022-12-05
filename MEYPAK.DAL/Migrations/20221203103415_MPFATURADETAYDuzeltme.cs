using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MPFATURADETAYDuzeltme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MIKTAR",
                table: "MPFATURADETAY",
                newName: "KASAMIKTAR");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KASAMIKTAR",
                table: "MPFATURADETAY",
                newName: "MIKTAR");
        }
    }
}
