using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_writer_blog_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "writerId",
                table: "Blogs",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_writerId",
                table: "Blogs",
                column: "writerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Writers_writerId",
                table: "Blogs",
                column: "writerId",
                principalTable: "Writers",
                principalColumn: "WriterId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Writers_writerId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_writerId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "writerId",
                table: "Blogs");
        }
    }
}
