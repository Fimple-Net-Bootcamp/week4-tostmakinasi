using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VirtualPetCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class ActivityPet_Addedrelation1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_PetSpecies_PetSpeciesId",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Activities_ActivityId",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Pets_ActivityId",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Activities_PetSpeciesId",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "ActivityId",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "PetSpeciesId",
                table: "Activities");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(9205),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PetSpecies",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(8069),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(8436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Pets",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(6842),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(7227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "HealthInformations",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(5737),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Foods",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(1854),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(2535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FoodHistories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(4422),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(4855));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActivityHistories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(183),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(1198));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Activities",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 14, 51, 57, 429, DateTimeKind.Utc).AddTicks(6721),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 732, DateTimeKind.Utc).AddTicks(7691));

            migrationBuilder.CreateTable(
                name: "ActivityPetSpecies",
                columns: table => new
                {
                    ActivitiesId = table.Column<int>(type: "integer", nullable: false),
                    PetSpeciesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityPetSpecies", x => new { x.ActivitiesId, x.PetSpeciesId });
                    table.ForeignKey(
                        name: "FK_ActivityPetSpecies_Activities_ActivitiesId",
                        column: x => x.ActivitiesId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityPetSpecies_PetSpecies_PetSpeciesId",
                        column: x => x.PetSpeciesId,
                        principalTable: "PetSpecies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 429, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 429, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 429, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 429, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 429, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 429, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 429, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 429, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 429, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.CreateIndex(
                name: "IX_ActivityPetSpecies_PetSpeciesId",
                table: "ActivityPetSpecies",
                column: "PetSpeciesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityPetSpecies");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(9448),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PetSpecies",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(8436),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Pets",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(7227),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.AddColumn<int>(
                name: "ActivityId",
                table: "Pets",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "HealthInformations",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(6183),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Foods",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(2535),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(1854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FoodHistories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(4855),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActivityHistories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(1198),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 14, 51, 57, 430, DateTimeKind.Utc).AddTicks(183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Activities",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 732, DateTimeKind.Utc).AddTicks(7691),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 14, 51, 57, 429, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.AddColumn<int>(
                name: "PetSpeciesId",
                table: "Activities",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PetSpeciesId" },
                values: new object[] { new DateTime(2023, 12, 15, 14, 45, 12, 732, DateTimeKind.Utc).AddTicks(7691), null });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PetSpeciesId" },
                values: new object[] { new DateTime(2023, 12, 15, 14, 45, 12, 732, DateTimeKind.Utc).AddTicks(7691), null });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PetSpeciesId" },
                values: new object[] { new DateTime(2023, 12, 15, 14, 45, 12, 732, DateTimeKind.Utc).AddTicks(7691), null });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PetSpeciesId" },
                values: new object[] { new DateTime(2023, 12, 15, 14, 45, 12, 732, DateTimeKind.Utc).AddTicks(7691), null });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PetSpeciesId" },
                values: new object[] { new DateTime(2023, 12, 15, 14, 45, 12, 732, DateTimeKind.Utc).AddTicks(7691), null });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "PetSpeciesId" },
                values: new object[] { new DateTime(2023, 12, 15, 14, 45, 12, 732, DateTimeKind.Utc).AddTicks(7691), null });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "PetSpeciesId" },
                values: new object[] { new DateTime(2023, 12, 15, 14, 45, 12, 732, DateTimeKind.Utc).AddTicks(7691), null });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "PetSpeciesId" },
                values: new object[] { new DateTime(2023, 12, 15, 14, 45, 12, 732, DateTimeKind.Utc).AddTicks(7691), null });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "PetSpeciesId" },
                values: new object[] { new DateTime(2023, 12, 15, 14, 45, 12, 732, DateTimeKind.Utc).AddTicks(7691), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActivityId", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActivityId", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActivityId", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActivityId", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActivityId", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ActivityId", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ActivityId", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ActivityId", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ActivityId", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ActivityId", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.CreateIndex(
                name: "IX_Pets_ActivityId",
                table: "Pets",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_PetSpeciesId",
                table: "Activities",
                column: "PetSpeciesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_PetSpecies_PetSpeciesId",
                table: "Activities",
                column: "PetSpeciesId",
                principalTable: "PetSpecies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Activities_ActivityId",
                table: "Pets",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "Id");
        }
    }
}
