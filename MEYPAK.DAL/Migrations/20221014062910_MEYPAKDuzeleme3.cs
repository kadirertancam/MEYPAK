using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKDuzeleme3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BEKLEYENMIKTAR",
                table: "MPSIPARISSEVKEMRIHAR");

            migrationBuilder.DropColumn(
                name: "DEPOMIKTAR",
                table: "MPSIPARISSEVKEMRIHAR");

            migrationBuilder.AddColumn<int>(
                name: "DEPOID",
                table: "MPDEPOEMIR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MPSIPARISSEVKEMRIHAR_EMIRID",
                table: "MPSIPARISSEVKEMRIHAR",
                column: "EMIRID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSIPARISSEVKEMRIHAR_SIPARISID",
                table: "MPSIPARISSEVKEMRIHAR",
                column: "SIPARISID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSIPARISSEVKEMRIHAR_SIPARISKALEMID",
                table: "MPSIPARISSEVKEMRIHAR",
                column: "SIPARISKALEMID");

            migrationBuilder.CreateIndex(
                name: "IX_MPDEPOEMIR_DEPOID",
                table: "MPDEPOEMIR",
                column: "DEPOID");

            migrationBuilder.AddForeignKey(
                name: "FK_MPDEPOEMIR_MPDEPO_DEPOID",
                table: "MPDEPOEMIR",
                column: "DEPOID",
                principalTable: "MPDEPO",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MPSIPARISSEVKEMRIHAR_MPDEPOEMIR_EMIRID",
                table: "MPSIPARISSEVKEMRIHAR",
                column: "EMIRID",
                principalTable: "MPDEPOEMIR",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MPSIPARISSEVKEMRIHAR_MPSIPARIS_SIPARISID",
                table: "MPSIPARISSEVKEMRIHAR",
                column: "SIPARISID",
                principalTable: "MPSIPARIS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MPSIPARISSEVKEMRIHAR_MPSIPARISDETAY_SIPARISKALEMID",
                table: "MPSIPARISSEVKEMRIHAR",
                column: "SIPARISKALEMID",
                principalTable: "MPSIPARISDETAY",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPDEPOEMIR_MPDEPO_DEPOID",
                table: "MPDEPOEMIR");

            migrationBuilder.DropForeignKey(
                name: "FK_MPSIPARISSEVKEMRIHAR_MPDEPOEMIR_EMIRID",
                table: "MPSIPARISSEVKEMRIHAR");

            migrationBuilder.DropForeignKey(
                name: "FK_MPSIPARISSEVKEMRIHAR_MPSIPARIS_SIPARISID",
                table: "MPSIPARISSEVKEMRIHAR");

            migrationBuilder.DropForeignKey(
                name: "FK_MPSIPARISSEVKEMRIHAR_MPSIPARISDETAY_SIPARISKALEMID",
                table: "MPSIPARISSEVKEMRIHAR");

            migrationBuilder.DropIndex(
                name: "IX_MPSIPARISSEVKEMRIHAR_EMIRID",
                table: "MPSIPARISSEVKEMRIHAR");

            migrationBuilder.DropIndex(
                name: "IX_MPSIPARISSEVKEMRIHAR_SIPARISID",
                table: "MPSIPARISSEVKEMRIHAR");

            migrationBuilder.DropIndex(
                name: "IX_MPSIPARISSEVKEMRIHAR_SIPARISKALEMID",
                table: "MPSIPARISSEVKEMRIHAR");

            migrationBuilder.DropIndex(
                name: "IX_MPDEPOEMIR_DEPOID",
                table: "MPDEPOEMIR");

            migrationBuilder.DropColumn(
                name: "DEPOID",
                table: "MPDEPOEMIR");

            migrationBuilder.AddColumn<decimal>(
                name: "BEKLEYENMIKTAR",
                table: "MPSIPARISSEVKEMRIHAR",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DEPOMIKTAR",
                table: "MPSIPARISSEVKEMRIHAR",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
