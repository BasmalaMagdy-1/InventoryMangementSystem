using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryMangementSystem.Migrations
{
    /// <inheritdoc />
    public partial class updatestockleveltable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ChangeType",
                table: "StockLevels",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a51a2b6a-2c43-4c4a-8108-c285f917f7ce", "AQAAAAIAAYagAAAAEM11e8naQShb/6uZLH1nfIW9YYq/RKjncFPJejFBqs+9d44AWyL+HFrfb8HhxI4AJg==", "5641c2c2-61ab-43d3-9430-41852805ce4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3ee9dc4-6c86-4f9f-8062-2137f00f34a7", "AQAAAAIAAYagAAAAEONAO0J80x3l3SbMZuYKDw2C8Gezw49kc8gD+8egFysRC9ZJoaE6zmFZlzui7pA14w==", "af6ea722-becd-43cb-8c3e-a09654c76801" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ChangeType",
                table: "StockLevels",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b340f0e-a703-4d3a-9428-d704dfd2859f", "AQAAAAIAAYagAAAAEGJi4+BgARC16g7ypt5v5TeCEER/rJsxooDZhgxJt1iH9TXQUCR2h7mOzKnJYd/75Q==", "850cd6fc-0fcb-4623-8b8e-364e2218a001" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e452297-777b-402c-84b0-074625e51479", "AQAAAAIAAYagAAAAEE2JcnLi+MVP4Ir7e7EZQtyhtDr46sdFHdB5Zzf76WNVVUY+Th9b/XUIePIuStibCw==", "e1833163-a673-4d04-94b2-8491e203b920" });
        }
    }
}
