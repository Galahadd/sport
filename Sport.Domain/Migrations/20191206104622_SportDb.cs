using Microsoft.EntityFrameworkCore.Migrations;

namespace Sport.Domain.Migrations
{
    public partial class SportDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ProteinValue = table.Column<double>(nullable: false),
                    CarbohydrateValue = table.Column<double>(nullable: false),
                    OilValue = table.Column<double>(nullable: false),
                    FiberValue = table.Column<double>(nullable: false),
                    FoodPhoto = table.Column<string>(nullable: true),
                    EnumFoodType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NutritionLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(nullable: false),
                    EnumNutritionType = table.Column<int>(nullable: false),
                    EnumNutritionKind = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SportLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EnumSportType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Password2 = table.Column<string>(nullable: true),
                    Size = table.Column<double>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    EnumGenderType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NutritionDays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FKNutritionListId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionDays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NutritionDays_NutritionLists_FKNutritionListId",
                        column: x => x.FKNutritionListId,
                        principalTable: "NutritionLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SportDays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FKSportListId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportDays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SportDays_SportLists_FKSportListId",
                        column: x => x.FKSportListId,
                        principalTable: "SportLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserNutritionLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FKUserId = table.Column<int>(nullable: false),
                    FKNutritionListId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNutritionLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserNutritionLists_NutritionLists_FKNutritionListId",
                        column: x => x.FKNutritionListId,
                        principalTable: "NutritionLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserNutritionLists_Users_FKUserId",
                        column: x => x.FKUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserSportLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FKUserId = table.Column<int>(nullable: false),
                    FKSportListId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSportLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSportLists_SportLists_FKSportListId",
                        column: x => x.FKSportListId,
                        principalTable: "SportLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserSportLists_Users_FKUserId",
                        column: x => x.FKUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ThatDays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FKDayId = table.Column<int>(nullable: false),
                    EnumMealType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThatDays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThatDays_NutritionDays_FKDayId",
                        column: x => x.FKDayId,
                        principalTable: "NutritionDays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FKDayId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Areas_SportDays_FKDayId",
                        column: x => x.FKDayId,
                        principalTable: "SportDays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MealFoods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FKFoodId = table.Column<int>(nullable: false),
                    FKThatDayId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealFoods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MealFoods_Foods_FKFoodId",
                        column: x => x.FKFoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MealFoods_ThatDays_FKThatDayId",
                        column: x => x.FKThatDayId,
                        principalTable: "ThatDays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Movements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovementName = table.Column<string>(nullable: true),
                    MovementPhoto = table.Column<string>(nullable: true),
                    MovementDescription = table.Column<string>(nullable: true),
                    FKAreaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movements_Areas_FKAreaId",
                        column: x => x.FKAreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AreaMovements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FKAreaId = table.Column<int>(nullable: false),
                    FKMovementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaMovements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AreaMovements_Areas_FKAreaId",
                        column: x => x.FKAreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AreaMovements_Movements_FKMovementId",
                        column: x => x.FKMovementId,
                        principalTable: "Movements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AreaMovements_FKAreaId",
                table: "AreaMovements",
                column: "FKAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_AreaMovements_FKMovementId",
                table: "AreaMovements",
                column: "FKMovementId");

            migrationBuilder.CreateIndex(
                name: "IX_Areas_FKDayId",
                table: "Areas",
                column: "FKDayId");

            migrationBuilder.CreateIndex(
                name: "IX_MealFoods_FKFoodId",
                table: "MealFoods",
                column: "FKFoodId");

            migrationBuilder.CreateIndex(
                name: "IX_MealFoods_FKThatDayId",
                table: "MealFoods",
                column: "FKThatDayId");

            migrationBuilder.CreateIndex(
                name: "IX_Movements_FKAreaId",
                table: "Movements",
                column: "FKAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_NutritionDays_FKNutritionListId",
                table: "NutritionDays",
                column: "FKNutritionListId");

            migrationBuilder.CreateIndex(
                name: "IX_SportDays_FKSportListId",
                table: "SportDays",
                column: "FKSportListId");

            migrationBuilder.CreateIndex(
                name: "IX_ThatDays_FKDayId",
                table: "ThatDays",
                column: "FKDayId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNutritionLists_FKNutritionListId",
                table: "UserNutritionLists",
                column: "FKNutritionListId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNutritionLists_FKUserId",
                table: "UserNutritionLists",
                column: "FKUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSportLists_FKSportListId",
                table: "UserSportLists",
                column: "FKSportListId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSportLists_FKUserId",
                table: "UserSportLists",
                column: "FKUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AreaMovements");

            migrationBuilder.DropTable(
                name: "MealFoods");

            migrationBuilder.DropTable(
                name: "UserNutritionLists");

            migrationBuilder.DropTable(
                name: "UserSportLists");

            migrationBuilder.DropTable(
                name: "Movements");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "ThatDays");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "NutritionDays");

            migrationBuilder.DropTable(
                name: "SportDays");

            migrationBuilder.DropTable(
                name: "NutritionLists");

            migrationBuilder.DropTable(
                name: "SportLists");
        }
    }
}
