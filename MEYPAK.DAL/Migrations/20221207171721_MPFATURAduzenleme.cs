using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MPFATURAduzenleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KASAID",
                table: "MPFATURADETAY");

            migrationBuilder.RenameColumn(
                name: "KDVDAHİL",
                table: "MPFATURA",
                newName: "KDVDAHIL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KDVDAHIL",
                table: "MPFATURA",
                newName: "KDVDAHİL");

            migrationBuilder.AddColumn<int>(
                name: "KASAID",
                table: "MPFATURADETAY",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
