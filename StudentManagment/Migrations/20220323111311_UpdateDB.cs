using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagment.Migrations
{
    public partial class UpdateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentCourseViewModelId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentCourseViewModelId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StudentCourseViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentNumber = table.Column<int>(type: "int", nullable: false),
                    StudentCourses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseNumber = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourseViewModel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentCourseViewModelId",
                table: "Students",
                column: "StudentCourseViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_StudentCourseViewModelId",
                table: "Courses",
                column: "StudentCourseViewModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_StudentCourseViewModel_StudentCourseViewModelId",
                table: "Courses",
                column: "StudentCourseViewModelId",
                principalTable: "StudentCourseViewModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentCourseViewModel_StudentCourseViewModelId",
                table: "Students",
                column: "StudentCourseViewModelId",
                principalTable: "StudentCourseViewModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_StudentCourseViewModel_StudentCourseViewModelId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentCourseViewModel_StudentCourseViewModelId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "StudentCourseViewModel");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentCourseViewModelId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Courses_StudentCourseViewModelId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "StudentCourseViewModelId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentCourseViewModelId",
                table: "Courses");
        }
    }
}
