using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKGuncelleme3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OLCUBRID",
                table: "MPSTOKOLCUBR");

            migrationBuilder.DropColumn(
                name: "STOKID",
                table: "MPSTOKOLCUBR");

            migrationBuilder.AddColumn<int>(
                name: "MPSTOKOLCUBRID",
                table: "MPOLCUBR",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MPOLCUBR_MPSTOKOLCUBRID",
                table: "MPOLCUBR",
                column: "MPSTOKOLCUBRID");

            migrationBuilder.AddForeignKey(
                name: "FK_MPOLCUBR_MPSTOKOLCUBR_MPSTOKOLCUBRID",
                table: "MPOLCUBR",
                column: "MPSTOKOLCUBRID",
                principalTable: "MPSTOKOLCUBR",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPOLCUBR_MPSTOKOLCUBR_MPSTOKOLCUBRID",
                table: "MPOLCUBR");

            migrationBuilder.DropIndex(
                name: "IX_MPOLCUBR_MPSTOKOLCUBRID",
                table: "MPOLCUBR");

            migrationBuilder.DropColumn(
                name: "MPSTOKOLCUBRID",
                table: "MPOLCUBR");

            migrationBuilder.AddColumn<int>(
                name: "OLCUBRID",
                table: "MPSTOKOLCUBR",
                type: "int",
                maxLength: 100,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "STOKID",
                table: "MPSTOKOLCUBR",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
