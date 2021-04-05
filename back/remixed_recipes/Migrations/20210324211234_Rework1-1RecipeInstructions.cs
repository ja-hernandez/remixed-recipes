using Microsoft.EntityFrameworkCore.Migrations;

namespace remixed_recipes.Migrations
{
    public partial class Rework11RecipeInstructions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Instructions_InstructionsId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_InstructionsId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "InstructionsId",
                table: "Recipes");

            migrationBuilder.AddColumn<int>(
                name: "RecipeId",
                table: "Instructions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Instructions_RecipeId",
                table: "Instructions",
                column: "RecipeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructions_Recipes_RecipeId",
                table: "Instructions",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructions_Recipes_RecipeId",
                table: "Instructions");

            migrationBuilder.DropIndex(
                name: "IX_Instructions_RecipeId",
                table: "Instructions");

            migrationBuilder.DropColumn(
                name: "RecipeId",
                table: "Instructions");

            migrationBuilder.AddColumn<int>(
                name: "InstructionsId",
                table: "Recipes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_InstructionsId",
                table: "Recipes",
                column: "InstructionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Instructions_InstructionsId",
                table: "Recipes",
                column: "InstructionsId",
                principalTable: "Instructions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
