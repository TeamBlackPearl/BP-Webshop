using Microsoft.EntityFrameworkCore.Migrations;

namespace BP_Webshop.Migrations
{
    public partial class TestV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

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

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "Rings",
                newName: "Jewelries");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Tax",
                table: "Orders",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<double>(
                name: "RingWidth",
                table: "Jewelries",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "RingType",
                table: "Jewelries",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RingSize",
                table: "Jewelries",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Jewelries",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AddColumn<double>(
                name: "BraceletLength",
                table: "Jewelries",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BraceletType",
                table: "Jewelries",
                type: "int",
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

            migrationBuilder.AddColumn<int>(
                name: "EarringType",
                table: "Jewelries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HeadJewType",
                table: "Jewelries",
                type: "int",
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

            migrationBuilder.AddColumn<int>(
                name: "NecklaceType",
                table: "Jewelries",
                type: "int",
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

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_JewelryId",
                table: "OrderLines",
                column: "JewelryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_OrderId",
                table: "OrderLines",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLines_Jewelries_JewelryId",
                table: "OrderLines",
                column: "JewelryId",
                principalTable: "Jewelries",
                principalColumn: "JewelryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLines_Orders_OrderId",
                table: "OrderLines",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderLines_Jewelries_JewelryId",
                table: "OrderLines");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLines_Orders_OrderId",
                table: "OrderLines");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderLines_JewelryId",
                table: "OrderLines");

            migrationBuilder.DropIndex(
                name: "IX_OrderLines_OrderId",
                table: "OrderLines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jewelries",
                table: "Jewelries");

            migrationBuilder.DropColumn(
                name: "Tax",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "BraceletLength",
                table: "Jewelries");

            migrationBuilder.DropColumn(
                name: "BraceletType",
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
                name: "EarringType",
                table: "Jewelries");

            migrationBuilder.DropColumn(
                name: "HeadJewType",
                table: "Jewelries");

            migrationBuilder.DropColumn(
                name: "HeadJewelrySize",
                table: "Jewelries");

            migrationBuilder.DropColumn(
                name: "NecklaceLength",
                table: "Jewelries");

            migrationBuilder.DropColumn(
                name: "NecklaceType",
                table: "Jewelries");

            migrationBuilder.DropColumn(
                name: "NecklaceWidth",
                table: "Jewelries");

            migrationBuilder.RenameTable(
                name: "Jewelries",
                newName: "Rings");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "RingType",
                table: "Rings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
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

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Rings",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                    AverageRating = table.Column<double>(type: "float", nullable: false),
                    BraceletLength = table.Column<double>(type: "float", nullable: false),
                    BraceletType = table.Column<int>(type: "int", nullable: false),
                    BraceletWidth = table.Column<double>(type: "float", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ImageLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JewelryTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
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
                    AverageRating = table.Column<double>(type: "float", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    EarringLength = table.Column<double>(type: "float", nullable: false),
                    EarringType = table.Column<int>(type: "int", nullable: false),
                    ImageLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JewelryTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
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
                    AverageRating = table.Column<double>(type: "float", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    HeadJewType = table.Column<int>(type: "int", nullable: false),
                    HeadJewelrySize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JewelryTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
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
                    AverageRating = table.Column<double>(type: "float", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ImageLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JewelryTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NecklaceLength = table.Column<double>(type: "float", nullable: false),
                    NecklaceType = table.Column<int>(type: "int", nullable: false),
                    NecklaceWidth = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Necklaces", x => x.JewelryID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
