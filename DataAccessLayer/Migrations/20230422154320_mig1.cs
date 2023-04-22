using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    aboutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aboutDetails1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aboutDetails2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aboutImage1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aboutImage2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aboutMapLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aboutStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.aboutId);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    blogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    blogTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    blogContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    blogThumbnailImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bloglImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    blogCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    blogStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.blogId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    categoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoryStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    commentUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    commentTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    commentContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    commentCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    commentStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    contactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    contactUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contactMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contactSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contactMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contactDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    contactStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.contactId);
                });

            migrationBuilder.CreateTable(
                name: "Writers",
                columns: table => new
                {
                    WriterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    writerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    writerAbout = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    writerImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    writerMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    writerPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    writerStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writers", x => x.WriterId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Writers");
        }
    }
}
