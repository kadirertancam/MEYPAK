using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKGuncelleme2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MPSTOKID",
                table: "MPSTOKOLCUBR",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKOLCUBR_MPSTOKID",
                table: "MPSTOKOLCUBR",
                column: "MPSTOKID");

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKOLCUBR_MPSTOK_MPSTOKID",
                table: "MPSTOKOLCUBR",
                column: "MPSTOKID",
                principalTable: "MPSTOK",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKOLCUBR_MPSTOK_MPSTOKID",
                table: "MPSTOKOLCUBR");

            migrationBuilder.DropIndex(
                name: "IX_MPSTOKOLCUBR_MPSTOKID",
                table: "MPSTOKOLCUBR");

            migrationBuilder.DropColumn(
                name: "MPSTOKID",
                table: "MPSTOKOLCUBR");
        }
    }
}
