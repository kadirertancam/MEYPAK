using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKSevkiyat2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MPDEPOEMIRSIPARISKALEMILISKI",
                columns: table => new
                {
                    DEPOEMIRID = table.Column<int>(type: "int", nullable: false),
                    SIPARISDETAYID = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPDEPOEMIRSIPARISKALEMILISKI", x => new { x.DEPOEMIRID, x.SIPARISDETAYID });
                    table.ForeignKey(
                        name: "FK_MPDEPOEMIRSIPARISKALEMILISKI_MPDEPOEMIR_DEPOEMIRID",
                        column: x => x.DEPOEMIRID,
                        principalTable: "MPDEPOEMIR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MPDEPOEMIRSIPARISKALEMILISKI_MPSIPARISDETAY_SIPARISDETAYID",
                        column: x => x.SIPARISDETAYID,
                        principalTable: "MPSIPARISDETAY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MPDEPOEMIRSIPARISKALEMILISKI_SIPARISDETAYID",
                table: "MPDEPOEMIRSIPARISKALEMILISKI",
                column: "SIPARISDETAYID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPDEPOEMIRSIPARISKALEMILISKI");
        }
    }
}
