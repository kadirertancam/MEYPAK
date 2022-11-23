using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MPCARIDOKUMAN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.AlterColumn<string>(
                name: "ADI",
                table: "MPCARIALTHES",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.CreateTable(
                name: "MPCARIDOKUMAN",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CARIID = table.Column<int>(type: "int", nullable: false),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOKUMAN = table.Column<string>(type: "ntext", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPCARIDOKUMAN", x => x.ID);
                });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPCARIDOKUMAN");

            migrationBuilder.DropTable(
                name: "MPCARIYETKILI");

            migrationBuilder.AlterColumn<string>(
                name: "ADI",
                table: "MPCARIALTHES",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "CARIID",
                table: "MPCARIALTHES",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
