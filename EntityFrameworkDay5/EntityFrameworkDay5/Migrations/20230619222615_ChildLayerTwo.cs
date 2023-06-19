using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkDay5.Migrations
{
    /// <inheritdoc />
    public partial class ChildLayerTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChildLayerTwos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ChildLayerOneId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildLayerTwos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChildLayerTwos_ChildLayerOnes_ChildLayerOneId",
                        column: x => x.ChildLayerOneId,
                        principalTable: "ChildLayerOnes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChildLayerTwos_ChildLayerOneId",
                table: "ChildLayerTwos",
                column: "ChildLayerOneId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChildLayerTwos");
        }
    }
}
