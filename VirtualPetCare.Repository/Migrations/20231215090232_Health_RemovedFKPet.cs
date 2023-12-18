using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VirtualPetCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Health_RemovedFKPet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pets_HealthId",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "PetId",
                table: "HealthInformations");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(6815),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PetSpecies",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(5988),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Pets",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4944),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "HealthInformations",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4117),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(2696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Foods",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(1140),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(9185));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FoodHistories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(3018),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(1456));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActivityHistories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(66),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(7808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Activities",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 673, DateTimeKind.Utc).AddTicks(7560),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 673, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 673, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 673, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 673, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 673, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 673, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 673, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 673, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 673, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.CreateIndex(
                name: "IX_Pets_HealthId",
                table: "Pets",
                column: "HealthId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pets_HealthId",
                table: "Pets");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(5773),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PetSpecies",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(4787),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Pets",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(3693),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "HealthInformations",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(2696),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.AddColumn<int>(
                name: "PetId",
                table: "HealthInformations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Foods",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(9185),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FoodHistories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(1456),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(3018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActivityHistories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(7808),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(66));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Activities",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(4270),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 673, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 30, DateTimeKind.Utc).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PetId" },
                values: new object[] { new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(2696), 1 });

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PetId" },
                values: new object[] { new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(2696), 2 });

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PetId" },
                values: new object[] { new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(2696), 3 });

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PetId" },
                values: new object[] { new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(2696), 4 });

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PetId" },
                values: new object[] { new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(2696), 5 });

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "PetId" },
                values: new object[] { new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(2696), 6 });

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "PetId" },
                values: new object[] { new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(2696), 7 });

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "PetId" },
                values: new object[] { new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(2696), 8 });

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "PetId" },
                values: new object[] { new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(2696), 9 });

            migrationBuilder.UpdateData(
                table: "HealthInformations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "PetId" },
                values: new object[] { new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(2696), 10 });

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "PetSpecies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 20, 37, 26, 31, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.CreateIndex(
                name: "IX_Pets_HealthId",
                table: "Pets",
                column: "HealthId",
                unique: true);
        }
    }
}
