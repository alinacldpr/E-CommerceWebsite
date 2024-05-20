using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechTrove.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ChangeRelationProductToOrderLine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TechTroveProducts_TechTroveOrderLine_TechTroveOrderLineId",
                table: "TechTroveProducts");

            migrationBuilder.DropIndex(
                name: "IX_TechTroveProducts_TechTroveOrderLineId",
                table: "TechTroveProducts");

            migrationBuilder.DropColumn(
                name: "TechTroveOrderLineId",
                table: "TechTroveProducts");

            migrationBuilder.CreateIndex(
                name: "IX_TechTroveOrderLine_TechTroveProductId",
                table: "TechTroveOrderLine",
                column: "TechTroveProductId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TechTroveOrderLine_TechTroveProducts_TechTroveProductId",
                table: "TechTroveOrderLine",
                column: "TechTroveProductId",
                principalTable: "TechTroveProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TechTroveOrderLine_TechTroveProducts_TechTroveProductId",
                table: "TechTroveOrderLine");

            migrationBuilder.DropIndex(
                name: "IX_TechTroveOrderLine_TechTroveProductId",
                table: "TechTroveOrderLine");

            migrationBuilder.AddColumn<int>(
                name: "TechTroveOrderLineId",
                table: "TechTroveProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TechTroveProducts_TechTroveOrderLineId",
                table: "TechTroveProducts",
                column: "TechTroveOrderLineId");

            migrationBuilder.AddForeignKey(
                name: "FK_TechTroveProducts_TechTroveOrderLine_TechTroveOrderLineId",
                table: "TechTroveProducts",
                column: "TechTroveOrderLineId",
                principalTable: "TechTroveOrderLine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
