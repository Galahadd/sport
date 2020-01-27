﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sport.Domain;

namespace Sport.Domain.Migrations
{
    [DbContext(typeof(SportDatabaseContext))]
    partial class SportDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sport.Domain.Entities.Area", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FKDayId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FKDayId");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("Sport.Domain.Entities.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CaloriValue")
                        .HasColumnType("float");

                    b.Property<double>("CarbohydrateValue")
                        .HasColumnType("float");

                    b.Property<int>("EnumFoodType")
                        .HasColumnType("int");

                    b.Property<double>("FiberValue")
                        .HasColumnType("float");

                    b.Property<string>("FoodPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("OilValue")
                        .HasColumnType("float");

                    b.Property<double>("ProteinValue")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("Sport.Domain.Entities.MMRelation.AreaMovements", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FKAreaId")
                        .HasColumnType("int");

                    b.Property<int>("FKMovementId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FKAreaId");

                    b.HasIndex("FKMovementId");

                    b.ToTable("AreaMovements");
                });

            modelBuilder.Entity("Sport.Domain.Entities.MMRelation.MealFoods", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FKFoodId")
                        .HasColumnType("int");

                    b.Property<int>("FKThatDayId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FKFoodId");

                    b.HasIndex("FKThatDayId");

                    b.ToTable("MealFoods");
                });

            modelBuilder.Entity("Sport.Domain.Entities.MMRelation.UserNutritionLists", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FKNutritionListId")
                        .HasColumnType("int");

                    b.Property<int>("FKUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FKNutritionListId");

                    b.HasIndex("FKUserId");

                    b.ToTable("UserNutritionLists");
                });

            modelBuilder.Entity("Sport.Domain.Entities.MMRelation.UserSportLists", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FKSportListId")
                        .HasColumnType("int");

                    b.Property<int>("FKUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FKSportListId");

                    b.HasIndex("FKUserId");

                    b.ToTable("UserSportLists");
                });

            modelBuilder.Entity("Sport.Domain.Entities.Movement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EnumMovementType")
                        .HasColumnType("int");

                    b.Property<string>("MovementDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovementName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovementPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movements");
                });

            modelBuilder.Entity("Sport.Domain.Entities.NutritionDay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FKNutritionListId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FKNutritionListId");

                    b.ToTable("NutritionDays");
                });

            modelBuilder.Entity("Sport.Domain.Entities.NutritionList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EnumNutritionKind")
                        .HasColumnType("int");

                    b.Property<int>("EnumNutritionType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalCaloriValue")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("NutritionLists");
                });

            modelBuilder.Entity("Sport.Domain.Entities.SportDay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FKSportListId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FKSportListId");

                    b.ToTable("SportDays");
                });

            modelBuilder.Entity("Sport.Domain.Entities.SportList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnumSportType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SportLists");
                });

            modelBuilder.Entity("Sport.Domain.Entities.ThatDay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EnumMealType")
                        .HasColumnType("int");

                    b.Property<int>("FKNutritionDayId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FKNutritionDayId");

                    b.ToTable("ThatDays");
                });

            modelBuilder.Entity("Sport.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnumGenderType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Sport.Domain.Entities.Area", b =>
                {
                    b.HasOne("Sport.Domain.Entities.SportDay", "SportDay")
                        .WithMany("Areas")
                        .HasForeignKey("FKDayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sport.Domain.Entities.MMRelation.AreaMovements", b =>
                {
                    b.HasOne("Sport.Domain.Entities.Area", "Area")
                        .WithMany("AreaMovements")
                        .HasForeignKey("FKAreaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Sport.Domain.Entities.Movement", "Movement")
                        .WithMany("AreaMovements")
                        .HasForeignKey("FKMovementId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Sport.Domain.Entities.MMRelation.MealFoods", b =>
                {
                    b.HasOne("Sport.Domain.Entities.Food", "Food")
                        .WithMany("MealsIncluded")
                        .HasForeignKey("FKFoodId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Sport.Domain.Entities.ThatDay", "ThatDay")
                        .WithMany("NutrientsInMeals")
                        .HasForeignKey("FKThatDayId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Sport.Domain.Entities.MMRelation.UserNutritionLists", b =>
                {
                    b.HasOne("Sport.Domain.Entities.NutritionList", "NutritionList")
                        .WithMany("UserNutritionLists")
                        .HasForeignKey("FKNutritionListId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Sport.Domain.Entities.User", "User")
                        .WithMany("NutritionLists")
                        .HasForeignKey("FKUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Sport.Domain.Entities.MMRelation.UserSportLists", b =>
                {
                    b.HasOne("Sport.Domain.Entities.SportList", "SportList")
                        .WithMany("UserSportLists")
                        .HasForeignKey("FKSportListId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Sport.Domain.Entities.User", "User")
                        .WithMany("UserSportLists")
                        .HasForeignKey("FKUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Sport.Domain.Entities.NutritionDay", b =>
                {
                    b.HasOne("Sport.Domain.Entities.NutritionList", "NutritionList")
                        .WithMany("NutritionDays")
                        .HasForeignKey("FKNutritionListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sport.Domain.Entities.SportDay", b =>
                {
                    b.HasOne("Sport.Domain.Entities.SportList", "SportList")
                        .WithMany("SportDays")
                        .HasForeignKey("FKSportListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sport.Domain.Entities.ThatDay", b =>
                {
                    b.HasOne("Sport.Domain.Entities.NutritionDay", "NutritionDays")
                        .WithMany("ThatDays")
                        .HasForeignKey("FKNutritionDayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
