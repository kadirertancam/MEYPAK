using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class IRSALIYEDETAYduzenleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MIKTAR",
                table: "MPIRSALIYEDETAY",
                newName: "SAFI");

            migrationBuilder.RenameColumn(
                name: "ISTKONTO3",
                table: "MPIRSALIYEDETAY",
                newName: "KASAMIKTAR");

            migrationBuilder.RenameColumn(
                name: "ISTKONTO2",
                table: "MPIRSALIYEDETAY",
                newName: "ISKTOPLAM");

            migrationBuilder.RenameColumn(
                name: "ISTKONTO1",
                table: "MPIRSALIYEDETAY",
                newName: "ISKONTO3");

            migrationBuilder.AddColumn<decimal>(
                name: "BIRIMFIYAT",
                table: "MPIRSALIYEDETAY",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DARA",
                table: "MPIRSALIYEDETAY",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DARALI",
                table: "MPIRSALIYEDETAY",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ISKONTO1",
                table: "MPIRSALIYEDETAY",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ISKONTO2",
                table: "MPIRSALIYEDETAY",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ISTISNANO",
                table: "MPIRSALIYEDETAY",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NUM",
                table: "MPIRSALIYEDETAY",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TEVKIFATNO",
                table: "MPIRSALIYEDETAY",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BIRIMFIYAT",
                table: "MPIRSALIYEDETAY");

            migrationBuilder.DropColumn(
                name: "DARA",
                table: "MPIRSALIYEDETAY");

            migrationBuilder.DropColumn(
                name: "DARALI",
                table: "MPIRSALIYEDETAY");

            migrationBuilder.DropColumn(
                name: "ISKONTO1",
                table: "MPIRSALIYEDETAY");

            migrationBuilder.DropColumn(
                name: "ISKONTO2",
                table: "MPIRSALIYEDETAY");

            migrationBuilder.DropColumn(
                name: "ISTISNANO",
                table: "MPIRSALIYEDETAY");

            migrationBuilder.DropColumn(
                name: "NUM",
                table: "MPIRSALIYEDETAY");

            migrationBuilder.DropColumn(
                name: "TEVKIFATNO",
                table: "MPIRSALIYEDETAY");

            migrationBuilder.RenameColumn(
                name: "SAFI",
                table: "MPIRSALIYEDETAY",
                newName: "MIKTAR");

            migrationBuilder.RenameColumn(
                name: "KASAMIKTAR",
                table: "MPIRSALIYEDETAY",
                newName: "ISTKONTO3");

            migrationBuilder.RenameColumn(
                name: "ISKTOPLAM",
                table: "MPIRSALIYEDETAY",
                newName: "ISTKONTO2");

            migrationBuilder.RenameColumn(
                name: "ISKONTO3",
                table: "MPIRSALIYEDETAY",
                newName: "ISTKONTO1");
        }
    }
}
