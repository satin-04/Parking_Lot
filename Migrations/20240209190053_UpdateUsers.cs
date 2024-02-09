using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parking_Lot.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "time",
                table: "Users",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Users",
                newName: "Date");

            migrationBuilder.AddColumn<string>(
                name: "CarTyoe",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarTyoe",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Users",
                newName: "time");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Users",
                newName: "date");
        }
    }
}
