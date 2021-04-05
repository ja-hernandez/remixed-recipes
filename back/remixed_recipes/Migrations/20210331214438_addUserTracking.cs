using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace remixed_recipes.Migrations
{
    public partial class addUserTracking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Recipes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CreatedById",
                table: "Recipes",
                column: "CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Accounts_CreatedById",
                table: "Recipes",
                column: "CreatedById",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Accounts_CreatedById",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_CreatedById",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Recipes");
        }
    }
}
