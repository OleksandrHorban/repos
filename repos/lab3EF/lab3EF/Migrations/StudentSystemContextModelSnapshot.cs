﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentSystem.Data;

#nullable disable

namespace StudentSystem.Migrations
{
    [DbContext(typeof(StudentSystemContext))]
    partial class StudentSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentSystem.Data.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("Description")
                        .IsUnicode(true)
                        .HasColumnType("ntext")
                        .HasColumnName("Description");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date")
                        .HasColumnName("EndDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Name");

                    b.Property<decimal>("Price")
                        .HasColumnType("money")
                        .HasColumnName("Price");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date")
                        .HasColumnName("StartDate");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            Description = "Description for OOP",
                            EndDate = new DateTime(2023, 5, 26, 9, 28, 55, 315, DateTimeKind.Local).AddTicks(2165),
                            Name = "OOP",
                            Price = 5000m,
                            StartDate = new DateTime(2023, 5, 26, 9, 28, 55, 315, DateTimeKind.Local).AddTicks(1555)
                        },
                        new
                        {
                            CourseId = 2,
                            Description = "Description for Philosophy",
                            EndDate = new DateTime(2023, 5, 26, 9, 28, 55, 315, DateTimeKind.Local).AddTicks(3728),
                            Name = "Philosophy",
                            Price = 1000m,
                            StartDate = new DateTime(2023, 5, 26, 9, 28, 55, 315, DateTimeKind.Local).AddTicks(3709)
                        });
                });

            modelBuilder.Entity("StudentSystem.Data.Models.Homework", b =>
                {
                    b.Property<int>("HomeworkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HomeworkId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("text")
                        .HasColumnName("Content");

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar")
                        .HasColumnName("ContentType");

                    b.Property<int>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("CourseId");

                    b.Property<int>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("StudentId");

                    b.Property<DateTime>("SubmissionTime")
                        .HasColumnType("date")
                        .HasColumnName("SubmissionTime");

                    b.HasKey("HomeworkId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("HomeworkSubmissions");

                    b.HasData(
                        new
                        {
                            HomeworkId = 1,
                            Content = "Task",
                            ContentType = "pdf",
                            CourseId = 1,
                            StudentId = 1,
                            SubmissionTime = new DateTime(2023, 5, 26, 9, 28, 55, 326, DateTimeKind.Local).AddTicks(7933)
                        },
                        new
                        {
                            HomeworkId = 2,
                            Content = "Task",
                            ContentType = "application",
                            CourseId = 2,
                            StudentId = 1,
                            SubmissionTime = new DateTime(2023, 5, 26, 9, 28, 55, 326, DateTimeKind.Local).AddTicks(8938)
                        });
                });

            modelBuilder.Entity("StudentSystem.Data.Models.Resource", b =>
                {
                    b.Property<int>("ResourceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResourceId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("CourseId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Name");

                    b.Property<string>("ResourceType")
                        .IsRequired()
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar")
                        .HasColumnName("ResourceType");

                    b.Property<string>("Url")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("text")
                        .HasColumnName("Url");

                    b.HasKey("ResourceId");

                    b.HasIndex("CourseId");

                    b.ToTable("Resources");

                    b.HasData(
                        new
                        {
                            ResourceId = 1,
                            CourseId = 1,
                            Name = "Metanit",
                            ResourceType = "video",
                            Url = "www.link.com"
                        },
                        new
                        {
                            ResourceId = 2,
                            CourseId = 2,
                            Name = "Entity Framework Core",
                            ResourceType = "video",
                            Url = "www.linkk.com"
                        });
                });

            modelBuilder.Entity("StudentSystem.Data.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("date")
                        .HasColumnName("Birthday");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Name");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char")
                        .HasColumnName("PhoneNumber")
                        .IsFixedLength();

                    b.Property<DateTime>("RegisteredOn")
                        .HasColumnType("date")
                        .HasColumnName("RegisteredOn");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            Birthday = new DateTime(2023, 5, 26, 9, 28, 55, 309, DateTimeKind.Local).AddTicks(9812),
                            Name = "Oleksandr",
                            PhoneNumber = "+123456789",
                            RegisteredOn = new DateTime(2023, 5, 26, 9, 28, 55, 306, DateTimeKind.Local).AddTicks(4870)
                        },
                        new
                        {
                            StudentId = 2,
                            Birthday = new DateTime(2023, 5, 26, 9, 28, 55, 310, DateTimeKind.Local).AddTicks(973),
                            Name = "Stepan",
                            PhoneNumber = "+123456789",
                            RegisteredOn = new DateTime(2023, 5, 26, 9, 28, 55, 310, DateTimeKind.Local).AddTicks(953)
                        });
                });

            modelBuilder.Entity("StudentSystem.Data.Models.StudentCourse", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentCourses");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            CourseId = 1
                        },
                        new
                        {
                            StudentId = 2,
                            CourseId = 2
                        });
                });

            modelBuilder.Entity("StudentSystem.Data.Models.Homework", b =>
                {
                    b.HasOne("StudentSystem.Data.Models.Course", "Course")
                        .WithMany("HomeworkSubmissions")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentSystem.Data.Models.Student", "Student")
                        .WithMany("HomeworkSubmissions")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentSystem.Data.Models.Resource", b =>
                {
                    b.HasOne("StudentSystem.Data.Models.Course", "Course")
                        .WithMany("Resources")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("StudentSystem.Data.Models.StudentCourse", b =>
                {
                    b.HasOne("StudentSystem.Data.Models.Course", "Course")
                        .WithMany("StudentsEnrolled")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentSystem.Data.Models.Student", "Student")
                        .WithMany("CourseEnrollments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentSystem.Data.Models.Course", b =>
                {
                    b.Navigation("HomeworkSubmissions");

                    b.Navigation("Resources");

                    b.Navigation("StudentsEnrolled");
                });

            modelBuilder.Entity("StudentSystem.Data.Models.Student", b =>
                {
                    b.Navigation("CourseEnrollments");

                    b.Navigation("HomeworkSubmissions");
                });
#pragma warning restore 612, 618
        }
    }
}
