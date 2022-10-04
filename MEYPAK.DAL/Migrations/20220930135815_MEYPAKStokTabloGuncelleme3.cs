using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKStokTabloGuncelleme3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ADI",
                table: "MPSTOKOLCUBR");

            migrationBuilder.DropColumn(
                name: "KATSAYI2",
                table: "MPSTOK");

            migrationBuilder.DropColumn(
                name: "KATSAYI3",
                table: "MPSTOK");

            migrationBuilder.DropColumn(
                name: "OLCUBR2",
                table: "MPSTOK");

            migrationBuilder.DropColumn(
                name: "OLCUBR3",
                table: "MPSTOK");

            migrationBuilder.AddColumn<int>(
                name: "OLCUBRID",
                table: "MPSTOKOLCUBR",
                type: "int",
                maxLength: 100,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OLCUBRID",
                table: "MPSTOKOLCUBR");

            migrationBuilder.AddColumn<string>(
                name: "ADI",
                table: "MPSTOKOLCUBR",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "KATSAYI2",
                table: "MPSTOK",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KATSAYI3",
                table: "MPSTOK",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OLCUBR2",
                table: "MPSTOK",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OLCUBR3",
                table: "MPSTOK",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
