using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EKart.Infrastructure.Migrations
{
    public partial class RemovedRoleCol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19131fc6-5ec1-4f47-b1da-3b4e19c8263f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68dfe100-656f-48a7-be78-3a309986dfb0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af6eae62-a3a1-4dd3-9874-f37f07942991");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "984fb6c5-648e-4b3a-b9b9-f331b53a9bfa", "1", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a820ed75-79a0-4892-8c84-eb27c15ba766", "2", "Seller", "Seller" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b55e1f01-ec3b-4b9b-938d-a2daa7acd73e", "3", "Buyer", "Buyer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "984fb6c5-648e-4b3a-b9b9-f331b53a9bfa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a820ed75-79a0-4892-8c84-eb27c15ba766");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b55e1f01-ec3b-4b9b-938d-a2daa7acd73e");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19131fc6-5ec1-4f47-b1da-3b4e19c8263f", "1", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "68dfe100-656f-48a7-be78-3a309986dfb0", "2", "Seller", "Seller" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "af6eae62-a3a1-4dd3-9874-f37f07942991", "3", "Buyer", "Buyer" });
        }
    }
}
