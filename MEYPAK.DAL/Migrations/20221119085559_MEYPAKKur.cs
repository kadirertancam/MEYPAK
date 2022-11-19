using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKKur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DOVIZALIS",
                table: "MPPARABIRIM",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DOVIZEFEKTIFALIS",
                table: "MPPARABIRIM",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DOVIZEFEKTIFSATIS",
                table: "MPPARABIRIM",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DOVIZSATIS",
                table: "MPPARABIRIM",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DOVIZALIS",
                table: "MPPARABIRIM");

            migrationBuilder.DropColumn(
                name: "DOVIZEFEKTIFALIS",
                table: "MPPARABIRIM");

            migrationBuilder.DropColumn(
                name: "DOVIZEFEKTIFSATIS",
                table: "MPPARABIRIM");

            migrationBuilder.DropColumn(
                name: "DOVIZSATIS",
                table: "MPPARABIRIM");
        }
    }
}
