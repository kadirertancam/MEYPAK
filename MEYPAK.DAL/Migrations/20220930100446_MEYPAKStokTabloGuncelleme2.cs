using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKStokTabloGuncelleme2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OLCUBRID",
                table: "MPSTOK",
                newName: "OLCUBR3");

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
                name: "OLCUBR1",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KATSAYI2",
                table: "MPSTOK");

            migrationBuilder.DropColumn(
                name: "KATSAYI3",
                table: "MPSTOK");

            migrationBuilder.DropColumn(
                name: "OLCUBR1",
                table: "MPSTOK");

            migrationBuilder.DropColumn(
                name: "OLCUBR2",
                table: "MPSTOK");

            migrationBuilder.RenameColumn(
                name: "OLCUBR3",
                table: "MPSTOK",
                newName: "OLCUBRID");
        }
    }
}
