using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKSiparis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DOVIZID",
                table: "MPSTOKFIYATLISTHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "KUR",
                table: "MPSTOKFIYATLISTHAR",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKFIYATLISTHAR_FIYATLISTID",
                table: "MPSTOKFIYATLISTHAR",
                column: "FIYATLISTID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKFIYATLISTHAR_STOKID",
                table: "MPSTOKFIYATLISTHAR",
                column: "STOKID");

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKFIYATLISTHAR_MPSTOK_STOKID",
                table: "MPSTOKFIYATLISTHAR",
                column: "STOKID",
                principalTable: "MPSTOK",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKFIYATLISTHAR_MPSTOKFIYATLIST_FIYATLISTID",
                table: "MPSTOKFIYATLISTHAR",
                column: "FIYATLISTID",
                principalTable: "MPSTOKFIYATLIST",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKFIYATLISTHAR_MPSTOK_STOKID",
                table: "MPSTOKFIYATLISTHAR");

            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKFIYATLISTHAR_MPSTOKFIYATLIST_FIYATLISTID",
                table: "MPSTOKFIYATLISTHAR");

            migrationBuilder.DropIndex(
                name: "IX_MPSTOKFIYATLISTHAR_FIYATLISTID",
                table: "MPSTOKFIYATLISTHAR");

            migrationBuilder.DropIndex(
                name: "IX_MPSTOKFIYATLISTHAR_STOKID",
                table: "MPSTOKFIYATLISTHAR");

            migrationBuilder.DropColumn(
                name: "DOVIZID",
                table: "MPSTOKFIYATLISTHAR");

            migrationBuilder.DropColumn(
                name: "KUR",
                table: "MPSTOKFIYATLISTHAR");
        }
    }
}
