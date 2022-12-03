using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class FaturaveIrsaliyeDuzenleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SIPARISID",
                table: "MPIRSALIYEDETAY",
                newName: "STOKID");

            migrationBuilder.RenameColumn(
                name: "SIPARISID",
                table: "MPFATURA",
                newName: "IRSALIYEID");

            migrationBuilder.AddColumn<int>(
                name: "IRSALIYEID",
                table: "MPIRSALIYEDETAY",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "STOKID",
                table: "MPFATURADETAY",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MPSERI",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SERINO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TIP = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSERI", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPSERI");

            migrationBuilder.DropColumn(
                name: "IRSALIYEID",
                table: "MPIRSALIYEDETAY");

            migrationBuilder.DropColumn(
                name: "STOKID",
                table: "MPFATURADETAY");

            migrationBuilder.RenameColumn(
                name: "STOKID",
                table: "MPIRSALIYEDETAY",
                newName: "SIPARISID");

            migrationBuilder.RenameColumn(
                name: "IRSALIYEID",
                table: "MPFATURA",
                newName: "SIPARISID");
        }
    }
}
