using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagment.Migrations
{
    public partial class ManyToMay2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_StudentCourseViewModel_StudentCourseViewModelId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentCourseViewModel_StudentCourseViewModelId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Student_Courses");

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

            migrationBuilder.CreateTable(
                name: "CourseStudent",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudent", x => new { x.CoursesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_CourseStudent_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudent_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudent_StudentsId",
                table: "CourseStudent",
                column: "StudentsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseStudent");

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
                name: "Student_Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Courses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_Courses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourseViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    courseId = table.Column<int>(type: "int", nullable: true),
                    studentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourseViewModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentCourseViewModel_Courses_courseId",
                        column: x => x.courseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentCourseViewModel_Students_studentId",
                        column: x => x.studentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentCourseViewModelId",
                table: "Students",
                column: "StudentCourseViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_StudentCourseViewModelId",
                table: "Courses",
                column: "StudentCourseViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Courses_CourseId",
                table: "Student_Courses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Courses_StudentId",
                table: "Student_Courses",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseViewModel_courseId",
                table: "StudentCourseViewModel",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseViewModel_studentId",
                table: "StudentCourseViewModel",
                column: "studentId");

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
    }
}
