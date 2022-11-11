using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MPPERSONELZIMMETeklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ASKERLIKBITISTAR",
                table: "MPPERSONEL",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ASKERLIKBASLANGICTAR",
                table: "MPPERSONEL",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "SGK",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "MPPERSONELZIMMET",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PERSONELID = table.Column<int>(type: "int", nullable: false),
                    ZIMMETTARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TESLIMTARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MARKAMODEL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SERINO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MIKTAR = table.Column<int>(type: "int", nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPPERSONELZIMMET", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPPERSONELZIMMET");

            migrationBuilder.DropColumn(
                name: "SGK",
                table: "MPPERSONEL");

            migrationBuilder.AlterColumn<string>(
                name: "ASKERLIKBITISTAR",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "ASKERLIKBASLANGICTAR",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
