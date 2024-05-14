using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MainFarm.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "ItemFormat",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsedForFeeding = table.Column<int>(type: "int", nullable: false),
                    DateOfPurchase = table.Column<DateOnly>(type: "date", nullable: false),
                    WeightOfOne = table.Column<int>(type: "int", nullable: false),
                    TotalBags = table.Column<int>(type: "int", nullable: false),
                    TotalWeight = table.Column<int>(type: "int", nullable: false),
                    InventoryGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OtherInventoryStuffs = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemFormat", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_ItemFormat_Inventory_InventoryGuid",
                        column: x => x.InventoryGuid,
                        principalTable: "Inventory",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemFormat_InventoryGuid",
                table: "ItemFormat",
                column: "InventoryGuid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemFormat");

            migrationBuilder.DropTable(
                name: "Inventory");
        }
    }
}
