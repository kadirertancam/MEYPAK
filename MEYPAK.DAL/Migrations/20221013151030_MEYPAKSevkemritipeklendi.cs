using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKSevkemritipeklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPKASA");

            migrationBuilder.AddColumn<int>(
                name: "TIP",
                table: "MPSIPARISSEVKEMRIHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "STOKID",
                table: "MPDEPOTRANSFERHAR",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OLUSTURMATARIHI",
                table: "MPDEPOTRANSFERHAR",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<int>(
                name: "MIKTAR",
                table: "MPDEPOTRANSFERHAR",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "GUNCELLEMETARIHI",
                table: "MPDEPOTRANSFERHAR",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<byte>(
                name: "DURUM",
                table: "MPDEPOTRANSFERHAR",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint")
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<string>(
                name: "DONEM",
                table: "MPDEPOTRANSFERHAR",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<int>(
                name: "DEPOTRANSFERID",
                table: "MPDEPOTRANSFERHAR",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<string>(
                name: "ACIKLAMA",
                table: "MPDEPOTRANSFERHAR",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "MPDEPOTRANSFERHAR",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 1)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OLUSTURMATARIHI",
                table: "MPDEPOTRANSFER",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<int>(
                name: "HEDEFDEPOID",
                table: "MPDEPOTRANSFER",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "GUNCELLEMETARIHI",
                table: "MPDEPOTRANSFER",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<byte>(
                name: "DURUM",
                table: "MPDEPOTRANSFER",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint")
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<string>(
                name: "DONEM",
                table: "MPDEPOTRANSFER",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "CIKTIDEPOID",
                table: "MPDEPOTRANSFER",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "MPDEPOTRANSFER",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 1)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "SIRKETID",
                table: "MPDEPO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OLUSTURMATARIHI",
                table: "MPDEPO",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "GUNCELLEMETARIHI",
                table: "MPDEPO",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<string>(
                name: "DEPOKODU",
                table: "MPDEPO",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<string>(
                name: "DEPOADI",
                table: "MPDEPO",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<string>(
                name: "ACIKLAMA",
                table: "MPDEPO",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "MPDEPO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 1)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateTable(
                name: "MPSTOKKASA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SIRKETID = table.Column<int>(type: "int", nullable: false),
                    SUBEID = table.Column<int>(type: "int", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KASAKODU = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KASAADI = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AKTIF = table.Column<byte>(type: "tinyint", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPSTOKKASA", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPSTOKKASA");

            migrationBuilder.DropColumn(
                name: "TIP",
                table: "MPSIPARISSEVKEMRIHAR");

            migrationBuilder.AlterColumn<int>(
                name: "STOKID",
                table: "MPDEPOTRANSFERHAR",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OLUSTURMATARIHI",
                table: "MPDEPOTRANSFERHAR",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<int>(
                name: "MIKTAR",
                table: "MPDEPOTRANSFERHAR",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "GUNCELLEMETARIHI",
                table: "MPDEPOTRANSFERHAR",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<byte>(
                name: "DURUM",
                table: "MPDEPOTRANSFERHAR",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint")
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<string>(
                name: "DONEM",
                table: "MPDEPOTRANSFERHAR",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<int>(
                name: "DEPOTRANSFERID",
                table: "MPDEPOTRANSFERHAR",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<string>(
                name: "ACIKLAMA",
                table: "MPDEPOTRANSFERHAR",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "MPDEPOTRANSFERHAR",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 1)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OLUSTURMATARIHI",
                table: "MPDEPOTRANSFER",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<int>(
                name: "HEDEFDEPOID",
                table: "MPDEPOTRANSFER",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "GUNCELLEMETARIHI",
                table: "MPDEPOTRANSFER",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<byte>(
                name: "DURUM",
                table: "MPDEPOTRANSFER",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint")
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<string>(
                name: "DONEM",
                table: "MPDEPOTRANSFER",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "CIKTIDEPOID",
                table: "MPDEPOTRANSFER",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "MPDEPOTRANSFER",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 1)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "SIRKETID",
                table: "MPDEPO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OLUSTURMATARIHI",
                table: "MPDEPO",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "GUNCELLEMETARIHI",
                table: "MPDEPO",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<string>(
                name: "DEPOKODU",
                table: "MPDEPO",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100)
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<string>(
                name: "DEPOADI",
                table: "MPDEPO",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<string>(
                name: "ACIKLAMA",
                table: "MPDEPO",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "MPDEPO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 1)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateTable(
                name: "MPKASA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ACIKLAMA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AKTIF = table.Column<byte>(type: "tinyint", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KASAADI = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KASAKODU = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SIRKETID = table.Column<int>(type: "int", nullable: false),
                    SUBEID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPKASA", x => x.ID);
                });
        }
    }
}
