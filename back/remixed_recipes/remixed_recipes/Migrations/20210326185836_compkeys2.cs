using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace remixed_recipes.Migrations
{
    public partial class compkeys2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_Ingredients_IngredientId1_IngredientName",
                table: "RecipeIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_Preparations_PreparationId1_PreparationDe~",
                table: "RecipeIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_Quantities_QuantityId1_QuantityName",
                table: "RecipeIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_Units_UnitId1_UnitName",
                table: "RecipeIngredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Units",
                table: "Units");

            migrationBuilder.DropIndex(
                name: "IX_RecipeIngredients_IngredientId1_IngredientName",
                table: "RecipeIngredients");

            migrationBuilder.DropIndex(
                name: "IX_RecipeIngredients_PreparationId1_PreparationDescription",
                table: "RecipeIngredients");

            migrationBuilder.DropIndex(
                name: "IX_RecipeIngredients_QuantityId1_QuantityName",
                table: "RecipeIngredients");

            migrationBuilder.DropIndex(
                name: "IX_RecipeIngredients_UnitId1_UnitName",
                table: "RecipeIngredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Quantities",
                table: "Quantities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Preparations",
                table: "Preparations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "IngredientId1",
                table: "RecipeIngredients");

            migrationBuilder.DropColumn(
                name: "IngredientName",
                table: "RecipeIngredients");

            migrationBuilder.DropColumn(
                name: "PreparationDescription",
                table: "RecipeIngredients");

            migrationBuilder.DropColumn(
                name: "PreparationId1",
                table: "RecipeIngredients");

            migrationBuilder.DropColumn(
                name: "QuantityId1",
                table: "RecipeIngredients");

            migrationBuilder.DropColumn(
                name: "QuantityName",
                table: "RecipeIngredients");

            migrationBuilder.DropColumn(
                name: "UnitId1",
                table: "RecipeIngredients");

            migrationBuilder.DropColumn(
                name: "UnitName",
                table: "RecipeIngredients");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Units",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Quantities",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Preparations",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Ingredients",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Units",
                table: "Units",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quantities",
                table: "Quantities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Preparations",
                table: "Preparations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_PreparationId",
                table: "RecipeIngredients",
                column: "PreparationId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_QuantityId",
                table: "RecipeIngredients",
                column: "QuantityId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_UnitId",
                table: "RecipeIngredients",
                column: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_Ingredients_IngredientId",
                table: "RecipeIngredients",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_Preparations_PreparationId",
                table: "RecipeIngredients",
                column: "PreparationId",
                principalTable: "Preparations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_Quantities_QuantityId",
                table: "RecipeIngredients",
                column: "QuantityId",
                principalTable: "Quantities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_Units_UnitId",
                table: "RecipeIngredients",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_Ingredients_IngredientId",
                table: "RecipeIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_Preparations_PreparationId",
                table: "RecipeIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_Quantities_QuantityId",
                table: "RecipeIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_Units_UnitId",
                table: "RecipeIngredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Units",
                table: "Units");

            migrationBuilder.DropIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients");

            migrationBuilder.DropIndex(
                name: "IX_RecipeIngredients_PreparationId",
                table: "RecipeIngredients");

            migrationBuilder.DropIndex(
                name: "IX_RecipeIngredients_QuantityId",
                table: "RecipeIngredients");

            migrationBuilder.DropIndex(
                name: "IX_RecipeIngredients_UnitId",
                table: "RecipeIngredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Quantities",
                table: "Quantities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Preparations",
                table: "Preparations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Units",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "IngredientId1",
                table: "RecipeIngredients",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "IngredientName",
                table: "RecipeIngredients",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PreparationDescription",
                table: "RecipeIngredients",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PreparationId1",
                table: "RecipeIngredients",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuantityId1",
                table: "RecipeIngredients",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "QuantityName",
                table: "RecipeIngredients",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UnitId1",
                table: "RecipeIngredients",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UnitName",
                table: "RecipeIngredients",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Quantities",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Preparations",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Ingredients",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Units",
                table: "Units",
                columns: new[] { "Id", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quantities",
                table: "Quantities",
                columns: new[] { "Id", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Preparations",
                table: "Preparations",
                columns: new[] { "Id", "Description" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients",
                columns: new[] { "Id", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientId1_IngredientName",
                table: "RecipeIngredients",
                columns: new[] { "IngredientId1", "IngredientName" });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_PreparationId1_PreparationDescription",
                table: "RecipeIngredients",
                columns: new[] { "PreparationId1", "PreparationDescription" });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_QuantityId1_QuantityName",
                table: "RecipeIngredients",
                columns: new[] { "QuantityId1", "QuantityName" });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_UnitId1_UnitName",
                table: "RecipeIngredients",
                columns: new[] { "UnitId1", "UnitName" });

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_Ingredients_IngredientId1_IngredientName",
                table: "RecipeIngredients",
                columns: new[] { "IngredientId1", "IngredientName" },
                principalTable: "Ingredients",
                principalColumns: new[] { "Id", "Name" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_Preparations_PreparationId1_PreparationDe~",
                table: "RecipeIngredients",
                columns: new[] { "PreparationId1", "PreparationDescription" },
                principalTable: "Preparations",
                principalColumns: new[] { "Id", "Description" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_Quantities_QuantityId1_QuantityName",
                table: "RecipeIngredients",
                columns: new[] { "QuantityId1", "QuantityName" },
                principalTable: "Quantities",
                principalColumns: new[] { "Id", "Name" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_Units_UnitId1_UnitName",
                table: "RecipeIngredients",
                columns: new[] { "UnitId1", "UnitName" },
                principalTable: "Units",
                principalColumns: new[] { "Id", "Name" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
