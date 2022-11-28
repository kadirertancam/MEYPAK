using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class KUNYEEKLENDI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KUNYE",
                table: "MPSTOKHAR",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "KUNYE",
                table: "MPIRSALIYEDETAY",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KUNYE",
                table: "MPSTOKHAR");

            migrationBuilder.DropColumn(
                name: "KUNYE",
                table: "MPIRSALIYEDETAY");
        }
    }
}
