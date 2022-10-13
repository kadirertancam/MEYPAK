using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKIrsaliye2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MPIRSALIYESIPARISDETAYILISKI",
                columns: table => new
                {
                    SIPARISDETAYID = table.Column<int>(type: "int", nullable: false),
                    IRSALIYEDETAYID = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPIRSALIYESIPARISDETAYILISKI", x => new { x.IRSALIYEDETAYID, x.SIPARISDETAYID });
                    table.ForeignKey(
                        name: "FK_MPIRSALIYESIPARISDETAYILISKI_MPIRSALIYEDETAY_IRSALIYEDETAYID",
                        column: x => x.IRSALIYEDETAYID,
                        principalTable: "MPIRSALIYEDETAY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MPIRSALIYESIPARISDETAYILISKI_MPSIPARISDETAY_SIPARISDETAYID",
                        column: x => x.SIPARISDETAYID,
                        principalTable: "MPSIPARISDETAY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MPIRSALIYESIPARISDETAYILISKI_SIPARISDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI",
                column: "SIPARISDETAYID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPIRSALIYESIPARISDETAYILISKI");
        }
    }
}
