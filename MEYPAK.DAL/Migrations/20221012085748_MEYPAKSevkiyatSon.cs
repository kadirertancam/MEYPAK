using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKSevkiyatSon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPDEPOEMIR_MPSIPARIS_SIPARISID",
                table: "MPDEPOEMIR");

            migrationBuilder.DropForeignKey(
                name: "FK_MPIRSALIYE_MPSIPARIS_SIPARISID",
                table: "MPIRSALIYE");

            migrationBuilder.AddColumn<int>(
                name: "SIPARISDETAYID",
                table: "MPSTOKSEVKİYATLİST",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKSEVKİYATLİST_SIPARISDETAYID",
                table: "MPSTOKSEVKİYATLİST",
                column: "SIPARISDETAYID");

            migrationBuilder.AddForeignKey(
                name: "FK_MPDEPOEMIR_MPSIPARIS_SIPARISID",
                table: "MPDEPOEMIR",
                column: "SIPARISID",
                principalTable: "MPSIPARIS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MPIRSALIYE_MPSIPARIS_SIPARISID",
                table: "MPIRSALIYE",
                column: "SIPARISID",
                principalTable: "MPSIPARIS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKSEVKİYATLİST_MPSIPARISDETAY_SIPARISDETAYID",
                table: "MPSTOKSEVKİYATLİST",
                column: "SIPARISDETAYID",
                principalTable: "MPSIPARISDETAY",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPDEPOEMIR_MPSIPARIS_SIPARISID",
                table: "MPDEPOEMIR");

            migrationBuilder.DropForeignKey(
                name: "FK_MPIRSALIYE_MPSIPARIS_SIPARISID",
                table: "MPIRSALIYE");

            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKSEVKİYATLİST_MPSIPARISDETAY_SIPARISDETAYID",
                table: "MPSTOKSEVKİYATLİST");

            migrationBuilder.DropIndex(
                name: "IX_MPSTOKSEVKİYATLİST_SIPARISDETAYID",
                table: "MPSTOKSEVKİYATLİST");

            migrationBuilder.DropColumn(
                name: "SIPARISDETAYID",
                table: "MPSTOKSEVKİYATLİST");

            migrationBuilder.AddForeignKey(
                name: "FK_MPDEPOEMIR_MPSIPARIS_SIPARISID",
                table: "MPDEPOEMIR",
                column: "SIPARISID",
                principalTable: "MPSIPARIS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MPIRSALIYE_MPSIPARIS_SIPARISID",
                table: "MPIRSALIYE",
                column: "SIPARISID",
                principalTable: "MPSIPARIS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
