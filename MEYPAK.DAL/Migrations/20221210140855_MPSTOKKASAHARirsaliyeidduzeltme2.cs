using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MPSTOKKASAHARirsaliyeidduzeltme2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ISTISNANO",
                table: "MPIRSALIYEDETAY");

            migrationBuilder.DropColumn(
                name: "TEVKIFATNO",
                table: "MPIRSALIYEDETAY");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ISTISNANO",
                table: "MPIRSALIYEDETAY",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TEVKIFATNO",
                table: "MPIRSALIYEDETAY",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
