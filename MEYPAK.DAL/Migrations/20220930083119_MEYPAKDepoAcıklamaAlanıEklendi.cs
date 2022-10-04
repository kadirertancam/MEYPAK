using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKDepoAcıklamaAlanıEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ACIKLAMA",
                table: "MPDEPO",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 7);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ACIKLAMA",
                table: "MPDEPO");
        }
    }
}
