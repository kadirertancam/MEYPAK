using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class _12112022PersonelKartGuncel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CİLTNO",
                table: "MPPERSONEL");

            migrationBuilder.RenameColumn(
                name: "GOREVKODU",
                table: "MPPERSONEL",
                newName: "MESLEKKODU");

            migrationBuilder.RenameColumn(
                name: "GOREVI",
                table: "MPPERSONEL",
                newName: "CILTNO");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NUFUSCUZDANVERILISTARIH",
                table: "MPPERSONEL",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MESLEKKODU",
                table: "MPPERSONEL",
                newName: "GOREVKODU");

            migrationBuilder.RenameColumn(
                name: "CILTNO",
                table: "MPPERSONEL",
                newName: "GOREVI");

            migrationBuilder.AlterColumn<string>(
                name: "NUFUSCUZDANVERILISTARIH",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "CİLTNO",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
