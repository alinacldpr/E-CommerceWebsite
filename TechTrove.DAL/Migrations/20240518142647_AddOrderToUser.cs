﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechTrove.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TechTroveOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TechTroveUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechTroveOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechTroveOrders_TechTroveUsers_TechTroveUserId",
                        column: x => x.TechTroveUserId,
                        principalTable: "TechTroveUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TechTroveOrders_TechTroveUserId",
                table: "TechTroveOrders",
                column: "TechTroveUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TechTroveOrders");
        }
    }
}
