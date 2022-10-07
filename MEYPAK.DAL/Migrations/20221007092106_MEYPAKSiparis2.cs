using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKSiparis2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ISKONTO",
                table: "MPSIPARIS");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ISKONTO",
                table: "MPSIPARIS",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
