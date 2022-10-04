using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKContextGuncelleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKSAYIMHAR_BIRIMID",
                table: "MPSTOKSAYIMHAR",
                column: "BIRIMID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKSAYIMHAR_STOKID",
                table: "MPSTOKSAYIMHAR",
                column: "STOKID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKSAYIMHAR_STOKSAYIMID",
                table: "MPSTOKSAYIMHAR",
                column: "STOKSAYIMID");

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKSAYIMHAR_MPOLCUBR_BIRIMID",
                table: "MPSTOKSAYIMHAR",
                column: "BIRIMID",
                principalTable: "MPOLCUBR",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKSAYIMHAR_MPSTOK_STOKID",
                table: "MPSTOKSAYIMHAR",
                column: "STOKID",
                principalTable: "MPSTOK",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKSAYIMHAR_MPSTOKSAYIM_STOKSAYIMID",
                table: "MPSTOKSAYIMHAR",
                column: "STOKSAYIMID",
                principalTable: "MPSTOKSAYIM",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKSAYIMHAR_MPOLCUBR_BIRIMID",
                table: "MPSTOKSAYIMHAR");

            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKSAYIMHAR_MPSTOK_STOKID",
                table: "MPSTOKSAYIMHAR");

            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKSAYIMHAR_MPSTOKSAYIM_STOKSAYIMID",
                table: "MPSTOKSAYIMHAR");

            migrationBuilder.DropIndex(
                name: "IX_MPSTOKSAYIMHAR_BIRIMID",
                table: "MPSTOKSAYIMHAR");

            migrationBuilder.DropIndex(
                name: "IX_MPSTOKSAYIMHAR_STOKID",
                table: "MPSTOKSAYIMHAR");

            migrationBuilder.DropIndex(
                name: "IX_MPSTOKSAYIMHAR_STOKSAYIMID",
                table: "MPSTOKSAYIMHAR");
        }
    }
}
