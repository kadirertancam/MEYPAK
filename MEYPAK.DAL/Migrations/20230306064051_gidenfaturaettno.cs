using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class gidenfaturaettno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mPGIDENFATURALAR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BELGENO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TIP = table.Column<int>(type: "int", nullable: false),
                    HATAKODU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DURUM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ETTNO = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false),
                    USERID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mPGIDENFATURALAR", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mPGIDENFATURALAR");
        }
    }
}
