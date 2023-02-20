using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class dekont3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IO",
                table: "MPDEKONT");

            migrationBuilder.DropColumn(
                name: "ISKONTO1",
                table: "MPDEKONT");

            migrationBuilder.DropColumn(
                name: "ISKONTO2",
                table: "MPDEKONT");

            migrationBuilder.RenameColumn(
                name: "TUTAR",
                table: "MPDEKONT",
                newName: "DEPO");

            migrationBuilder.RenameColumn(
                name: "ISKONTO3",
                table: "MPDEKONT",
                newName: "ALTHESAPID");

            migrationBuilder.AlterColumn<decimal>(
                name: "KDV",
                table: "MPDEKONT",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "BELGENO",
                table: "MPDEKONT",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "ALACAK",
                table: "MPDEKONT",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "BORC",
                table: "MPDEKONT",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "KDVDAHILEDILSIN",
                table: "MPDEKONT",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ALACAK",
                table: "MPDEKONT");

            migrationBuilder.DropColumn(
                name: "BORC",
                table: "MPDEKONT");

            migrationBuilder.DropColumn(
                name: "KDVDAHILEDILSIN",
                table: "MPDEKONT");

            migrationBuilder.RenameColumn(
                name: "DEPO",
                table: "MPDEKONT",
                newName: "TUTAR");

            migrationBuilder.RenameColumn(
                name: "ALTHESAPID",
                table: "MPDEKONT",
                newName: "ISKONTO3");

            migrationBuilder.AlterColumn<int>(
                name: "KDV",
                table: "MPDEKONT",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "BELGENO",
                table: "MPDEKONT",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "IO",
                table: "MPDEKONT",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ISKONTO1",
                table: "MPDEKONT",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ISKONTO2",
                table: "MPDEKONT",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
