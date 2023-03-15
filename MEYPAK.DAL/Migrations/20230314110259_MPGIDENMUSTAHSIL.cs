using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MPGIDENMUSTAHSIL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MPGIDENMUSTAHSILMAKBUZLARI",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MUSTAHSILID = table.Column<int>(type: "int", nullable: false),
                    BELGENO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TIP = table.Column<int>(type: "int", nullable: false),
                    HATAKODU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DURUM = table.Column<int>(type: "int", nullable: false),
                    ETTNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false),
                    USERID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPGIDENMUSTAHSILMAKBUZLARI", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPGIDENMUSTAHSILMAKBUZLARI");
        }
    }
}
