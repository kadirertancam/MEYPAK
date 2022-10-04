using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKContextGuncelleme6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKOLCUBR_MPOLCUBR_OLCUBRID",
                table: "MPSTOKOLCUBR");

            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKOLCUBR_MPSTOK_OLCUBRID",
                table: "MPSTOKOLCUBR");

            migrationBuilder.RenameColumn(
                name: "OLCUBRID",
                table: "MPSTOKOLCUBR",
                newName: "OLCUBRIDS");

            migrationBuilder.RenameIndex(
                name: "IX_MPSTOKOLCUBR_OLCUBRID",
                table: "MPSTOKOLCUBR",
                newName: "IX_MPSTOKOLCUBR_OLCUBRIDS");

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

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKOLCUBR_MPSTOK_OLCUBRIDS",
                table: "MPSTOKOLCUBR",
                column: "OLCUBRIDS",
                principalTable: "MPSTOK",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKOLCUBR_MPOLCUBR_OLCUBRIDD",
                table: "MPSTOKOLCUBR");

            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKOLCUBR_MPSTOK_OLCUBRIDS",
                table: "MPSTOKOLCUBR");

            migrationBuilder.DropIndex(
                name: "IX_MPSTOKOLCUBR_OLCUBRIDD",
                table: "MPSTOKOLCUBR");

            migrationBuilder.DropColumn(
                name: "OLCUBRIDD",
                table: "MPSTOKOLCUBR");

            migrationBuilder.RenameColumn(
                name: "OLCUBRIDS",
                table: "MPSTOKOLCUBR",
                newName: "OLCUBRID");

            migrationBuilder.RenameIndex(
                name: "IX_MPSTOKOLCUBR_OLCUBRIDS",
                table: "MPSTOKOLCUBR",
                newName: "IX_MPSTOKOLCUBR_OLCUBRID");

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKOLCUBR_MPOLCUBR_OLCUBRID",
                table: "MPSTOKOLCUBR",
                column: "OLCUBRID",
                principalTable: "MPOLCUBR",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKOLCUBR_MPSTOK_OLCUBRID",
                table: "MPSTOKOLCUBR",
                column: "OLCUBRID",
                principalTable: "MPSTOK",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
