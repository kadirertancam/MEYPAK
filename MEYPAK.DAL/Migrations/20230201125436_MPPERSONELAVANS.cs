using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MPPERSONELAVANS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IZINDURUMU",
                table: "MPPERSONELIZIN",
                newName: "IZINTURU");

            migrationBuilder.AddColumn<int>(
                name: "IZINGUN",
                table: "MPPERSONELIZIN",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "AKTIF",
                table: "MPPERSONEL",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MAAS",
                table: "MPPERSONEL",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MPPERSONELAVANS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PERSONELID = table.Column<int>(type: "int", nullable: false),
                    MIKTAR = table.Column<int>(type: "int", nullable: false),
                    TARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPPERSONELAVANS", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPPERSONELAVANS");

            migrationBuilder.DropColumn(
                name: "IZINGUN",
                table: "MPPERSONELIZIN");

            migrationBuilder.DropColumn(
                name: "AKTIF",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "MAAS",
                table: "MPPERSONEL");

            migrationBuilder.RenameColumn(
                name: "IZINTURU",
                table: "MPPERSONELIZIN",
                newName: "IZINDURUMU");
        }
    }
}
