using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MPKASAHAR",
                table: "MPKASAHAR");

            migrationBuilder.RenameTable(
                name: "MPKASAHAR",
                newName: "MPSTOKKASAHAR");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MPSTOKKASAHAR",
                table: "MPSTOKKASAHAR",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MPSTOKKASAHAR",
                table: "MPSTOKKASAHAR");

            migrationBuilder.RenameTable(
                name: "MPSTOKKASAHAR",
                newName: "MPKASAHAR");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MPKASAHAR",
                table: "MPKASAHAR",
                column: "ID");
        }
    }
}
