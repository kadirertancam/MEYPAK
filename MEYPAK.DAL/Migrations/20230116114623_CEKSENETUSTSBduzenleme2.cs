using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class CEKSENETUSTSBduzenleme2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ALTHESAPID",
                table: "MPCEKSENETUSTSB",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CARIID",
                table: "MPCEKSENETUSTSB",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ALTHESAPID",
                table: "MPCEKSENETUSTSB");

            migrationBuilder.DropColumn(
                name: "CARIID",
                table: "MPCEKSENETUSTSB");
        }
    }
}
