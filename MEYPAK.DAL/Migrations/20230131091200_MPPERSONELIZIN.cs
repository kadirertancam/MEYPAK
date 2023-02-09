using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MPPERSONELIZIN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MPPERSONELIZIN",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PERSONELID = table.Column<int>(type: "int", nullable: false),
                    IZINNEDENI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IZINDURUMU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DEVREDILECEKPERSONEL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IZINBASLANGIC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IZINBITIS = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPPERSONELIZIN", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPPERSONELIZIN");
        }
    }
}
