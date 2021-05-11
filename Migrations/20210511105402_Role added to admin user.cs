using Microsoft.EntityFrameworkCore.Migrations;

namespace BP_Webshop.Migrations
{
    public partial class Roleaddedtoadminuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AdminUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "AdminUsers");
        }
    }
}
