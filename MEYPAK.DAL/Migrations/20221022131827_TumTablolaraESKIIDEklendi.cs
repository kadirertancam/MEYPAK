using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class TumTablolaraESKIIDEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KULLANICIID",
                table: "MPSTOKMALKABULLIST",
                newName: "ESKIID");

            migrationBuilder.AddColumn<int>(
                name: "ESKIID",
                table: "MPSTOKSEVKİYATLİST",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "GUNCELLEMETARIHI",
                table: "MPSTOKSEVKİYATLİST",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<byte>(
                name: "KAYITTIPI",
                table: "MPSTOKSEVKİYATLİST",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "OLUSTURMATARIHI",
                table: "MPSTOKSEVKİYATLİST",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ESKIID",
                table: "MPSTOKSAYIMHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ESKIID",
                table: "MPSTOKSAYIM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ESKIID",
                table: "MPSTOKOLCUBR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "GUNCELLEMETARIHI",
                table: "MPSTOKMALKABULLIST",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<byte>(
                name: "KAYITTIPI",
                table: "MPSTOKMALKABULLIST",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "OLUSTURMATARIHI",
                table: "MPSTOKMALKABULLIST",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ESKIID",
                table: "MPSTOKKATEGORI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "GUNCELLEMETARIHI",
                table: "MPSTOKKATEGORI",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "OLUSTURMATARIHI",
                table: "MPSTOKKATEGORI",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ESKIID",
                table: "MPSTOKKASA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ESKIID",
                table: "MPSTOKHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ESKIID",
                table: "MPSTOKFIYATLISTHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ESKIID",
                table: "MPSTOKFIYATLIST",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ESKIID",
                table: "MPSTOK",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ESKIID",
                table: "MPSIPARISSEVKEMRIHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "GUNCELLEMETARIHI",
                table: "MPSIPARISSEVKEMRIHAR",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<byte>(
                name: "KAYITTIPI",
                table: "MPSIPARISSEVKEMRIHAR",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "OLUSTURMATARIHI",
                table: "MPSIPARISSEVKEMRIHAR",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ESKIID",
                table: "MPSIPARISDETAY",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ESKIID",
                table: "MPSIPARIS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ESKIID",
                table: "MPPERSONEL",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "GUNCELLEMETARIHI",
                table: "MPPERSONEL",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "OLUSTURMATARIHI",
                table: "MPPERSONEL",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ESKIID",
                table: "MPOLCUBR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ESKIID",
                table: "MPMARKA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ESKIID",
                table: "MPIRSALIYEDETAY",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ESKIID",
                table: "MPIRSALIYE",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ESKIID",
                table: "MPHIZMET",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ESKIID",
                table: "MPDEPOTRANSFERHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ESKIID",
                table: "MPDEPOTRANSFER",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ESKIID",
                table: "MPDEPOEMIR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "GUNCELLEMETARIHI",
                table: "MPDEPOEMIR",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<byte>(
                name: "KAYITTIPI",
                table: "MPDEPOEMIR",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "OLUSTURMATARIHI",
                table: "MPDEPOEMIR",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<byte>(
                name: "KAYITTIPI",
                table: "MPDEPOCEKILIST",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ESKIID",
                table: "MPDEPOCEKILIST",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ESKIID",
                table: "MPDEPO",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ESKIID",
                table: "MPSTOKSEVKİYATLİST");

            migrationBuilder.DropColumn(
                name: "GUNCELLEMETARIHI",
                table: "MPSTOKSEVKİYATLİST");

            migrationBuilder.DropColumn(
                name: "KAYITTIPI",
                table: "MPSTOKSEVKİYATLİST");

            migrationBuilder.DropColumn(
                name: "OLUSTURMATARIHI",
                table: "MPSTOKSEVKİYATLİST");

            migrationBuilder.DropColumn(
                name: "ESKIID",
                table: "MPSTOKSAYIMHAR");

            migrationBuilder.DropColumn(
                name: "ESKIID",
                table: "MPSTOKSAYIM");

            migrationBuilder.DropColumn(
                name: "ESKIID",
                table: "MPSTOKOLCUBR");

            migrationBuilder.DropColumn(
                name: "GUNCELLEMETARIHI",
                table: "MPSTOKMALKABULLIST");

            migrationBuilder.DropColumn(
                name: "KAYITTIPI",
                table: "MPSTOKMALKABULLIST");

            migrationBuilder.DropColumn(
                name: "OLUSTURMATARIHI",
                table: "MPSTOKMALKABULLIST");

            migrationBuilder.DropColumn(
                name: "ESKIID",
                table: "MPSTOKKATEGORI");

            migrationBuilder.DropColumn(
                name: "GUNCELLEMETARIHI",
                table: "MPSTOKKATEGORI");

            migrationBuilder.DropColumn(
                name: "OLUSTURMATARIHI",
                table: "MPSTOKKATEGORI");

            migrationBuilder.DropColumn(
                name: "ESKIID",
                table: "MPSTOKKASA");

            migrationBuilder.DropColumn(
                name: "ESKIID",
                table: "MPSTOKHAR");

            migrationBuilder.DropColumn(
                name: "ESKIID",
                table: "MPSTOKFIYATLISTHAR");

            migrationBuilder.DropColumn(
                name: "ESKIID",
                table: "MPSTOKFIYATLIST");

            migrationBuilder.DropColumn(
                name: "ESKIID",
                table: "MPSTOK");

            migrationBuilder.DropColumn(
                name: "ESKIID",
                table: "MPSIPARISSEVKEMRIHAR");

            migrationBuilder.DropColumn(
                name: "GUNCELLEMETARIHI",
                table: "MPSIPARISSEVKEMRIHAR");

            migrationBuilder.DropColumn(
                name: "KAYITTIPI",
                table: "MPSIPARISSEVKEMRIHAR");

            migrationBuilder.DropColumn(
                name: "OLUSTURMATARIHI",
                table: "MPSIPARISSEVKEMRIHAR");

            migrationBuilder.DropColumn(
                name: "ESKIID",
                table: "MPSIPARISDETAY");

            migrationBuilder.DropColumn(
                name: "ESKIID",
                table: "MPSIPARIS");

            migrationBuilder.DropColumn(
                name: "ESKIID",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "GUNCELLEMETARIHI",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "OLUSTURMATARIHI",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "ESKIID",
                table: "MPOLCUBR");

            migrationBuilder.DropColumn(
                name: "ESKIID",
                table: "MPMARKA");

            migrationBuilder.DropColumn(
                name: "ESKIID",
                table: "MPIRSALIYEDETAY");

            migrationBuilder.DropColumn(
                name: "ESKIID",
                table: "MPIRSALIYE");

            migrationBuilder.DropColumn(
                name: "ESKIID",
                table: "MPHIZMET");

            migrationBuilder.DropColumn(
                name: "ESKIID",
                table: "MPDEPOTRANSFERHAR");

            migrationBuilder.DropColumn(
                name: "ESKIID",
                table: "MPDEPOTRANSFER");

            migrationBuilder.DropColumn(
                name: "ESKIID",
                table: "MPDEPOEMIR");

            migrationBuilder.DropColumn(
                name: "GUNCELLEMETARIHI",
                table: "MPDEPOEMIR");

            migrationBuilder.DropColumn(
                name: "KAYITTIPI",
                table: "MPDEPOEMIR");

            migrationBuilder.DropColumn(
                name: "OLUSTURMATARIHI",
                table: "MPDEPOEMIR");

            migrationBuilder.DropColumn(
                name: "ESKIID",
                table: "MPDEPOCEKILIST");

            migrationBuilder.DropColumn(
                name: "ESKIID",
                table: "MPDEPO");

            migrationBuilder.RenameColumn(
                name: "ESKIID",
                table: "MPSTOKMALKABULLIST",
                newName: "KULLANICIID");

            migrationBuilder.AlterColumn<int>(
                name: "KAYITTIPI",
                table: "MPDEPOCEKILIST",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");
        }
    }
}
