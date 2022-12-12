using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MPSIPARISDETAYduzenleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MIKTAR",
                table: "MPSIPARISDETAY",
                newName: "ISKTOPLAM");

            migrationBuilder.AddColumn<int>(
                name: "NUM",
                table: "MPSIPARISDETAY",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "ALTISKONTO1",
                table: "MPSIPARIS",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ALTISKONTO2",
                table: "MPSIPARIS",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ALTISKONTO3",
                table: "MPSIPARIS",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NUM",
                table: "MPSIPARISDETAY");

            migrationBuilder.DropColumn(
                name: "ALTISKONTO1",
                table: "MPSIPARIS");

            migrationBuilder.DropColumn(
                name: "ALTISKONTO2",
                table: "MPSIPARIS");

            migrationBuilder.DropColumn(
                name: "ALTISKONTO3",
                table: "MPSIPARIS");

            migrationBuilder.RenameColumn(
                name: "ISKTOPLAM",
                table: "MPSIPARISDETAY",
                newName: "MIKTAR");
        }
    }
}
