using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechTrove.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderProductCartCategoryItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "TechTroveUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "TechTroveUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "TechTroveCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechTroveCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TechTroveOrderLine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TechTroveOrderId = table.Column<int>(type: "int", nullable: false),
                    TechTroveProductId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechTroveOrderLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechTroveOrderLine_TechTroveOrders_TechTroveOrderId",
                        column: x => x.TechTroveOrderId,
                        principalTable: "TechTroveOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TechTroveProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TechTroveCategoryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    TechTroveOrderLineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechTroveProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechTroveProducts_TechTroveCategories_TechTroveCategoryId",
                        column: x => x.TechTroveCategoryId,
                        principalTable: "TechTroveCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TechTroveProducts_TechTroveOrderLine_TechTroveOrderLineId",
                        column: x => x.TechTroveOrderLineId,
                        principalTable: "TechTroveOrderLine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TechTroveCartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TechTroveCartId = table.Column<int>(type: "int", nullable: false),
                    TechTroveProductId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechTroveCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechTroveCartItems_TechTroveCarts_TechTroveCartId",
                        column: x => x.TechTroveCartId,
                        principalTable: "TechTroveCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TechTroveCartItems_TechTroveProducts_TechTroveProductId",
                        column: x => x.TechTroveProductId,
                        principalTable: "TechTroveProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TechTroveCartItems_TechTroveCartId",
                table: "TechTroveCartItems",
                column: "TechTroveCartId");

            migrationBuilder.CreateIndex(
                name: "IX_TechTroveCartItems_TechTroveProductId",
                table: "TechTroveCartItems",
                column: "TechTroveProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TechTroveOrderLine_TechTroveOrderId",
                table: "TechTroveOrderLine",
                column: "TechTroveOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_TechTroveProducts_TechTroveCategoryId",
                table: "TechTroveProducts",
                column: "TechTroveCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TechTroveProducts_TechTroveOrderLineId",
                table: "TechTroveProducts",
                column: "TechTroveOrderLineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TechTroveCartItems");

            migrationBuilder.DropTable(
                name: "TechTroveProducts");

            migrationBuilder.DropTable(
                name: "TechTroveCategories");

            migrationBuilder.DropTable(
                name: "TechTroveOrderLine");

            migrationBuilder.DropColumn(
                name: "City",
                table: "TechTroveUsers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "TechTroveUsers");
        }
    }
}
