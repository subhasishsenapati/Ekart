using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EKart.Infrastructure.Migrations
{
    public partial class addedcol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSeller",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSeller",
                table: "AspNetUsers");
        }
    }
}
