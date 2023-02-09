using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class EISLEMLER : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MPGELENEFATURA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VKNTC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CARIADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BELGENO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VADETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TUTAR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KDV = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FATURATIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ETTNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DURUM = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false),
                    USERID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPGELENEFATURA", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPGELENEFATURA");
        }
    }
}
