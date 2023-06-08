using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class sevkadresiduzenlendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ILCEID",
                table: "MPSEVKADRES",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ILID",
                table: "MPSEVKADRES",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MAHALLEID",
                table: "MPSEVKADRES",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ILCEID",
                table: "MPSEVKADRES");

            migrationBuilder.DropColumn(
                name: "ILID",
                table: "MPSEVKADRES");

            migrationBuilder.DropColumn(
                name: "MAHALLEID",
                table: "MPSEVKADRES");
        }
    }
}
