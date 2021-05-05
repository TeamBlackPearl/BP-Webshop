using Microsoft.EntityFrameworkCore.Migrations;

namespace BP_Webshop.Migrations
{
    public partial class deletejewelries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Jewelries",
                table: "Jewelries");

            migrationBuilder.DropColumn(
                name: "BraceletLength",
                table: "Jewelries");

            migrationBuilder.DropColumn(
                name: "BraceletWidth",
                table: "Jewelries");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Jewelries");

            migrationBuilder.DropColumn(
                name: "EarringLength",
                table: "Jewelries");

            migrationBuilder.DropColumn(
                name: "HeadJewelrySize",
                table: "Jewelries");

            migrationBuilder.DropColumn(
                name: "NecklaceLength",
                table: "Jewelries");

            migrationBuilder.DropColumn(
                name: "NecklaceWidth",
                table: "Jewelries");

            migrationBuilder.RenameTable(
                name: "Jewelries",
                newName: "Rings");

            migrationBuilder.AlterColumn<double>(
                name: "RingWidth",
                table: "Rings",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RingSize",
                table: "Rings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rings",
                table: "Rings",
                column: "JewelryID");

            migrationBuilder.CreateTable(
                name: "Bracelets",
                columns: table => new
                {
                    JewelryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BraceletLength = table.Column<double>(type: "float", nullable: false),
                    BraceletWidth = table.Column<double>(type: "float", nullable: false),
                    JewelryTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AverageRating = table.Column<double>(type: "float", nullable: false),
                    ImageLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bracelets", x => x.JewelryID);
                });

            migrationBuilder.CreateTable(
                name: "Earrings",
                columns: table => new
                {
                    JewelryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EarringLength = table.Column<double>(type: "float", nullable: false),
                    JewelryTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AverageRating = table.Column<double>(type: "float", nullable: false),
                    ImageLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Earrings", x => x.JewelryID);
                });

            migrationBuilder.CreateTable(
                name: "HeadJewelries",
                columns: table => new
                {
                    JewelryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadJewelrySize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JewelryTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AverageRating = table.Column<double>(type: "float", nullable: false),
                    ImageLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeadJewelries", x => x.JewelryID);
                });

            migrationBuilder.CreateTable(
                name: "Necklaces",
                columns: table => new
                {
                    JewelryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NecklaceLength = table.Column<double>(type: "float", nullable: false),
                    NecklaceWidth = table.Column<double>(type: "float", nullable: false),
                    JewelryTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AverageRating = table.Column<double>(type: "float", nullable: false),
                    ImageLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Necklaces", x => x.JewelryID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bracelets");

            migrationBuilder.DropTable(
                name: "Earrings");

            migrationBuilder.DropTable(
                name: "HeadJewelries");

            migrationBuilder.DropTable(
                name: "Necklaces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rings",
                table: "Rings");

            migrationBuilder.RenameTable(
                name: "Rings",
                newName: "Jewelries");

            migrationBuilder.AlterColumn<double>(
                name: "RingWidth",
                table: "Jewelries",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "RingSize",
                table: "Jewelries",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<double>(
                name: "BraceletLength",
                table: "Jewelries",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "BraceletWidth",
                table: "Jewelries",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Jewelries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "EarringLength",
                table: "Jewelries",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeadJewelrySize",
                table: "Jewelries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "NecklaceLength",
                table: "Jewelries",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "NecklaceWidth",
                table: "Jewelries",
                type: "float",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jewelries",
                table: "Jewelries",
                column: "JewelryID");
        }
    }
}
