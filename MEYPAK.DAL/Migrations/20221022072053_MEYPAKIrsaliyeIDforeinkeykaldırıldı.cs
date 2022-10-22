using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKIrsaliyeIDforeinkeykaldırıldı : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPIRSALIYESIPARISDETAYILISKI_MPIRSALIYEDETAY_IRSALIYEDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI");

            migrationBuilder.DropForeignKey(
                name: "FK_MPIRSALIYESIPARISDETAYILISKI_MPSIPARISDETAY_SIPARISDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI");

            migrationBuilder.DropForeignKey(
                name: "FK_MPSIPARISDETAY_MPIRSALIYE_IRSALIYEID",
                table: "MPSIPARISDETAY");

            migrationBuilder.DropIndex(
                name: "IX_MPSIPARISDETAY_IRSALIYEID",
                table: "MPSIPARISDETAY");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MPIRSALIYESIPARISDETAYILISKI",
                table: "MPIRSALIYESIPARISDETAYILISKI");

            migrationBuilder.DropIndex(
                name: "IX_MPIRSALIYESIPARISDETAYILISKI_SIPARISDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI");

            migrationBuilder.AddColumn<int>(
                name: "MPIRSALIYEID",
                table: "MPSIPARISDETAY",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "MPIRSALIYESIPARISDETAYILISKI",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "MPIRSALIYEDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MPSIPARISDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MPIRSALIYESIPARISDETAYILISKI",
                table: "MPIRSALIYESIPARISDETAYILISKI",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSIPARISDETAY_MPIRSALIYEID",
                table: "MPSIPARISDETAY",
                column: "MPIRSALIYEID");

            migrationBuilder.CreateIndex(
                name: "IX_MPIRSALIYESIPARISDETAYILISKI_MPIRSALIYEDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI",
                column: "MPIRSALIYEDETAYID");

            migrationBuilder.CreateIndex(
                name: "IX_MPIRSALIYESIPARISDETAYILISKI_MPSIPARISDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI",
                column: "MPSIPARISDETAYID");

            migrationBuilder.AddForeignKey(
                name: "FK_MPIRSALIYESIPARISDETAYILISKI_MPIRSALIYEDETAY_MPIRSALIYEDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI",
                column: "MPIRSALIYEDETAYID",
                principalTable: "MPIRSALIYEDETAY",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MPIRSALIYESIPARISDETAYILISKI_MPSIPARISDETAY_MPSIPARISDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI",
                column: "MPSIPARISDETAYID",
                principalTable: "MPSIPARISDETAY",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MPSIPARISDETAY_MPIRSALIYE_MPIRSALIYEID",
                table: "MPSIPARISDETAY",
                column: "MPIRSALIYEID",
                principalTable: "MPIRSALIYE",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPIRSALIYESIPARISDETAYILISKI_MPIRSALIYEDETAY_MPIRSALIYEDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI");

            migrationBuilder.DropForeignKey(
                name: "FK_MPIRSALIYESIPARISDETAYILISKI_MPSIPARISDETAY_MPSIPARISDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI");

            migrationBuilder.DropForeignKey(
                name: "FK_MPSIPARISDETAY_MPIRSALIYE_MPIRSALIYEID",
                table: "MPSIPARISDETAY");

            migrationBuilder.DropIndex(
                name: "IX_MPSIPARISDETAY_MPIRSALIYEID",
                table: "MPSIPARISDETAY");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MPIRSALIYESIPARISDETAYILISKI",
                table: "MPIRSALIYESIPARISDETAYILISKI");

            migrationBuilder.DropIndex(
                name: "IX_MPIRSALIYESIPARISDETAYILISKI_MPIRSALIYEDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI");

            migrationBuilder.DropIndex(
                name: "IX_MPIRSALIYESIPARISDETAYILISKI_MPSIPARISDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI");

            migrationBuilder.DropColumn(
                name: "MPIRSALIYEID",
                table: "MPSIPARISDETAY");

            migrationBuilder.DropColumn(
                name: "MPIRSALIYEDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI");

            migrationBuilder.DropColumn(
                name: "MPSIPARISDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "MPIRSALIYESIPARISDETAYILISKI",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MPIRSALIYESIPARISDETAYILISKI",
                table: "MPIRSALIYESIPARISDETAYILISKI",
                columns: new[] { "IRSALIYEDETAYID", "SIPARISDETAYID" });

            migrationBuilder.CreateIndex(
                name: "IX_MPSIPARISDETAY_IRSALIYEID",
                table: "MPSIPARISDETAY",
                column: "IRSALIYEID");

            migrationBuilder.CreateIndex(
                name: "IX_MPIRSALIYESIPARISDETAYILISKI_SIPARISDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI",
                column: "SIPARISDETAYID");

            migrationBuilder.AddForeignKey(
                name: "FK_MPIRSALIYESIPARISDETAYILISKI_MPIRSALIYEDETAY_IRSALIYEDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI",
                column: "IRSALIYEDETAYID",
                principalTable: "MPIRSALIYEDETAY",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MPIRSALIYESIPARISDETAYILISKI_MPSIPARISDETAY_SIPARISDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI",
                column: "SIPARISDETAYID",
                principalTable: "MPSIPARISDETAY",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MPSIPARISDETAY_MPIRSALIYE_IRSALIYEID",
                table: "MPSIPARISDETAY",
                column: "IRSALIYEID",
                principalTable: "MPIRSALIYE",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
