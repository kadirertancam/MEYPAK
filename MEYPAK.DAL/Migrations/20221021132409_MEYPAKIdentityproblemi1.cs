using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MEYPAK.DAL.Migrations
{
    public partial class MEYPAKIdentityproblemi1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MPARACLAR",
                columns: table => new
                {
                    muId = table.Column<int>(type: "int", nullable: false),
                    companyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fleetId = table.Column<int>(type: "int", nullable: false),
                    fleetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    groupId = table.Column<int>(type: "int", nullable: false),
                    groupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    plate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    timezone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deviceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    canbusProfile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    networkId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hardwareVersion = table.Column<int>(type: "int", nullable: false),
                    softwareVersion = table.Column<int>(type: "int", nullable: false),
                    softwareSubVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPARACLAR", x => x.muId);
                });

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
