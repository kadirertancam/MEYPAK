using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKDuzeleme5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SEVKEMRIHARID",
                table: "MPSTOKSEVKİYATLİST",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MPSTOKSEVKİYATLİST_SEVKEMRIHARID",
                table: "MPSTOKSEVKİYATLİST",
                column: "SEVKEMRIHARID");

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKSEVKİYATLİST_MPSIPARISSEVKEMRIHAR_SEVKEMRIHARID",
                table: "MPSTOKSEVKİYATLİST",
                column: "SEVKEMRIHARID",
                principalTable: "MPSIPARISSEVKEMRIHAR",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKSEVKİYATLİST_MPSIPARISSEVKEMRIHAR_SEVKEMRIHARID",
                table: "MPSTOKSEVKİYATLİST");

            migrationBuilder.DropIndex(
                name: "IX_MPSTOKSEVKİYATLİST_SEVKEMRIHARID",
                table: "MPSTOKSEVKİYATLİST");

            migrationBuilder.DropColumn(
                name: "SEVKEMRIHARID",
                table: "MPSTOKSEVKİYATLİST");
        }
    }
}
