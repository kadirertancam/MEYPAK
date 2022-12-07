using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class seriharduzenlendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FATURAID",
                table: "MPSERIHAR");

            migrationBuilder.DropColumn(
                name: "IRSALIYEID",
                table: "MPSERIHAR");

            migrationBuilder.DropColumn(
                name: "SIPARISID",
                table: "MPSERIHAR");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FATURAID",
                table: "MPSERIHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IRSALIYEID",
                table: "MPSERIHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SIPARISID",
                table: "MPSERIHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
