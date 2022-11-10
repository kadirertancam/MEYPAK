using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class PERSONELBANKAeklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ASKERLIK",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "EHLIYETNO",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "EMAIL",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "PSD",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "PSIKOTAR",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "SCR",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "SGKSICIL",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "TEL",
                table: "MPPERSONEL");

            migrationBuilder.RenameColumn(
                name: "DURUM",
                table: "MPPERSONEL",
                newName: "PANTOLONOLCUSU");

            migrationBuilder.RenameColumn(
                name: "DONEM",
                table: "MPPERSONEL",
                newName: "YASLILIKAYLIGI");

            migrationBuilder.AlterColumn<string>(
                name: "MEDENIDURUM",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "KANGRUBU",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "GOREVI",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ADRES",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<string>(
                name: "ADRESIL",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ADRESILCE",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ADRESMAH",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ADRESPOSTAKODU",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AILESIRANO",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ANNEADI",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ASKERLIKBASLANGICTAR",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ASKERLIKBITISTAR",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ASKERLIKDURUM",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "AYAKKABINO",
                table: "MPPERSONEL",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "BABAADI",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BAGKUR",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "BEDENOLCUSU",
                table: "MPPERSONEL",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "CEPNO",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "CINSIYET",
                table: "MPPERSONEL",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CİLTNO",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DEPARTMAN",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DOGUMYERI",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EMEKLISANDIGI",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EPOSTA",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "G506MADSAN",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GOREV",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GOREVKODU",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ILKSOYAD",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ISTIHDAMDURUMU",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MEZUNBOLUM",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MEZUNIYETYILI",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NUFUSAKAYITLIIL",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NUFUSAKAYITLIILCE",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NUFUSAKAYITLIMAH",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NUFUSCUZDANKAYITNO",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NUFUSCUZDANSERINO",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NUFUSCUZDANVERILISTARIH",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OGRENIMDURUMU",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SGKSICILNO",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SIGORTATURKOD",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SIRANO",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SOSYALGUVENLIKKODU",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TELEFON",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ULKE",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UYRUK",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VERGIDAIRESI",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VERGINO",
                table: "MPPERSONEL",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "AKTIF",
                table: "MPCARIALTHES",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.CreateTable(
                name: "MPPERSONELBANKA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PERSONELID = table.Column<int>(type: "int", nullable: false),
                    BANKAADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BANKASUBEKODU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BANKASUBEADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IBANNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPPERSONELBANKA", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPPERSONELBANKA");

            migrationBuilder.DropColumn(
                name: "ADRESIL",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "ADRESILCE",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "ADRESMAH",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "ADRESPOSTAKODU",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "AILESIRANO",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "ANNEADI",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "ASKERLIKBASLANGICTAR",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "ASKERLIKBITISTAR",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "ASKERLIKDURUM",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "AYAKKABINO",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "BABAADI",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "BAGKUR",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "BEDENOLCUSU",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "CEPNO",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "CINSIYET",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "CİLTNO",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "DEPARTMAN",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "DOGUMYERI",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "EMEKLISANDIGI",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "EPOSTA",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "G506MADSAN",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "GOREV",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "GOREVKODU",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "ILKSOYAD",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "ISTIHDAMDURUMU",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "MEZUNBOLUM",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "MEZUNIYETYILI",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "NUFUSAKAYITLIIL",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "NUFUSAKAYITLIILCE",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "NUFUSAKAYITLIMAH",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "NUFUSCUZDANKAYITNO",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "NUFUSCUZDANSERINO",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "NUFUSCUZDANVERILISTARIH",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "OGRENIMDURUMU",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "SGKSICILNO",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "SIGORTATURKOD",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "SIRANO",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "SOSYALGUVENLIKKODU",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "TELEFON",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "ULKE",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "UYRUK",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "VERGIDAIRESI",
                table: "MPPERSONEL");

            migrationBuilder.DropColumn(
                name: "VERGINO",
                table: "MPPERSONEL");

            migrationBuilder.RenameColumn(
                name: "YASLILIKAYLIGI",
                table: "MPPERSONEL",
                newName: "DONEM");

            migrationBuilder.RenameColumn(
                name: "PANTOLONOLCUSU",
                table: "MPPERSONEL",
                newName: "DURUM");

            migrationBuilder.AlterColumn<int>(
                name: "MEDENIDURUM",
                table: "MPPERSONEL",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "KANGRUBU",
                table: "MPPERSONEL",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "GOREVI",
                table: "MPPERSONEL",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ADRES",
                table: "MPPERSONEL",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ASKERLIK",
                table: "MPPERSONEL",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EHLIYETNO",
                table: "MPPERSONEL",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EMAIL",
                table: "MPPERSONEL",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PSD",
                table: "MPPERSONEL",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "PSIKOTAR",
                table: "MPPERSONEL",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SCR",
                table: "MPPERSONEL",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SGKSICIL",
                table: "MPPERSONEL",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TEL",
                table: "MPPERSONEL",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<byte>(
                name: "AKTIF",
                table: "MPCARIALTHES",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
