using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace STA.Data.Migrations
{
    public partial class AddModels3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ClassId",
                table: "Teacher",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UnitId",
                table: "Teacher",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UnitId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Class_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ClassId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Session_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AttendanceModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SessionId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttendanceModel_Session_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Session",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_ClassId",
                table: "Teacher",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_UnitId",
                table: "Teacher",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceModel_SessionId",
                table: "AttendanceModel",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_UnitId",
                table: "Class",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Session_ClassId",
                table: "Session",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Class_ClassId",
                table: "Teacher",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Unit_UnitId",
                table: "Teacher",
                column: "UnitId",
                principalTable: "Unit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Class_ClassId",
                table: "Teacher");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Unit_UnitId",
                table: "Teacher");

            migrationBuilder.DropTable(
                name: "AttendanceModel");

            migrationBuilder.DropTable(
                name: "Session");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_ClassId",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_UnitId",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "Teacher");
        }
    }
}
