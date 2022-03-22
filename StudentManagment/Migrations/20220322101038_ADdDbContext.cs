using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagment.Migrations
{
    public partial class ADdDbContext : Migration
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
                    studentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourseViewModel", x => x.Id);
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
