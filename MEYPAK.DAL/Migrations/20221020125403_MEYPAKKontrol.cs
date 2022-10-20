using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKKontrol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPDEPOEMIR_MPDEPO_DEPOID",
                table: "MPDEPOEMIR");

            migrationBuilder.DropForeignKey(
                name: "FK_MPDEPOEMIR_MPSIPARIS_SIPARISID",
                table: "MPDEPOEMIR");

            migrationBuilder.DropForeignKey(
                name: "FK_MPDEPOEMIRSIPARISKALEMILISKI_MPDEPOEMIR_DEPOEMIRID",
                table: "MPDEPOEMIRSIPARISKALEMILISKI");

            migrationBuilder.DropForeignKey(
                name: "FK_MPDEPOEMIRSIPARISKALEMILISKI_MPSIPARISDETAY_SIPARISDETAYID",
                table: "MPDEPOEMIRSIPARISKALEMILISKI");

            migrationBuilder.DropForeignKey(
                name: "FK_MPIRSALIYE_MPSIPARIS_SIPARISID",
                table: "MPIRSALIYE");

            migrationBuilder.DropForeignKey(
                name: "FK_MPIRSALIYESIPARISDETAYILISKI_MPIRSALIYEDETAY_IRSALIYEDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI");

            migrationBuilder.DropForeignKey(
                name: "FK_MPIRSALIYESIPARISDETAYILISKI_MPSIPARISDETAY_SIPARISDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI");
              
            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKMALKABULLIST_MPDEPOEMIR_EMIRID",
                table: "MPSTOKMALKABULLIST");

            migrationBuilder.DropForeignKey(
                name: "FK_MPSTOKMALKABULLIST_MPOLCUBR_BIRIMID",
                table: "MPSTOKMALKABULLIST");

            

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "MPIRSALIYESIPARISDETAYILISKI",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int") ;

            migrationBuilder.AddColumn<int>(
                name: "MPIRSALIYEDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MPSIPARISDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "MPDEPOEMIRSIPARISKALEMILISKI",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int") ;

            migrationBuilder.AddColumn<int>(
                name: "MPDEPOEMIRID",
                table: "MPDEPOEMIRSIPARISKALEMILISKI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MPSIPARISDETAYID",
                table: "MPDEPOEMIRSIPARISKALEMILISKI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MPIRSALIYESIPARISDETAYILISKI",
                table: "MPIRSALIYESIPARISDETAYILISKI",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MPDEPOEMIRSIPARISKALEMILISKI",
                table: "MPDEPOEMIRSIPARISKALEMILISKI",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_MPIRSALIYESIPARISDETAYILISKI_MPIRSALIYEDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI",
                column: "MPIRSALIYEDETAYID");

            migrationBuilder.CreateIndex(
                name: "IX_MPIRSALIYESIPARISDETAYILISKI_MPSIPARISDETAYID",
                table: "MPIRSALIYESIPARISDETAYILISKI",
                column: "MPSIPARISDETAYID");

            migrationBuilder.CreateIndex(
                name: "IX_MPDEPOEMIRSIPARISKALEMILISKI_MPDEPOEMIRID",
                table: "MPDEPOEMIRSIPARISKALEMILISKI",
                column: "MPDEPOEMIRID");

            migrationBuilder.CreateIndex(
                name: "IX_MPDEPOEMIRSIPARISKALEMILISKI_MPSIPARISDETAYID",
                table: "MPDEPOEMIRSIPARISKALEMILISKI",
                column: "MPSIPARISDETAYID");

            migrationBuilder.AddForeignKey(
                name: "FK_MPDEPOEMIR_MPDEPO_DEPOID",
                table: "MPDEPOEMIR",
                column: "DEPOID",
                principalTable: "MPDEPO",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MPDEPOEMIR_MPSIPARIS_SIPARISID",
                table: "MPDEPOEMIR",
                column: "SIPARISID",
                principalTable: "MPSIPARIS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade); 

            migrationBuilder.AddForeignKey(
                name: "FK_MPIRSALIYE_MPSIPARIS_SIPARISID",
                table: "MPIRSALIYE",
                column: "SIPARISID",
                principalTable: "MPSIPARIS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
             
               
            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKMALKABULLIST_MPDEPOEMIR_EMIRID",
                table: "MPSTOKMALKABULLIST",
                column: "EMIRID",
                principalTable: "MPDEPOEMIR",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKMALKABULLIST_MPOLCUBR_BIRIMID",
                table: "MPSTOKMALKABULLIST",
                column: "BIRIMID",
                principalTable: "MPOLCUBR",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKMALKABULLIST_MPSIPARISDETAY_SIPARISDETAYID",
                table: "MPSTOKMALKABULLIST",
                column: "SIPARISDETAYID",
                principalTable: "MPSIPARISDETAY",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKMALKABULLIST_MPSTOK_STOKID",
                table: "MPSTOKMALKABULLIST",
                column: "STOKID",
                principalTable: "MPSTOK",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKSEVKİYATLİST_MPSIPARISDETAY_SIPARISDETAYID",
                table: "MPSTOKSEVKİYATLİST",
                column: "SIPARISDETAYID",
                principalTable: "MPSIPARISDETAY",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MPSTOKSEVKİYATLİST_MPSIPARISSEVKEMRIHAR_SEVKEMRIHARID",
                table: "MPSTOKSEVKİYATLİST",
                column: "SEVKEMRIHARID",
                principalTable: "MPSIPARISSEVKEMRIHAR",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {


        }
    }
}
