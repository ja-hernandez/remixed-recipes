using Microsoft.EntityFrameworkCore.Migrations;

namespace remixed_recipes.Migrations
{
    public partial class imageRatings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Recipes",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Recipes");
        }
    }
}
