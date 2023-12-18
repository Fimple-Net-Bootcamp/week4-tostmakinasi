using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VirtualPetCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Health_AddedPetNavigtion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pets_HealthId",
                table: "Pets");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(9672),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PetSpecies",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(8615),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Pets",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(7428),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "HealthInformations",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(6306),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Foods",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(2600),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FoodHistories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(4982),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(3018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActivityHistories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(1108),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(66));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Activities",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 137, DateTimeKind.Utc).AddTicks(7008),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 673, DateTimeKind.Utc).AddTicks(7560));

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

            migrationBuilder.CreateIndex(
                name: "IX_Pets_HealthId",
                table: "Pets",
                column: "HealthId",
                unique: true);
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
                defaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(6815),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(9672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PetSpecies",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(5988),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Pets",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4944),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(7428));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "HealthInformations",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(4117),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Foods",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(1140),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FoodHistories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(3018),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(4982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActivityHistories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 674, DateTimeKind.Utc).AddTicks(66),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 138, DateTimeKind.Utc).AddTicks(1108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Activities",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 15, 9, 2, 31, 673, DateTimeKind.Utc).AddTicks(7560),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 15, 9, 54, 55, 137, DateTimeKind.Utc).AddTicks(7008));

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
    }
}
