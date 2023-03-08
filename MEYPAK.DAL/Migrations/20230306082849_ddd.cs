using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class ddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_mPGIDENFATURALAR",
                table: "mPGIDENFATURALAR");

            migrationBuilder.RenameTable(
                name: "mPGIDENFATURALAR",
                newName: "MPGIDENFATURALAR");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MPGIDENFATURALAR",
                table: "MPGIDENFATURALAR",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MPGIDENFATURALAR",
                table: "MPGIDENFATURALAR");

            migrationBuilder.RenameTable(
                name: "MPGIDENFATURALAR",
                newName: "mPGIDENFATURALAR");

            migrationBuilder.AddPrimaryKey(
                name: "PK_mPGIDENFATURALAR",
                table: "mPGIDENFATURALAR",
                column: "ID");
        }
    }
}
