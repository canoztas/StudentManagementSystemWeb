// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentManagementSystemAPI.Data;

#nullable disable

namespace StudentManagementSystemAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230112092257_AddAuth")]
    partial class AddAuth
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentManagementSystemAPI.Models.Grade", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradeId"));

                    b.Property<int>("LecturerId")
                        .HasColumnType("int");

                    b.Property<string>("LessonDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LessonName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("GradeId");

                    b.ToTable("Grades");

                    b.HasData(
                        new
                        {
                            GradeId = 1,
                            LecturerId = 2,
                            LessonDate = "monday",
                            LessonName = "Maths",
                            Score = 78,
                            StudentId = 1
                        },
                        new
                        {
                            GradeId = 2,
                            LecturerId = 2,
                            LessonDate = "tuesday",
                            LessonName = "Intro to CS",
                            Score = 77,
                            StudentId = 1
                        },
                        new
                        {
                            GradeId = 3,
                            LecturerId = 4,
                            LessonDate = "tuesday",
                            LessonName = "Flutter",
                            Score = 12,
                            StudentId = 3
                        },
                        new
                        {
                            GradeId = 4,
                            LecturerId = 4,
                            LessonDate = "friday",
                            LessonName = "Intro to Network",
                            Score = 77,
                            StudentId = 1
                        },
                        new
                        {
                            GradeId = 5,
                            LecturerId = 4,
                            LessonDate = "friday",
                            LessonName = "Intro to Network",
                            Score = 31,
                            StudentId = 3
                        });
                });

            modelBuilder.Entity("StudentManagementSystemAPI.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "jon@snow.com",
                            FirstName = "Jon",
                            LastName = "Snow",
                            PasswordHash = "6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b",
                            PhotoPath = "https://avatars.githubusercontent.com/u/59293768?v=4",
                            UserType = "student"
                        },
                        new
                        {
                            UserId = 2,
                            Email = "jon@jon.com",
                            FirstName = "Jon",
                            LastName = "Stark",
                            PasswordHash = "6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b",
                            PhotoPath = "https://avatars.githubusercontent.com/u/59293768?v=4",
                            UserType = "lecturer"
                        },
                        new
                        {
                            UserId = 3,
                            Email = "hakan",
                            FirstName = "Hakan",
                            LastName = "Stark",
                            PasswordHash = "6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b",
                            PhotoPath = "https://i.hbrcdn.com/haber/2022/03/03/kolpacino-ekrem-abi-kimdir-abidin-yerebakan-14770711_6916_amp.jpg",
                            UserType = "student"
                        },
                        new
                        {
                            UserId = 4,
                            Email = "hakan",
                            FirstName = "Hakan",
                            LastName = "targaryen",
                            PasswordHash = "d4735e3a265e16eee03f59718b9b5d03019c07d8b6c51f90da3a666eec13ab35",
                            PhotoPath = "https://i.hbrcdn.com/haber/2022/03/03/kolpacino-ekrem-abi-kimdir-abidin-yerebakan-14770711_6916_amp.jpg",
                            UserType = "lecturer"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
