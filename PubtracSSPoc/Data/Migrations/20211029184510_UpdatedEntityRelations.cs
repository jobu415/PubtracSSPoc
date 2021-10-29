using Microsoft.EntityFrameworkCore.Migrations;

namespace PubtracSSPoc.Data.Migrations
{
    public partial class UpdatedEntityRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ManualToCopyHolders_Copyholders_UserId",
                table: "ManualToCopyHolders");

            migrationBuilder.DropForeignKey(
                name: "FK_ManualToCopyHolders_Manuals_ManualNo",
                table: "ManualToCopyHolders");

            migrationBuilder.DropIndex(
                name: "IX_ManualToCopyHolders_ManualNo",
                table: "ManualToCopyHolders");

            migrationBuilder.DropIndex(
                name: "IX_ManualToCopyHolders_UserId",
                table: "ManualToCopyHolders");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ManualToCopyHolders",
                newName: "ManualId");

            migrationBuilder.RenameColumn(
                name: "ManualNo",
                table: "ManualToCopyHolders",
                newName: "CopyholderId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Manuals",
                newName: "ManualId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Copyholders",
                newName: "CopyholderId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ManualToCopyHolders_Copyholders_CopyholderId",
                table: "ManualToCopyHolders",
                column: "CopyholderId",
                principalTable: "Copyholders",
                principalColumn: "CopyholderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ManualToCopyHolders_Manuals_ManualId",
                table: "ManualToCopyHolders",
                column: "ManualId",
                principalTable: "Manuals",
                principalColumn: "ManualId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ManualToCopyHolders_Copyholders_CopyholderId",
                table: "ManualToCopyHolders");

            migrationBuilder.DropForeignKey(
                name: "FK_ManualToCopyHolders_Manuals_ManualId",
                table: "ManualToCopyHolders");

            migrationBuilder.DropIndex(
                name: "IX_ManualToCopyHolders_CopyholderId",
                table: "ManualToCopyHolders");

            migrationBuilder.DropIndex(
                name: "IX_ManualToCopyHolders_ManualId",
                table: "ManualToCopyHolders");

            migrationBuilder.RenameColumn(
                name: "ManualId",
                table: "ManualToCopyHolders",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "CopyholderId",
                table: "ManualToCopyHolders",
                newName: "ManualNo");

            migrationBuilder.RenameColumn(
                name: "ManualId",
                table: "Manuals",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CopyholderId",
                table: "Copyholders",
                newName: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ManualToCopyHolders_ManualNo",
                table: "ManualToCopyHolders",
                column: "ManualNo");

            migrationBuilder.CreateIndex(
                name: "IX_ManualToCopyHolders_UserId",
                table: "ManualToCopyHolders",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ManualToCopyHolders_Copyholders_UserId",
                table: "ManualToCopyHolders",
                column: "UserId",
                principalTable: "Copyholders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ManualToCopyHolders_Manuals_ManualNo",
                table: "ManualToCopyHolders",
                column: "ManualNo",
                principalTable: "Manuals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
