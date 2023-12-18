using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VirtualPetCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    HealthEffect = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(4270)),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    HealthEffect = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(9185)),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HealthInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    PetId = table.Column<int>(type: "integer", nullable: false),
                    IsAlive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(2696)),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthInformations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PetSpecies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Species = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(4787)),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetSpecies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(5773)),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OwnerId = table.Column<int>(type: "integer", nullable: false),
                    PetSpeciesId = table.Column<int>(type: "integer", nullable: false),
                    HealthId = table.Column<int>(type: "integer", nullable: false),
                    PetName = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(3693)),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pets_HealthInformations_HealthId",
                        column: x => x.HealthId,
                        principalTable: "HealthInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pets_PetSpecies_PetSpeciesId",
                        column: x => x.PetSpeciesId,
                        principalTable: "PetSpecies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pets_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActivityHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PetId = table.Column<int>(type: "integer", nullable: false),
                    ActivityId = table.Column<int>(type: "integer", nullable: false),
                    HealthEffect = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(7808)),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityHistories_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityHistories_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PetId = table.Column<int>(type: "integer", nullable: false),
                    FoodId = table.Column<int>(type: "integer", nullable: false),
                    HealthEffect = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(1456)),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodHistories_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodHistories_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "HealthEffect", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 20, "Walking", null },
                    { 2, 30, "Playing", null },
                    { 3, 10, "Swimming", null },
                    { 4, 20, "Running", null },
                    { 5, 4, "Jumping", null },
                    { 6, 2, "Sleeping", null },
                    { 7, 1, "TugOfWar", null },
                    { 8, 9, "Training", null },
                    { 9, 5, "Chasing", null }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "HealthEffect", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 10, "Chicken", null },
                    { 2, 8, "Fish", null },
                    { 3, 12, "Beef", null },
                    { 4, 5, "Vegetables", null },
                    { 5, 7, "Fruits", null },
                    { 6, 6, "Grains", null },
                    { 7, 9, "Milk", null },
                    { 8, 7, "Cheese", null },
                    { 9, 8, "Eggs", null },
                    { 10, 3, "Treats", null }
                });

            migrationBuilder.InsertData(
                table: "HealthInformations",
                columns: new[] { "Id", "IsAlive", "PetId", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, true, 1, 75, null },
                    { 2, true, 2, 80, null },
                    { 3, true, 3, 65, null },
                    { 4, true, 4, 90, null },
                    { 5, true, 5, 70, null },
                    { 6, true, 6, 85, null },
                    { 7, true, 7, 60, null },
                    { 8, true, 8, 95, null },
                    { 9, true, 9, 72, null },
                    { 10, true, 10, 88, null }
                });

            migrationBuilder.InsertData(
                table: "PetSpecies",
                columns: new[] { "Id", "Species", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Dog", null },
                    { 2, "Cat", null },
                    { 3, "Bird", null },
                    { 4, "Fish", null },
                    { 5, "Hamster", null },
                    { 6, "Turtle", null },
                    { 7, "Rabbit", null },
                    { 8, "Snake", null },
                    { 9, "Guinea Pig", null },
                    { 10, "Lizard", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 1, "John", "Doe", null, "JohnDoe" },
                    { 2, "Jane", "Doe", null, "JaneDoe" },
                    { 3, "Alice", "Doe", null, "Alice" },
                    { 4, "Bob", "Doe", null, "Bob" },
                    { 5, "Eve", "Doe", null, "Eve" },
                    { 6, "Charlie", "Doe", null, "Charlie" },
                    { 7, "David", "Doe", null, "David" },
                    { 8, "Sophia", "Doe", null, "Sophia" },
                    { 9, "Oliver", "Doe", null, "Oliver" },
                    { 10, "Emma", "Doe", null, "Emma" }
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "HealthId", "OwnerId", "PetName", "PetSpeciesId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, 1, "Buddy", 1, null },
                    { 2, 2, 2, "Whiskers", 2, null },
                    { 3, 3, 3, "Tweety", 3, null },
                    { 4, 4, 4, "Goldie", 4, null },
                    { 5, 5, 5, "Fluffy", 5, null },
                    { 6, 6, 6, "Speedy", 6, null },
                    { 7, 7, 7, "Bugs", 7, null },
                    { 8, 8, 8, "Mittens", 8, null },
                    { 9, 9, 9, "Fido", 9, null },
                    { 10, 10, 10, "Spike", 10, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityHistories_ActivityId",
                table: "ActivityHistories",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityHistories_PetId",
                table: "ActivityHistories",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodHistories_FoodId",
                table: "FoodHistories",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodHistories_PetId",
                table: "FoodHistories",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_HealthId",
                table: "Pets",
                column: "HealthId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pets_OwnerId",
                table: "Pets",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_PetSpeciesId",
                table: "Pets",
                column: "PetSpeciesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityHistories");

            migrationBuilder.DropTable(
                name: "FoodHistories");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "HealthInformations");

            migrationBuilder.DropTable(
                name: "PetSpecies");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
