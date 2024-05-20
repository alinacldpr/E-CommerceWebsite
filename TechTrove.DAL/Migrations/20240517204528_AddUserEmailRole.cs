using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechTrove.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddUserEmailRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "TechTroveUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmailConfirmed",
                table: "TechTroveUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumberConfirmed",
                table: "TechTroveUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "TechTroveUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "TechTroveUsers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "TechTroveUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "TechTroveUsers");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "TechTroveUsers");
        }
    }
}
