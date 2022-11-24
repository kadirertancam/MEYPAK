using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class Fatura2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NUM",
                table: "MPFATURADETAY",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NUM",
                table: "MPFATURADETAY");
        }
    }
}
