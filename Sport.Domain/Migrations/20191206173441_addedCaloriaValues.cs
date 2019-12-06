using Microsoft.EntityFrameworkCore.Migrations;

namespace Sport.Domain.Migrations
{
    public partial class addedCaloriaValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThatDays_NutritionDays_FKDayId",
                table: "ThatDays");

            migrationBuilder.DropIndex(
                name: "IX_ThatDays_FKDayId",
                table: "ThatDays");

            migrationBuilder.DropColumn(
                name: "FKDayId",
                table: "ThatDays");

            migrationBuilder.AddColumn<int>(
                name: "FKNutritionDayId",
                table: "ThatDays",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "NutritionLists",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<double>(
                name: "TotalCaloriValue",
                table: "NutritionLists",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CaloriValue",
                table: "Foods",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_ThatDays_FKNutritionDayId",
                table: "ThatDays",
                column: "FKNutritionDayId");

            migrationBuilder.AddForeignKey(
                name: "FK_ThatDays_NutritionDays_FKNutritionDayId",
                table: "ThatDays",
                column: "FKNutritionDayId",
                principalTable: "NutritionDays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThatDays_NutritionDays_FKNutritionDayId",
                table: "ThatDays");

            migrationBuilder.DropIndex(
                name: "IX_ThatDays_FKNutritionDayId",
                table: "ThatDays");

            migrationBuilder.DropColumn(
                name: "FKNutritionDayId",
                table: "ThatDays");

            migrationBuilder.DropColumn(
                name: "TotalCaloriValue",
                table: "NutritionLists");

            migrationBuilder.DropColumn(
                name: "CaloriValue",
                table: "Foods");

            migrationBuilder.AddColumn<int>(
                name: "FKDayId",
                table: "ThatDays",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "NutritionLists",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ThatDays_FKDayId",
                table: "ThatDays",
                column: "FKDayId");

            migrationBuilder.AddForeignKey(
                name: "FK_ThatDays_NutritionDays_FKDayId",
                table: "ThatDays",
                column: "FKDayId",
                principalTable: "NutritionDays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
