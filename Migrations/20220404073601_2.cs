using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rpg2.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "requestnumber",
                table: "UserData",
                newName: "RequestNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RequestNumber",
                table: "UserData",
                newName: "requestnumber");
        }
    }
}
