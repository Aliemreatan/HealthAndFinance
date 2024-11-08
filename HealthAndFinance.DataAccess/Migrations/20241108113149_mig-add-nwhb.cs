using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthAndFinance.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class migaddnwhb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BKI",
                table: "HealthEntries");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "HealthEntries");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "HealthEntries");

            migrationBuilder.DropColumn(
                name: "SleepHours",
                table: "HealthEntries");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "HealthEntries");

            migrationBuilder.AddColumn<int>(
                name: "BKI",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "SleepHours",
                table: "AspNetUsers",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "AspNetUsers",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BKI",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SleepHours",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "BKI",
                table: "HealthEntries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "HealthEntries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "HealthEntries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "SleepHours",
                table: "HealthEntries",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "HealthEntries",
                type: "int",
                nullable: true);
        }
    }
}
