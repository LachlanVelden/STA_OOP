using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace STA.Data.Migrations
{
    public partial class AddPropsToMod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Unit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Teacher",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Teacher",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Room",
                table: "Session",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TeacherId",
                table: "Session",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "Session",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Class",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StudentId",
                table: "AttendanceModel",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeArrived",
                table: "AttendanceModel",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeLeft",
                table: "AttendanceModel",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Session_TeacherId",
                table: "Session",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceModel_StudentId",
                table: "AttendanceModel",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceModel_Student_StudentId",
                table: "AttendanceModel",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Session_Teacher_TeacherId",
                table: "Session",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceModel_Student_StudentId",
                table: "AttendanceModel");

            migrationBuilder.DropForeignKey(
                name: "FK_Session_Teacher_TeacherId",
                table: "Session");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Session_TeacherId",
                table: "Session");

            migrationBuilder.DropIndex(
                name: "IX_AttendanceModel_StudentId",
                table: "AttendanceModel");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Unit");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "Room",
                table: "Session");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Session");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Session");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Class");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "AttendanceModel");

            migrationBuilder.DropColumn(
                name: "TimeArrived",
                table: "AttendanceModel");

            migrationBuilder.DropColumn(
                name: "TimeLeft",
                table: "AttendanceModel");
        }
    }
}
