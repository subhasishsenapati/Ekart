using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EKart.Infrastructure.Migrations
{
    public partial class AddedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
