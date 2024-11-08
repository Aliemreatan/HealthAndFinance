using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthAndFinance.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class migchanges1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HealthEntries_AspNetUsers_UserId",
                table: "HealthEntries");

            migrationBuilder.DropIndex(
                name: "IX_HealthEntries_UserId",
                table: "HealthEntries");

            migrationBuilder.DropColumn(
                name: "BKI",
                table: "HealthEntries");

            migrationBuilder.DropColumn(
                name: "CaloriesBurned",
                table: "HealthEntries");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "HealthEntries");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "HealthEntries");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "HealthEntries");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "HealthEntries");

            migrationBuilder.DropColumn(
                name: "SleepHours",
                table: "HealthEntries");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "HealthEntries");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "HealthEntries");

            migrationBuilder.RenameColumn(
                name: "Steps",
                table: "HealthEntries",
                newName: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthEntries_AppUserId",
                table: "HealthEntries",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_HealthEntries_AspNetUsers_AppUserId",
                table: "HealthEntries",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HealthEntries_AspNetUsers_AppUserId",
                table: "HealthEntries");

            migrationBuilder.DropIndex(
                name: "IX_HealthEntries_AppUserId",
                table: "HealthEntries");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "HealthEntries",
                newName: "Steps");

            migrationBuilder.AddColumn<int>(
                name: "BKI",
                table: "HealthEntries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CaloriesBurned",
                table: "HealthEntries",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "HealthEntries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "HealthEntries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "HealthEntries",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "HealthEntries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "SleepHours",
                table: "HealthEntries",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "HealthEntries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "HealthEntries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_HealthEntries_UserId",
                table: "HealthEntries",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_HealthEntries_AspNetUsers_UserId",
                table: "HealthEntries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
