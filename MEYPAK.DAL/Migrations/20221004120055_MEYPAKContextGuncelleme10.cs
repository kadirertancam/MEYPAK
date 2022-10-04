using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKContextGuncelleme10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OLCUBRIDS",
                table: "MPSTOKOLCUBR",
                newName: "OLCUBRID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OLCUBRID",
                table: "MPSTOKOLCUBR",
                newName: "OLCUBRIDS");
        }
    }
}
