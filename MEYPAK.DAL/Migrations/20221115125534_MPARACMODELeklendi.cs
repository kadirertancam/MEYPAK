using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MPARACMODELeklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IMG",
                table: "MPPERSONEL",
                type: "ntext",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "MPARACMODEL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MARKAADI = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MODELADI = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPARACMODEL", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPARACMODEL");

            migrationBuilder.DropColumn(
                name: "IMG",
                table: "MPPERSONEL");
        }
    }
}
