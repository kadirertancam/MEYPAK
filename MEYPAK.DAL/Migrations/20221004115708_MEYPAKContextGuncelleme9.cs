using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKContextGuncelleme9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKOLCUBR_MPOLCUBR_OLCUBRIDS",
                table: "MPSTOKOLCUBR");

            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKOLCUBR_MPSTOK_OLCUBRIDS",
                table: "MPSTOKOLCUBR");

            migrationBuilder.DropIndex(
                name: "IX_MPSTOKOLCUBR_OLCUBRIDS",
                table: "MPSTOKOLCUBR");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKOLCUBR_STOKID",
                table: "MPSTOKOLCUBR",
                column: "STOKID");

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKOLCUBR_MPOLCUBR_STOKID",
                table: "MPSTOKOLCUBR",
                column: "STOKID",
                principalTable: "MPOLCUBR",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKOLCUBR_MPSTOK_STOKID",
                table: "MPSTOKOLCUBR",
                column: "STOKID",
                principalTable: "MPSTOK",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKOLCUBR_MPOLCUBR_STOKID",
                table: "MPSTOKOLCUBR");

            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKOLCUBR_MPSTOK_STOKID",
                table: "MPSTOKOLCUBR");

            migrationBuilder.DropIndex(
                name: "IX_MPSTOKOLCUBR_STOKID",
                table: "MPSTOKOLCUBR");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKOLCUBR_OLCUBRIDS",
                table: "MPSTOKOLCUBR",
                column: "OLCUBRIDS");

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKOLCUBR_MPOLCUBR_OLCUBRIDS",
                table: "MPSTOKOLCUBR",
                column: "OLCUBRIDS",
                principalTable: "MPOLCUBR",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKOLCUBR_MPSTOK_OLCUBRIDS",
                table: "MPSTOKOLCUBR",
                column: "OLCUBRIDS",
                principalTable: "MPSTOK",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
