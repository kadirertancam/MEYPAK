using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MPFORMYETKIEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DEPOID",
                table: "MPSTOKKASAHAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "MIKTAR",
                table: "MPPERSONELAVANS",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "MPFORM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FORMADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false),
                    USERID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPFORM", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPFORMYETKI",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FORMID = table.Column<int>(type: "int", nullable: false),
                    GORUNTULE = table.Column<bool>(type: "bit", nullable: false),
                    EKLE = table.Column<bool>(type: "bit", nullable: false),
                    GUNCELLE = table.Column<bool>(type: "bit", nullable: false),
                    SIL = table.Column<bool>(type: "bit", nullable: false),
                    USERID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPFORMYETKI", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPKASAPARAMS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BELGENO = table.Column<long>(type: "bigint", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false),
                    USERID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPKASAPARAMS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPMUKELLEFLISTESI",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VKN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CARIADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false),
                    USERID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPMUKELLEFLISTESI", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MPPERSONELPARAMETRE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AVANSKATI = table.Column<int>(type: "int", nullable: false),
                    AVANSKATIrequired = table.Column<bool>(type: "bit", nullable: false),
                    AVANSMIKTAR = table.Column<int>(type: "int", nullable: false),
                    AVANSMIKTARrequired = table.Column<bool>(type: "bit", nullable: false),
                    OLUSTURMATARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GUNCELLEMETARIHI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAYITTIPI = table.Column<byte>(type: "tinyint", nullable: false),
                    ESKIID = table.Column<int>(type: "int", nullable: false),
                    USERID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPPERSONELPARAMETRE", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPFORM");

            migrationBuilder.DropTable(
                name: "MPFORMYETKI");

            migrationBuilder.DropTable(
                name: "MPKASAPARAMS");

            migrationBuilder.DropTable(
                name: "MPMUKELLEFLISTESI");

            migrationBuilder.DropTable(
                name: "MPPERSONELPARAMETRE");

            migrationBuilder.DropColumn(
                name: "DEPOID",
                table: "MPSTOKKASAHAR");

            migrationBuilder.AlterColumn<int>(
                name: "MIKTAR",
                table: "MPPERSONELAVANS",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
