using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKGuncelleme4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPOLCUBR_MPSTOKOLCUBR_MPSTOKOLCUBRID",
                table: "MPOLCUBR");

            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKOLCUBR_MPSTOK_MPSTOKID",
                table: "MPSTOKOLCUBR");

            migrationBuilder.AlterColumn<int>(
                name: "MPSTOKID",
                table: "MPSTOKOLCUBR",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MPSTOKOLCUBRID",
                table: "MPOLCUBR",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPOLCUBR_MPSTOKOLCUBR_MPSTOKOLCUBRID",
                table: "MPOLCUBR");

            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKOLCUBR_MPSTOK_MPSTOKID",
                table: "MPSTOKOLCUBR");

            migrationBuilder.AlterColumn<int>(
                name: "MPSTOKID",
                table: "MPSTOKOLCUBR",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MPSTOKOLCUBRID",
                table: "MPOLCUBR",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_MPOLCUBR_MPSTOKOLCUBR_MPSTOKOLCUBRID",
                table: "MPOLCUBR",
                column: "MPSTOKOLCUBRID",
                principalTable: "MPSTOKOLCUBR",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKOLCUBR_MPSTOK_MPSTOKID",
                table: "MPSTOKOLCUBR",
                column: "MPSTOKID",
                principalTable: "MPSTOK",
                principalColumn: "ID");
        }
    }
}
