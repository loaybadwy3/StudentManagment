using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagment.Migrations
{
    public partial class wd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "courseId",
                table: "StudentCourseViewModel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseViewModel_courseId",
                table: "StudentCourseViewModel",
                column: "courseId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourseViewModel_Courses_courseId",
                table: "StudentCourseViewModel",
                column: "courseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourseViewModel_Courses_courseId",
                table: "StudentCourseViewModel");

            migrationBuilder.DropIndex(
                name: "IX_StudentCourseViewModel_courseId",
                table: "StudentCourseViewModel");

            migrationBuilder.DropColumn(
                name: "courseId",
                table: "StudentCourseViewModel");
        }
    }
}
