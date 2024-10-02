using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryMangementSystem.Migrations
{
    /// <inheritdoc />
    public partial class EditSupplier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Suppliers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Suppliers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5213e784-4062-43e4-bbc9-c3017da48e48", "AQAAAAIAAYagAAAAEOL2ufNEPhQnWcDEzGADuZLdgpfRjN0AlXZj9lp9TkJlQpQNe0n2FV1LkgOOe1IvmQ==", "5f7054a5-fe4c-4390-8e8d-9c1c17180f32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35823b4a-2fc2-4e0d-ae82-6712f2ecc19c", "AQAAAAIAAYagAAAAEE0sxNum5mcR75bbWBL0O4UxyTpnSS92W+LXgyln92evA8RGigH/u7QqiWrjAqJWGg==", "d78a85bc-10e7-4e9d-8548-f1269ba1834c" });
        }
    }
}
