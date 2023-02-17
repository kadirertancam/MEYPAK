using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class dekontt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MPDEKONT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CARIID = table.Column<int>(type: "int", nullable: false),
                    BANKAID = table.Column<int>(type: "int", nullable: false),
                    PERSONELID = table.Column<int>(type: "int", nullable: false),
                    KASAID = table.Column<int>(type: "int", nullable: false),
                    MUHASEBEID = table.Column<int>(type: "int", nullable: false),
                    BELGENO = table.Column<int>(type: "int", nullable: false),
                    TUTAR = table.Column<int>(type: "int", nullable: false),
                    IO = table.Column<int>(type: "int", nullable: false),
                    KDV = table.Column<int>(type: "int", nullable: false),
                    ISKONTO1 = table.Column<int>(type: "int", nullable: false),
                    ISKONTO2 = table.Column<int>(type: "int", nullable: false),
                    ISKONTO3 = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false),
                    USERID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPDEKONT", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPDEKONT");
        }
    }
}
