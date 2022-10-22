using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKHataCozumu3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MPARACLAR",
                table: "MPARACLAR");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "MPARACLAR",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MPARACLAR",
                table: "MPARACLAR",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MPARACLAR",
                table: "MPARACLAR");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "MPARACLAR");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MPARACLAR",
                table: "MPARACLAR",
                column: "muId");
        }
    }
}
