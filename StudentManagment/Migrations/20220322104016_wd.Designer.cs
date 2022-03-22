﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentManagment.Data;

namespace StudentManagment.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220322104016_wd")]
    partial class wd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("StudentManagment.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseNumber")
                        .HasColumnType("int");

                    b.Property<int?>("StudentCourseViewModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentCourseViewModelId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("StudentManagment.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("StudentCourseViewModelId")
                        .HasColumnType("int");

                    b.Property<string>("StudentCourses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StudentNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentCourseViewModelId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentManagment.Models.Student_Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Student_Courses");
                });

            modelBuilder.Entity("StudentManagment.ViewModels.StudentCourseViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("courseId")
                        .HasColumnType("int");

                    b.Property<int?>("studentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("courseId");

                    b.HasIndex("studentId");

                    b.ToTable("StudentCourseViewModel");
                });

            modelBuilder.Entity("StudentManagment.Models.Course", b =>
                {
                    b.HasOne("StudentManagment.ViewModels.StudentCourseViewModel", null)
                        .WithMany("courses")
                        .HasForeignKey("StudentCourseViewModelId");
                });

            modelBuilder.Entity("StudentManagment.Models.Student", b =>
                {
                    b.HasOne("StudentManagment.ViewModels.StudentCourseViewModel", null)
                        .WithMany("students")
                        .HasForeignKey("StudentCourseViewModelId");
                });

            modelBuilder.Entity("StudentManagment.Models.Student_Course", b =>
                {
                    b.HasOne("StudentManagment.Models.Course", "Course")
                        .WithMany("Student_Courses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManagment.Models.Student", "Student")
                        .WithMany("Student_Courses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentManagment.ViewModels.StudentCourseViewModel", b =>
                {
                    b.HasOne("StudentManagment.Models.Course", "course")
                        .WithMany()
                        .HasForeignKey("courseId");

                    b.HasOne("StudentManagment.Models.Student", "student")
                        .WithMany()
                        .HasForeignKey("studentId");

                    b.Navigation("course");

                    b.Navigation("student");
                });

            modelBuilder.Entity("StudentManagment.Models.Course", b =>
                {
                    b.Navigation("Student_Courses");
                });

            modelBuilder.Entity("StudentManagment.Models.Student", b =>
                {
                    b.Navigation("Student_Courses");
                });

            modelBuilder.Entity("StudentManagment.ViewModels.StudentCourseViewModel", b =>
                {
                    b.Navigation("courses");

                    b.Navigation("students");
                });
#pragma warning restore 612, 618
        }
    }
}