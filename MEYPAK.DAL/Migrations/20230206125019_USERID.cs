using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class USERID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPSTOKSEVKİYATLİST",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPSTOKSAYIMHAR",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPSTOKSAYIM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPSTOKSARFDETAY",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPSTOKSARF",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPSTOKRESIM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPSTOKOLCUBR",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPSTOKMARKA",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPSTOKMALKABULLIST",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPSTOKKATEGORI",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPSTOKKASAMARKA",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPSTOKKASAHAR",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPSTOKKASA",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPSTOKHAR",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPSTOKFIYATHAR",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPSTOKFIYAT",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPSTOK",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPSIPARISSEVKEMRIHAR",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPSIPARISKASAHAR",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPSIPARISDETAY",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPSIPARIS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPSEVKADRES",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPSERIHAR",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPSERI",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPSATINALMAMALKABULEMRIHAR",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPPERSONELZIMMET",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPPERSONELIZIN",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPPERSONELGOREV",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPPERSONELDEPARTMAN",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPPERSONELBANKA",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPPERSONELAVANS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SUBE",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPPARABIRIM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPOLCUBR",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPMUSTERISENETSB",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPMUSTERISENETNO",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPMUSTERISENETHAR",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPMUSTERICEKSENET",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPMUSTERICEKSB",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPMUSTERICEKNO",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPMUSTERICEKHAR",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPKREDIKART",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPKASAHAR",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPKASA",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPIRSALIYEDETAY",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPIRSALIYE",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPHIZMETKATEGORI",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPHIZMETHAR",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPHIZMET",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPHESAPHAREKET",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPFIRMASENETSB",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPFIRMASENETNO",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPFIRMASENETHAR",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPFIRMACEKSB",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPFIRMACEKNO",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPFIRMACEKHAR",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPFATURADETAY",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPFATURA",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPDEPOTRANSFERHAR",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPDEPOTRANSFER",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPDEPOEMIR",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPDEPOCEKILIST",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPDEPO",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPCEKSENETUSTSB",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPCARIYETKILI",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPCARIRESIM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPCARIKART",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPCARIHAR",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPCARIDOKUMAN",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPCARIALTHESCARI",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPCARIALTHES",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPBANKASUBE",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPBANKAHESAP",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPBANKA",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPARACSIGORTARESIM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPARACRUHSATRESIM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPARACROTA",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPARACRESIM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPARACMODEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPARACKASKORESIM",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "USERID",
                table: "MPARAC",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPSTOKSEVKİYATLİST");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPSTOKSAYIMHAR");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPSTOKSAYIM");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPSTOKSARFDETAY");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPSTOKSARF");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPSTOKRESIM");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPSTOKOLCUBR");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPSTOKMARKA");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPSTOKMALKABULLIST");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPSTOKKATEGORI");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPSTOKKASAMARKA");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPSTOKKASAHAR");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPSTOKKASA");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPSTOKHAR");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPSTOKFIYATHAR");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPSTOKFIYAT");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPSTOK");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPSIPARISSEVKEMRIHAR");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPSIPARISKASAHAR");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPSIPARISDETAY");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPSIPARIS");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPSEVKADRES");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPSERIHAR");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPSERI");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPSATINALMAMALKABULEMRIHAR");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPPERSONELZIMMET");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPPERSONELIZIN");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPPERSONELGOREV");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPPERSONELDEPARTMAN");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPPERSONELBANKA");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPPERSONELAVANS");

            migrationBuilder.DropColumn(
                name: "SUBE",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPPARABIRIM");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPOLCUBR");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPMUSTERISENETSB");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPMUSTERISENETNO");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPMUSTERISENETHAR");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPMUSTERICEKSENET");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPMUSTERICEKSB");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPMUSTERICEKNO");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPMUSTERICEKHAR");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPKREDIKART");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPKASAHAR");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPKASA");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPIRSALIYEDETAY");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPIRSALIYE");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPHIZMETKATEGORI");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPHIZMETHAR");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPHIZMET");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPHESAPHAREKET");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPFIRMASENETSB");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPFIRMASENETNO");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPFIRMASENETHAR");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPFIRMACEKSB");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPFIRMACEKNO");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPFIRMACEKHAR");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPFATURADETAY");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPFATURA");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPDEPOTRANSFERHAR");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPDEPOTRANSFER");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPDEPOEMIR");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPDEPOCEKILIST");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPDEPO");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPCEKSENETUSTSB");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPCARIYETKILI");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPCARIRESIM");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPCARIKART");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPCARIHAR");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPCARIDOKUMAN");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPCARIALTHESCARI");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPCARIALTHES");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPBANKASUBE");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPBANKAHESAP");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPBANKA");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPARACSIGORTARESIM");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPARACRUHSATRESIM");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPARACROTA");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPARACRESIM");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPARACMODEL");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPARACKASKORESIM");

            migrationBuilder.DropColumn(
                name: "USERID",
                table: "MPARAC");
        }
    }
}
