using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopItemApi.Migrations
{
    public partial class CreatedBY : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "ShopItems",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "ShopItems");
        }
    }
}
