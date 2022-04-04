using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rpg2.Migrations
{
    public partial class _21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "vmodelsumm",
                table: "UserData",
                newName: "VmodelSumm");

            migrationBuilder.RenameColumn(
                name: "vmodelday",
                table: "UserData",
                newName: "VmodelDay");

            migrationBuilder.RenameColumn(
                name: "inputtel",
                table: "UserData",
                newName: "InputTel");

            migrationBuilder.RenameColumn(
                name: "inputname",
                table: "UserData",
                newName: "InputName");

            migrationBuilder.RenameColumn(
                name: "inputemail",
                table: "UserData",
                newName: "InputEmail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VmodelSumm",
                table: "UserData",
                newName: "vmodelsumm");

            migrationBuilder.RenameColumn(
                name: "VmodelDay",
                table: "UserData",
                newName: "vmodelday");

            migrationBuilder.RenameColumn(
                name: "InputTel",
                table: "UserData",
                newName: "inputtel");

            migrationBuilder.RenameColumn(
                name: "InputName",
                table: "UserData",
                newName: "inputname");

            migrationBuilder.RenameColumn(
                name: "InputEmail",
                table: "UserData",
                newName: "inputemail");
        }
    }
}
