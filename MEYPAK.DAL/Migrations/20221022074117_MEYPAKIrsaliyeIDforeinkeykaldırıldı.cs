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

            migrationBuilder.AddForeignKey(
                name: "FK_MPIRSALIYESIPARISDETAYILISKI_MPIRSALIYEDETAY_IRSALIYEDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI",
                column: "IRSALIYEDETAYID",
                principalTable: "MPIRSALIYEDETAY",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MPIRSALIYESIPARISDETAYILISKI_MPSIPARISDETAY_SIPARISDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI",
                column: "SIPARISDETAYID",
                principalTable: "MPSIPARISDETAY",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPIRSALIYESIPARISDETAYILISKI_MPIRSALIYEDETAY_IRSALIYEDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI");

            migrationBuilder.DropForeignKey(
                name: "FK_MPIRSALIYESIPARISDETAYILISKI_MPSIPARISDETAY_SIPARISDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI");

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
        }
    }
}
