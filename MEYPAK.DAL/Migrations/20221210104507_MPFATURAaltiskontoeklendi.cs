using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MPFATURAaltiskontoeklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ALTISKONTO1",
                table: "MPFATURA",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ALTISKONTO2",
                table: "MPFATURA",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ALTISKONTO3",
                table: "MPFATURA",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ALTISKONTO1",
                table: "MPFATURA");

            migrationBuilder.DropColumn(
                name: "ALTISKONTO2",
                table: "MPFATURA");

            migrationBuilder.DropColumn(
                name: "ALTISKONTO3",
                table: "MPFATURA");
        }
    }
}
