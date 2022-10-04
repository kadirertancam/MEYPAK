using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKDepoDuzenlemesi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ADRES",
                table: "MPDEPO");

            migrationBuilder.DropColumn(
                name: "IL",
                table: "MPDEPO");

            migrationBuilder.DropColumn(
                name: "ILCE",
                table: "MPDEPO");

            migrationBuilder.DropColumn(
                name: "ULKE",
                table: "MPDEPO");

            migrationBuilder.AlterColumn<byte>(
                name: "KAYITTIPI",
                table: "MPDEPO",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint")
                .OldAnnotation("Relational:ColumnOrder", 11);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "KAYITTIPI",
                table: "MPDEPO",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint")
                .Annotation("Relational:ColumnOrder", 11);

            migrationBuilder.AddColumn<string>(
                name: "ADRES",
                table: "MPDEPO",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AddColumn<string>(
                name: "IL",
                table: "MPDEPO",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<string>(
                name: "ILCE",
                table: "MPDEPO",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AddColumn<string>(
                name: "ULKE",
                table: "MPDEPO",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 10);
        }
    }
}
