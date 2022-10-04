using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKContextGuncelleme2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKOLCUBR_MPSTOK_STOKID",
                table: "MPSTOKOLCUBR");

            migrationBuilder.DropIndex(
                name: "IX_MPSTOKOLCUBR_STOKID",
                table: "MPSTOKOLCUBR");

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKOLCUBR_MPSTOK_OLCUBRID",
                table: "MPSTOKOLCUBR",
                column: "OLCUBRID",
                principalTable: "MPSTOK",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKOLCUBR_MPSTOK_OLCUBRID",
                table: "MPSTOKOLCUBR");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKOLCUBR_STOKID",
                table: "MPSTOKOLCUBR",
                column: "STOKID");

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKOLCUBR_MPSTOK_STOKID",
                table: "MPSTOKOLCUBR",
                column: "STOKID",
                principalTable: "MPSTOK",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
