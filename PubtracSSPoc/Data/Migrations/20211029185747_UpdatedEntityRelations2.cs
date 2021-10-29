using Microsoft.EntityFrameworkCore.Migrations;

namespace PubtracSSPoc.Data.Migrations
{
    public partial class UpdatedEntityRelations2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ManualToCopyHolders_CopyholderId",
                table: "ManualToCopyHolders");

            migrationBuilder.DropIndex(
                name: "IX_ManualToCopyHolders_ManualId",
                table: "ManualToCopyHolders");

            migrationBuilder.CreateIndex(
                name: "IX_ManualToCopyHolders_CopyholderId",
                table: "ManualToCopyHolders",
                column: "CopyholderId");

            migrationBuilder.CreateIndex(
                name: "IX_ManualToCopyHolders_ManualId",
                table: "ManualToCopyHolders",
                column: "ManualId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ManualToCopyHolders_CopyholderId",
                table: "ManualToCopyHolders");

            migrationBuilder.DropIndex(
                name: "IX_ManualToCopyHolders_ManualId",
                table: "ManualToCopyHolders");

            migrationBuilder.CreateIndex(
                name: "IX_ManualToCopyHolders_CopyholderId",
                table: "ManualToCopyHolders",
                column: "CopyholderId",
                unique: true,
                filter: "[CopyholderId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ManualToCopyHolders_ManualId",
                table: "ManualToCopyHolders",
                column: "ManualId",
                unique: true,
                filter: "[ManualId] IS NOT NULL");
        }
    }
}
