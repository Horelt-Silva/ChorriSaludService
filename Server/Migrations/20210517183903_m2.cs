using Microsoft.EntityFrameworkCore.Migrations;

namespace ChorriSaludService.Server.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RoleModel_Id",
                table: "User",
                newName: "Roles_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Roles_Id",
                table: "User",
                newName: "RoleModel_Id");
        }
    }
}
