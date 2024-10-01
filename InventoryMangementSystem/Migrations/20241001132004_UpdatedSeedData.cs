using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryMangementSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "30b4e865-abdb-4ff0-877b-2acde9c18cb5", "STAFF", "AQAAAAIAAYagAAAAEH/qKrjO0bufqbJlV1MyRiiSlRwIILZ5jPSHf63xeB0fNaOjvMX4NDNrw/MCXDIuUg==", "0d89003d-d1d5-43c2-979a-2cd968d8a6bf", "staff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7df99209-fee9-4a3f-8ead-124e3ca5660f", "ADMIN", "AQAAAAIAAYagAAAAEAUCLY1IyRVLYNVNCiQGROcR9znVdKdoO8bBF/h0xFcIAbcjX0lT93ZttRrlHwGSEg==", "ee399526-1d52-4e4c-a5d1-40fd1c46813a", "Admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c80a57e9-f928-4c4f-8efa-9f9b523242ba", "STAFF@STAFF.COM", "AQAAAAIAAYagAAAAEFKjeEXzLZ+r3YsfmxkMGF9H4ptg2bgZa/X3D1yg9NsaAmy11h1mA+IbYjtTkrk7KQ==", "9842804f-29b9-4bcf-9313-403257c64185", "staff@staff.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "daf0f168-499c-4657-8187-490ab6f2affb", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEGEh7mwvfs4nenrTwXzH4NUn/QirdV15V5s49ky/9cPOn2BqOrYlnZ5+FaaTehwrkA==", "fe1f398a-e01b-41a7-aaa5-96ef6e935158", "admin@admin.com" });
        }
    }
}
