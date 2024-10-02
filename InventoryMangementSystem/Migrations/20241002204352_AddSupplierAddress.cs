using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryMangementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddSupplierAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Suppliers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Suppliers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30b4e865-abdb-4ff0-877b-2acde9c18cb5", "AQAAAAIAAYagAAAAEH/qKrjO0bufqbJlV1MyRiiSlRwIILZ5jPSHf63xeB0fNaOjvMX4NDNrw/MCXDIuUg==", "0d89003d-d1d5-43c2-979a-2cd968d8a6bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7df99209-fee9-4a3f-8ead-124e3ca5660f", "AQAAAAIAAYagAAAAEAUCLY1IyRVLYNVNCiQGROcR9znVdKdoO8bBF/h0xFcIAbcjX0lT93ZttRrlHwGSEg==", "ee399526-1d52-4e4c-a5d1-40fd1c46813a" });
        }
    }
}
