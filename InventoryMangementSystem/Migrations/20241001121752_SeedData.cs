using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryMangementSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "540fa4db-060f-4f1b-b60a-dd199bfe4111", null, "Staff", "STAFF" },
                    { "540fa4db-060f-4f1b-b60a-dd199bfe4f0b", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "62fe5285-fd68-4711-ae93-673787f4a111", 0, null, "c80a57e9-f928-4c4f-8efa-9f9b523242ba", "staff@staff.com", true, false, null, "STAFF@STAFF.COM", "STAFF@STAFF.COM", "AQAAAAIAAYagAAAAEFKjeEXzLZ+r3YsfmxkMGF9H4ptg2bgZa/X3D1yg9NsaAmy11h1mA+IbYjtTkrk7KQ==", null, false, "9842804f-29b9-4bcf-9313-403257c64185", false, "staff@staff.com" },
                    { "62fe5285-fd68-4711-ae93-673787f4ac66", 0, null, "daf0f168-499c-4657-8187-490ab6f2affb", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEGEh7mwvfs4nenrTwXzH4NUn/QirdV15V5s49ky/9cPOn2BqOrYlnZ5+FaaTehwrkA==", null, false, "fe1f398a-e01b-41a7-aaa5-96ef6e935158", false, "admin@admin.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "540fa4db-060f-4f1b-b60a-dd199bfe4111", "62fe5285-fd68-4711-ae93-673787f4a111" },
                    { "540fa4db-060f-4f1b-b60a-dd199bfe4111", "62fe5285-fd68-4711-ae93-673787f4ac66" },
                    { "540fa4db-060f-4f1b-b60a-dd199bfe4f0b", "62fe5285-fd68-4711-ae93-673787f4ac66" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "540fa4db-060f-4f1b-b60a-dd199bfe4111", "62fe5285-fd68-4711-ae93-673787f4a111" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "540fa4db-060f-4f1b-b60a-dd199bfe4111", "62fe5285-fd68-4711-ae93-673787f4ac66" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "540fa4db-060f-4f1b-b60a-dd199bfe4f0b", "62fe5285-fd68-4711-ae93-673787f4ac66" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "540fa4db-060f-4f1b-b60a-dd199bfe4111");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "540fa4db-060f-4f1b-b60a-dd199bfe4f0b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66");
        }
    }
}
