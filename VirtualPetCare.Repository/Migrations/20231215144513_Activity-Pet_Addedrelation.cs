using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VirtualPetCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class ActivityPet_Addedrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(9448),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(9672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PetSpecies",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(8436),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Pets",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(7227),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(7428));

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
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Foods",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(2535),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FoodHistories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(4855),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(4982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActivityHistories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(1198),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(1108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Activities",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 732, DateTimeKind.Utc).AddTicks(7691),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 137, DateTimeKind.Utc).AddTicks(7008));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(9672),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PetSpecies",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(8615),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(8436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Pets",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(7428),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(7227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "HealthInformations",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(6306),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Foods",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(2600),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(2535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FoodHistories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(4982),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(4855));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActivityHistories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(1108),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 733, DateTimeKind.Utc).AddTicks(1198));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Activities",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 137, DateTimeKind.Utc).AddTicks(7008),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 14, 45, 12, 732, DateTimeKind.Utc).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 137, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 137, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 137, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 137, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 137, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 137, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 137, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 137, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 137, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(9672));
        }
    }
}
