using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKContextGuncelleme7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKOLCUBR_MPOLCUBR_OLCUBRIDD",
                table: "MPSTOKOLCUBR");

            migrationBuilder.DropIndex(
                name: "IX_MPSTOKOLCUBR_OLCUBRIDD",
                table: "MPSTOKOLCUBR");

            migrationBuilder.DropColumn(
                name: "OLCUBRIDD",
                table: "MPSTOKOLCUBR");

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKOLCUBR_MPOLCUBR_OLCUBRIDS",
                table: "MPSTOKOLCUBR",
                column: "OLCUBRIDS",
                principalTable: "MPOLCUBR",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKOLCUBR_MPOLCUBR_OLCUBRIDS",
                table: "MPSTOKOLCUBR");

            migrationBuilder.AddColumn<int>(
                name: "OLCUBRIDD",
                table: "MPSTOKOLCUBR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKOLCUBR_OLCUBRIDD",
                table: "MPSTOKOLCUBR",
                column: "OLCUBRIDD");

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKOLCUBR_MPOLCUBR_OLCUBRIDD",
                table: "MPSTOKOLCUBR",
                column: "OLCUBRIDD",
                principalTable: "MPOLCUBR",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
