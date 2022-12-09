using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MPSTOKHARfatdetayideklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FATURADETAYID",
                table: "MPSTOKHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IRSALIYEDETAYID",
                table: "MPSTOKHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IRSALIYEID",
                table: "MPSTOKHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FATURADETAYID",
                table: "MPSTOKHAR");

            migrationBuilder.DropColumn(
                name: "IRSALIYEDETAYID",
                table: "MPSTOKHAR");

            migrationBuilder.DropColumn(
                name: "IRSALIYEID",
                table: "MPSTOKHAR");
        }
    }
}
