using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryMangementSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabaseSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockLevels_Products_productId",
                table: "StockLevels");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "StockLevels",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "changeType",
                table: "StockLevels",
                newName: "ChangeType");

            migrationBuilder.RenameColumn(
                name: "changeDate",
                table: "StockLevels",
                newName: "ChangeDate");

            migrationBuilder.RenameIndex(
                name: "IX_StockLevels_productId",
                table: "StockLevels",
                newName: "IX_StockLevels_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockLevels_Products_ProductId",
                table: "StockLevels",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockLevels_Products_ProductId",
                table: "StockLevels");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "StockLevels",
                newName: "productId");

            migrationBuilder.RenameColumn(
                name: "ChangeType",
                table: "StockLevels",
                newName: "changeType");

            migrationBuilder.RenameColumn(
                name: "ChangeDate",
                table: "StockLevels",
                newName: "changeDate");

            migrationBuilder.RenameIndex(
                name: "IX_StockLevels_ProductId",
                table: "StockLevels",
                newName: "IX_StockLevels_productId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockLevels_Products_productId",
                table: "StockLevels",
                column: "productId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
