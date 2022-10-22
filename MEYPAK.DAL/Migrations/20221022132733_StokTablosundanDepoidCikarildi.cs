using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class StokTablosundanDepoidCikarildi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DEPOID",
                table: "MPSTOK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DEPOID",
                table: "MPSTOK",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
