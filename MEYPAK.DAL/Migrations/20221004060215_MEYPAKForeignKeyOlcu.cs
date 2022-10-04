using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKForeignKeyOlcu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPOLCUBR_MPSTOKOLCUBR_MPSTOKOLCUBRID",
                table: "MPOLCUBR");

            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKOLCUBR_MPSTOK_MPSTOKID",
                table: "MPSTOKOLCUBR");

            migrationBuilder.DropIndex(
                name: "IX_MPOLCUBR_MPSTOKOLCUBRID",
                table: "MPOLCUBR");

            migrationBuilder.DropColumn(
                name: "MPSTOKOLCUBRID",
                table: "MPOLCUBR");

            migrationBuilder.RenameColumn(
                name: "MPSTOKID",
                table: "MPSTOKOLCUBR",
                newName: "STOKID");

            migrationBuilder.RenameIndex(
                name: "IX_MPSTOKOLCUBR_MPSTOKID",
                table: "MPSTOKOLCUBR",
                newName: "IX_MPSTOKOLCUBR_STOKID");

            migrationBuilder.AddColumn<int>(
                name: "OLCUBRID",
                table: "MPSTOKOLCUBR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKOLCUBR_OLCUBRID",
                table: "MPSTOKOLCUBR",
                column: "OLCUBRID");

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKOLCUBR_MPOLCUBR_OLCUBRID",
                table: "MPSTOKOLCUBR",
                column: "OLCUBRID",
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
                name: "FK_MPSTOKOLCUBR_MPOLCUBR_OLCUBRID",
                table: "MPSTOKOLCUBR");

            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKOLCUBR_MPSTOK_STOKID",
                table: "MPSTOKOLCUBR");

            migrationBuilder.DropIndex(
                name: "IX_MPSTOKOLCUBR_OLCUBRID",
                table: "MPSTOKOLCUBR");

            migrationBuilder.DropColumn(
                name: "OLCUBRID",
                table: "MPSTOKOLCUBR");

            migrationBuilder.RenameColumn(
                name: "STOKID",
                table: "MPSTOKOLCUBR",
                newName: "MPSTOKID");

            migrationBuilder.RenameIndex(
                name: "IX_MPSTOKOLCUBR_STOKID",
                table: "MPSTOKOLCUBR",
                newName: "IX_MPSTOKOLCUBR_MPSTOKID");

            migrationBuilder.AddColumn<int>(
                name: "MPSTOKOLCUBRID",
                table: "MPOLCUBR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MPOLCUBR_MPSTOKOLCUBRID",
                table: "MPOLCUBR",
                column: "MPSTOKOLCUBRID");

            migrationBuilder.AddForeignKey(
                name: "FK_MPOLCUBR_MPSTOKOLCUBR_MPSTOKOLCUBRID",
                table: "MPOLCUBR",
                column: "MPSTOKOLCUBRID",
                principalTable: "MPSTOKOLCUBR",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKOLCUBR_MPSTOK_MPSTOKID",
                table: "MPSTOKOLCUBR",
                column: "MPSTOKID",
                principalTable: "MPSTOK",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
