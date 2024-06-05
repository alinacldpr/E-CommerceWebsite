using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechTrove.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddPasswordToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TechTroveOrderLine_TechTroveOrders_TechTroveOrderId",
                table: "TechTroveOrderLine");

            migrationBuilder.DropForeignKey(
                name: "FK_TechTroveOrderLine_TechTroveProducts_TechTroveProductId",
                table: "TechTroveOrderLine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TechTroveOrderLine",
                table: "TechTroveOrderLine");

            migrationBuilder.RenameTable(
                name: "TechTroveOrderLine",
                newName: "TechTroveOrderLines");

            migrationBuilder.RenameIndex(
                name: "IX_TechTroveOrderLine_TechTroveProductId",
                table: "TechTroveOrderLines",
                newName: "IX_TechTroveOrderLines_TechTroveProductId");

            migrationBuilder.RenameIndex(
                name: "IX_TechTroveOrderLine_TechTroveOrderId",
                table: "TechTroveOrderLines",
                newName: "IX_TechTroveOrderLines_TechTroveOrderId");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "TechTroveUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TechTroveOrderLines",
                table: "TechTroveOrderLines",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TechTroveOrderLines_TechTroveOrders_TechTroveOrderId",
                table: "TechTroveOrderLines",
                column: "TechTroveOrderId",
                principalTable: "TechTroveOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TechTroveOrderLines_TechTroveProducts_TechTroveProductId",
                table: "TechTroveOrderLines",
                column: "TechTroveProductId",
                principalTable: "TechTroveProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TechTroveOrderLines_TechTroveOrders_TechTroveOrderId",
                table: "TechTroveOrderLines");

            migrationBuilder.DropForeignKey(
                name: "FK_TechTroveOrderLines_TechTroveProducts_TechTroveProductId",
                table: "TechTroveOrderLines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TechTroveOrderLines",
                table: "TechTroveOrderLines");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "TechTroveUsers");

            migrationBuilder.RenameTable(
                name: "TechTroveOrderLines",
                newName: "TechTroveOrderLine");

            migrationBuilder.RenameIndex(
                name: "IX_TechTroveOrderLines_TechTroveProductId",
                table: "TechTroveOrderLine",
                newName: "IX_TechTroveOrderLine_TechTroveProductId");

            migrationBuilder.RenameIndex(
                name: "IX_TechTroveOrderLines_TechTroveOrderId",
                table: "TechTroveOrderLine",
                newName: "IX_TechTroveOrderLine_TechTroveOrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TechTroveOrderLine",
                table: "TechTroveOrderLine",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TechTroveOrderLine_TechTroveOrders_TechTroveOrderId",
                table: "TechTroveOrderLine",
                column: "TechTroveOrderId",
                principalTable: "TechTroveOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TechTroveOrderLine_TechTroveProducts_TechTroveProductId",
                table: "TechTroveOrderLine",
                column: "TechTroveProductId",
                principalTable: "TechTroveProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
