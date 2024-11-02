using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EKart.Infrastructure.Migrations
{
    public partial class AddedRoleFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "498bf047-c1eb-4e36-820b-a99573b8c524");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0d5fa86-8795-437c-8059-8e5dd6d6aad3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4ff16dc-9708-4caa-9a70-b30d8388cc16");

            migrationBuilder.DropColumn(
                name: "IsSeller",
                table: "AspNetUsers");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsSeller",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "498bf047-c1eb-4e36-820b-a99573b8c524", "2", "Seller", "Seller" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c0d5fa86-8795-437c-8059-8e5dd6d6aad3", "3", "Buyer", "Buyer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d4ff16dc-9708-4caa-9a70-b30d8388cc16", "1", "Admin", "Admin" });
        }
    }
}
