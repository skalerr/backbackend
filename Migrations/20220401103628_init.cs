using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rpg2.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    requestnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inputtel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inputname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inputemail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vmodelsumm = table.Column<int>(type: "int", nullable: true),
                    vmodelday = table.Column<int>(type: "int", nullable: true),
                    datenow = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserData");
        }
    }
}
