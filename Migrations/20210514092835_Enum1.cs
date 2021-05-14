using Microsoft.EntityFrameworkCore.Migrations;

namespace BP_Webshop.Migrations
{
    public partial class Enum1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RingType",
                table: "Rings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NecklaceType",
                table: "Necklaces",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HeadJewType",
                table: "HeadJewelries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EarringType",
                table: "Earrings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RingType",
                table: "Rings");

            migrationBuilder.DropColumn(
                name: "NecklaceType",
                table: "Necklaces");

            migrationBuilder.DropColumn(
                name: "HeadJewType",
                table: "HeadJewelries");

            migrationBuilder.DropColumn(
                name: "EarringType",
                table: "Earrings");
        }
    }
}
