using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryMangementSystem.Migrations
{
    /// <inheritdoc />
    public partial class editModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ChangeType",
                table: "StockLevels",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Categories",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "ChangeType",
                table: "StockLevels",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df93bcba-9481-4e7c-a658-319566ff402f", "AQAAAAIAAYagAAAAEFPDQifG1gMNi2JXrLH6gKfaiRDy59q4UTCgTAV90ehwqM2tZvn1nWx4eBDMRWGy0g==", "48827c2f-e34d-4ed6-99bd-305c046a0397" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b7ad8b6-f40a-4cc9-9fc4-5c32fda24ff8", "AQAAAAIAAYagAAAAEKPI6LeJ4l3mf+z9OJFt8aKVBCFFdIhpnfznVtEHHH3w7GVVx1KL4/GvnlRVAB4iwA==", "8350f6af-b5fb-49d9-af7f-8a4245e04490" });
        }
    }
}
