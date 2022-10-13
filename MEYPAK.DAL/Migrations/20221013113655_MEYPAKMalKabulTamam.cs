using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKMalKabulTamam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MPSTOKMALKABULLIST",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SIRKETID = table.Column<int>(type: "int", nullable: false),
                    SUBEID = table.Column<int>(type: "int", nullable: false),
                    DEPOID = table.Column<int>(type: "int", nullable: false),
                    STOKID = table.Column<int>(type: "int", nullable: false),
                    BIRIMID = table.Column<int>(type: "int", nullable: false),
                    SIPARISDETAYID = table.Column<int>(type: "int", nullable: false),
                    SIPARISMIKTARI = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MIKTAR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EMIRID = table.Column<int>(type: "int", nullable: false),
                    KULLANICIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSTOKMALKABULLIST", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MPSTOKMALKABULLIST_MPDEPOEMIR_EMIRID",
                        column: x => x.EMIRID,
                        principalTable: "MPDEPOEMIR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MPSTOKMALKABULLIST_MPOLCUBR_BIRIMID",
                        column: x => x.BIRIMID,
                        principalTable: "MPOLCUBR",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MPSTOKMALKABULLIST_MPSIPARISDETAY_SIPARISDETAYID",
                        column: x => x.SIPARISDETAYID,
                        principalTable: "MPSIPARISDETAY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MPSTOKMALKABULLIST_MPSTOK_STOKID",
                        column: x => x.STOKID,
                        principalTable: "MPSTOK",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKMALKABULLIST_BIRIMID",
                table: "MPSTOKMALKABULLIST",
                column: "BIRIMID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKMALKABULLIST_EMIRID",
                table: "MPSTOKMALKABULLIST",
                column: "EMIRID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKMALKABULLIST_SIPARISDETAYID",
                table: "MPSTOKMALKABULLIST",
                column: "SIPARISDETAYID");

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKMALKABULLIST_STOKID",
                table: "MPSTOKMALKABULLIST",
                column: "STOKID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPSTOKMALKABULLIST");
        }
    }
}
