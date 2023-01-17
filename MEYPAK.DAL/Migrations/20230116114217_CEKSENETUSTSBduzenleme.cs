using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class CEKSENETUSTSBduzenleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ADET",
                table: "MPCEKSENETUSTSB");

            migrationBuilder.DropColumn(
                name: "ALTHESAPID",
                table: "MPCEKSENETUSTSB");

            migrationBuilder.DropColumn(
                name: "BANKAHARID",
                table: "MPCEKSENETUSTSB");

            migrationBuilder.DropColumn(
                name: "BANKAHESAPID",
                table: "MPCEKSENETUSTSB");

            migrationBuilder.DropColumn(
                name: "BANKAID",
                table: "MPCEKSENETUSTSB");

            migrationBuilder.DropColumn(
                name: "BELGETIP",
                table: "MPCEKSENETUSTSB");

            migrationBuilder.DropColumn(
                name: "CARIHARID",
                table: "MPCEKSENETUSTSB");

            migrationBuilder.DropColumn(
                name: "CARIID",
                table: "MPCEKSENETUSTSB");

            migrationBuilder.DropColumn(
                name: "FISTIP",
                table: "MPCEKSENETUSTSB");

            migrationBuilder.DropColumn(
                name: "ISLEMTIPI",
                table: "MPCEKSENETUSTSB");

            migrationBuilder.DropColumn(
                name: "KASAHARID",
                table: "MPCEKSENETUSTSB");

            migrationBuilder.DropColumn(
                name: "KASAID",
                table: "MPCEKSENETUSTSB");

            migrationBuilder.DropColumn(
                name: "MUHASEBEID",
                table: "MPCEKSENETUSTSB");

            migrationBuilder.DropColumn(
                name: "PROTESTOBANKAHARID",
                table: "MPCEKSENETUSTSB");

            migrationBuilder.DropColumn(
                name: "PROTESTOCARIID",
                table: "MPCEKSENETUSTSB");

            migrationBuilder.DropColumn(
                name: "PROTESTOCIROCARIHARID",
                table: "MPCEKSENETUSTSB");

            migrationBuilder.DropColumn(
                name: "PROTESTOCIROMASRAFID",
                table: "MPCEKSENETUSTSB");

            migrationBuilder.RenameColumn(
                name: "SUBEID",
                table: "MPCEKSENETUSTSB",
                newName: "BORDROTIP");

            migrationBuilder.RenameColumn(
                name: "BELGENO",
                table: "MPCEKSENETUSTSB",
                newName: "BORDRONO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BORDROTIP",
                table: "MPCEKSENETUSTSB",
                newName: "SUBEID");

            migrationBuilder.RenameColumn(
                name: "BORDRONO",
                table: "MPCEKSENETUSTSB",
                newName: "BELGENO");

            migrationBuilder.AddColumn<int>(
                name: "ADET",
                table: "MPCEKSENETUSTSB",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ALTHESAPID",
                table: "MPCEKSENETUSTSB",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BANKAHARID",
                table: "MPCEKSENETUSTSB",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BANKAHESAPID",
                table: "MPCEKSENETUSTSB",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BANKAID",
                table: "MPCEKSENETUSTSB",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BELGETIP",
                table: "MPCEKSENETUSTSB",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CARIHARID",
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

            migrationBuilder.AddColumn<int>(
                name: "FISTIP",
                table: "MPCEKSENETUSTSB",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ISLEMTIPI",
                table: "MPCEKSENETUSTSB",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KASAHARID",
                table: "MPCEKSENETUSTSB",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KASAID",
                table: "MPCEKSENETUSTSB",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MUHASEBEID",
                table: "MPCEKSENETUSTSB",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PROTESTOBANKAHARID",
                table: "MPCEKSENETUSTSB",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PROTESTOCARIID",
                table: "MPCEKSENETUSTSB",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PROTESTOCIROCARIHARID",
                table: "MPCEKSENETUSTSB",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PROTESTOCIROMASRAFID",
                table: "MPCEKSENETUSTSB",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
