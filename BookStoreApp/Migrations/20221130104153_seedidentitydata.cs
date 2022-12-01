using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VirginMegastoreApp.Migrations
{
    public partial class seedidentitydata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "06bf33f6-a357-4e06-ba96-a2423df97e1e", "0a8f4ba9-5f83-4a2b-aa84-8562ca517d1a", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7f638a0d-592b-4ed9-bfaf-25a32bcd330f", "4839a0f6-0942-47b8-84ed-fa3e163aaf89", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1d5189a3-bf38-4859-be69-ef4167259d2c", 0, "057ec276-b2eb-4633-8638-cea983ba55f4", "ApplicationUser", "admin@virginMegastore.com", false, "Admin", "User", false, null, null, "ADMIN@VIRGINMEGASTORE.COM", "AQAAAAEAACcQAAAAECWGmsdu45wMS+hCT94B7AfYnPgzWyhjy06ZqBrvDsCAAUILeT3IIwWHMWn3oVIA1Q==", null, false, "31b551c0-137d-4035-a6bf-81a7d10e7071", false, "admin@virginMegastore.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "06bf33f6-a357-4e06-ba96-a2423df97e1e", "1d5189a3-bf38-4859-be69-ef4167259d2c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f638a0d-592b-4ed9-bfaf-25a32bcd330f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "06bf33f6-a357-4e06-ba96-a2423df97e1e", "1d5189a3-bf38-4859-be69-ef4167259d2c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06bf33f6-a357-4e06-ba96-a2423df97e1e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d5189a3-bf38-4859-be69-ef4167259d2c");
        }
    }
}
