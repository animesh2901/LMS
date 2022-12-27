﻿// <auto-generated />
using System;
using LMS.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LMS.Migrations
{
    [DbContext(typeof(LMSDbContext))]
    partial class LMSDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LMS.Models.Courses.C1Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("U4TeacherId")
                        .HasColumnType("int");

                    b.Property<int?>("U5StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("U4TeacherId");

                    b.HasIndex("U5StudentId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("LMS.Models.Courses.C2Chapter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ChapterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CourseIdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseIdId");

                    b.ToTable("Chapters");
                });

            modelBuilder.Entity("LMS.Models.Courses.C3ChapterContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("C2ChapterId")
                        .HasColumnType("int");

                    b.Property<int>("ChapterId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("C2ChapterId");

                    b.ToTable("ChapterContents");
                });

            modelBuilder.Entity("LMS.Models.Courses.C4ChapterQuiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("C3ChapterContentId")
                        .HasColumnType("int");

                    b.Property<int>("ChapterContentId")
                        .HasColumnType("int");

                    b.Property<string>("QuizName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("C3ChapterContentId");

                    b.ToTable("ChapterQuizes");
                });

            modelBuilder.Entity("LMS.Models.Courses.C5Quiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("C4ChapterQuizId")
                        .HasColumnType("int");

                    b.Property<int>("ChapterQuizID")
                        .HasColumnType("int");

                    b.Property<string>("CorrectAnswer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("C4ChapterQuizId");

                    b.ToTable("Quizes");
                });

            modelBuilder.Entity("LMS.Models.Users.U1UserRoll", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UserType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserRolls");
                });

            modelBuilder.Entity("LMS.Models.Users.U2Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserRollIDId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserRollIDId");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("LMS.Models.Users.U3Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfRegistration")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserRollIDId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserRollIDId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("LMS.Models.Users.U4Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<long>("ContactNumber")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateOfJoining")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserRollIDId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserRollIDId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("LMS.Models.Users.U5Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<long>("ContactNumber")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateOfRegistration")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserRollIDId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserRollIDId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("LMS.Models.Courses.C1Course", b =>
                {
                    b.HasOne("LMS.Models.Users.U4Teacher", null)
                        .WithMany("CoursesID")
                        .HasForeignKey("U4TeacherId");

                    b.HasOne("LMS.Models.Users.U5Student", null)
                        .WithMany("CoursesID")
                        .HasForeignKey("U5StudentId");
                });

            modelBuilder.Entity("LMS.Models.Courses.C2Chapter", b =>
                {
                    b.HasOne("LMS.Models.Courses.C1Course", "CourseId")
                        .WithMany("ChapterID")
                        .HasForeignKey("CourseIdId");

                    b.Navigation("CourseId");
                });

            modelBuilder.Entity("LMS.Models.Courses.C3ChapterContent", b =>
                {
                    b.HasOne("LMS.Models.Courses.C2Chapter", null)
                        .WithMany("ChapterContentID")
                        .HasForeignKey("C2ChapterId");
                });

            modelBuilder.Entity("LMS.Models.Courses.C4ChapterQuiz", b =>
                {
                    b.HasOne("LMS.Models.Courses.C3ChapterContent", null)
                        .WithMany("ChapterQuizesID")
                        .HasForeignKey("C3ChapterContentId");
                });

            modelBuilder.Entity("LMS.Models.Courses.C5Quiz", b =>
                {
                    b.HasOne("LMS.Models.Courses.C4ChapterQuiz", null)
                        .WithMany("QuizesID")
                        .HasForeignKey("C4ChapterQuizId");
                });

            modelBuilder.Entity("LMS.Models.Users.U2Login", b =>
                {
                    b.HasOne("LMS.Models.Users.U1UserRoll", "UserRollID")
                        .WithMany("LoginsID")
                        .HasForeignKey("UserRollIDId");

                    b.Navigation("UserRollID");
                });

            modelBuilder.Entity("LMS.Models.Users.U3Admin", b =>
                {
                    b.HasOne("LMS.Models.Users.U1UserRoll", "UserRollID")
                        .WithMany("AdminsID")
                        .HasForeignKey("UserRollIDId");

                    b.Navigation("UserRollID");
                });

            modelBuilder.Entity("LMS.Models.Users.U4Teacher", b =>
                {
                    b.HasOne("LMS.Models.Users.U1UserRoll", "UserRollID")
                        .WithMany("TeachersID")
                        .HasForeignKey("UserRollIDId");

                    b.Navigation("UserRollID");
                });

            modelBuilder.Entity("LMS.Models.Users.U5Student", b =>
                {
                    b.HasOne("LMS.Models.Users.U1UserRoll", "UserRollID")
                        .WithMany("StudentsID")
                        .HasForeignKey("UserRollIDId");

                    b.Navigation("UserRollID");
                });

            modelBuilder.Entity("LMS.Models.Courses.C1Course", b =>
                {
                    b.Navigation("ChapterID");
                });

            modelBuilder.Entity("LMS.Models.Courses.C2Chapter", b =>
                {
                    b.Navigation("ChapterContentID");
                });

            modelBuilder.Entity("LMS.Models.Courses.C3ChapterContent", b =>
                {
                    b.Navigation("ChapterQuizesID");
                });

            modelBuilder.Entity("LMS.Models.Courses.C4ChapterQuiz", b =>
                {
                    b.Navigation("QuizesID");
                });

            modelBuilder.Entity("LMS.Models.Users.U1UserRoll", b =>
                {
                    b.Navigation("AdminsID");

                    b.Navigation("LoginsID");

                    b.Navigation("StudentsID");

                    b.Navigation("TeachersID");
                });

            modelBuilder.Entity("LMS.Models.Users.U4Teacher", b =>
                {
                    b.Navigation("CoursesID");
                });

            modelBuilder.Entity("LMS.Models.Users.U5Student", b =>
                {
                    b.Navigation("CoursesID");
                });
#pragma warning restore 612, 618
        }
    }
}
