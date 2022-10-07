using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKKayitTipleriEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TIP",
                table: "MPSIPARIS",
                newName: "KAYITTIPI");

            migrationBuilder.AlterColumn<byte>(
                name: "KAYITTIPI",
                table: "MPSTOKSAYIMHAR",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "KAYITTIPI",
                table: "MPSTOKSAYIM",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "KAYITTIPI",
                table: "MPSTOKFIYATLISTHAR",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "KAYITTIPI",
                table: "MPSTOKFIYATLIST",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "KAYITTIPI",
                table: "MPPERSONEL",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "DURUM",
                table: "MPPERSONEL",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "KAYITTIPI",
                table: "MPOLCUBR",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "KAYITTIPI",
                table: "MPMARKA",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<byte>(
                name: "KAYITTIPI",
                table: "MPKATEGORI",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "KAYITTIPI",
                table: "MPHIZMET",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AlterColumn<byte>(
                name: "DURUM",
                table: "MPDEPOTRANSFERBILGI",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "DONEM",
                table: "MPDEPOTRANSFERBILGI",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AddColumn<string>(
                name: "ACIKLAMA",
                table: "MPDEPOTRANSFERBILGI",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<byte>(
                name: "DURUM",
                table: "MPDEPOTRANSFER",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<byte>(
                name: "KAYITTIPI",
                table: "MPDEPOTRANSFER",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KAYITTIPI",
                table: "MPKATEGORI");

            migrationBuilder.DropColumn(
                name: "KAYITTIPI",
                table: "MPHIZMET");

            migrationBuilder.DropColumn(
                name: "ACIKLAMA",
                table: "MPDEPOTRANSFERBILGI");

            migrationBuilder.DropColumn(
                name: "KAYITTIPI",
                table: "MPDEPOTRANSFER");

            migrationBuilder.RenameColumn(
                name: "KAYITTIPI",
                table: "MPSIPARIS",
                newName: "TIP");

            migrationBuilder.AlterColumn<int>(
                name: "KAYITTIPI",
                table: "MPSTOKSAYIMHAR",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<int>(
                name: "KAYITTIPI",
                table: "MPSTOKSAYIM",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<int>(
                name: "KAYITTIPI",
                table: "MPSTOKFIYATLISTHAR",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<int>(
                name: "KAYITTIPI",
                table: "MPSTOKFIYATLIST",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<int>(
                name: "KAYITTIPI",
                table: "MPPERSONEL",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<int>(
                name: "DURUM",
                table: "MPPERSONEL",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<int>(
                name: "KAYITTIPI",
                table: "MPOLCUBR",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<int>(
                name: "KAYITTIPI",
                table: "MPMARKA",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<int>(
                name: "DURUM",
                table: "MPDEPOTRANSFERBILGI",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<string>(
                name: "DONEM",
                table: "MPDEPOTRANSFERBILGI",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<int>(
                name: "DURUM",
                table: "MPDEPOTRANSFER",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");
        }
    }
}
