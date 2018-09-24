using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace STA.Data.Migrations
{
    public partial class AddModels1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CourseId",
                table: "Teacher",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CourseId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Unit_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_CourseId",
                table: "Teacher",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_CourseId",
                table: "Unit",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Courses_CourseId",
                table: "Teacher",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Courses_CourseId",
                table: "Teacher");

            migrationBuilder.DropTable(
                name: "Unit");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_CourseId",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Teacher");
        }
    }
}
