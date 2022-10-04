using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKStokTabloDuzenlemesi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CARIID",
                table: "MPSTOKHAR");

            migrationBuilder.DropColumn(
                name: "ISKONTO",
                table: "MPSTOKHAR");

            migrationBuilder.DropColumn(
                name: "OTV",
                table: "MPSTOKHAR");

            migrationBuilder.RenameColumn(
                name: "PALETTIPI",
                table: "MPSTOKHAR",
                newName: "IO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IO",
                table: "MPSTOKHAR",
                newName: "PALETTIPI");

            migrationBuilder.AddColumn<int>(
                name: "CARIID",
                table: "MPSTOKHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "ISKONTO",
                table: "MPSTOKHAR",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "OTV",
                table: "MPSTOKHAR",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
