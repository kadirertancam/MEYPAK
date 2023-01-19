using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class STOKHARSarfEkle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SARFDETAYID",
                table: "MPSTOKHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SARFID",
                table: "MPSTOKHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SARFDETAYID",
                table: "MPSTOKHAR");

            migrationBuilder.DropColumn(
                name: "SARFID",
                table: "MPSTOKHAR");
        }
    }
}
