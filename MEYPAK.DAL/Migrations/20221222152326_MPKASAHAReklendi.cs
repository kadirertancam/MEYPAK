using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MPKASAHAReklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TUTAR",
                table: "MPKASA");

            migrationBuilder.AddColumn<decimal>(
                name: "KALANMIKTAR",
                table: "MPSTOKMALKABULLIST",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "MPKASAHAR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KASAID = table.Column<int>(type: "int", nullable: false),
                    CARIID = table.Column<int>(type: "int", nullable: false),
                    BANKAHESID = table.Column<int>(type: "int", nullable: false),
                    PERSONELID = table.Column<int>(type: "int", nullable: false),
                    MUHID = table.Column<int>(type: "int", nullable: false),
                    FATURAID = table.Column<int>(type: "int", nullable: false),
                    PARABIRIMID = table.Column<int>(type: "int", nullable: false),
                    BELGENO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KUR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TUTAR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TARIH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IO = table.Column<byte>(type: "tinyint", nullable: false),
                    TIP = table.Column<byte>(type: "tinyint", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPKASAHAR", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPKASAHAR");

            migrationBuilder.DropColumn(
                name: "KALANMIKTAR",
                table: "MPSTOKMALKABULLIST");

            migrationBuilder.AddColumn<decimal>(
                name: "TUTAR",
                table: "MPKASA",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
