using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PubtracSSPoc.Data.Migrations
{
    public partial class Manuals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Manuals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manual = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManualNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastRevNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastBullNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastChangeNo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manuals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManualToCopyHolders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CopyNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ManualNo = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManualToCopyHolders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManualToCopyHolders_Copyholders_UserId",
                        column: x => x.UserId,
                        principalTable: "Copyholders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ManualToCopyHolders_Manuals_ManualNo",
                        column: x => x.ManualNo,
                        principalTable: "Manuals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ManualToCopyHolders_ManualNo",
                table: "ManualToCopyHolders",
                column: "ManualNo");

            migrationBuilder.CreateIndex(
                name: "IX_ManualToCopyHolders_UserId",
                table: "ManualToCopyHolders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManualToCopyHolders");

            migrationBuilder.DropTable(
                name: "Manuals");
        }
    }
}
