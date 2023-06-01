using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class bildirimturueklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BILDIRIMTURU",
                table: "MPIRSALIYE",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BILDIRIMTURUID",
                table: "MPIRSALIYE",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BILDIRIMTURU",
                table: "MPIRSALIYE");

            migrationBuilder.DropColumn(
                name: "BILDIRIMTURUID",
                table: "MPIRSALIYE");
        }
    }
}
