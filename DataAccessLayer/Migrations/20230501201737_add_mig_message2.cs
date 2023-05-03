using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class add_mig_message2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages2",
                columns: table => new
                {
                    messageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    senderId = table.Column<int>(type: "int", nullable: true),
                    receiverId = table.Column<int>(type: "int", nullable: true),
                    subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    messageDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    messageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    messageStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages2", x => x.messageId);
                    table.ForeignKey(
                        name: "FK_Messages2_Writers_receiverId",
                        column: x => x.receiverId,
                        principalTable: "Writers",
                        principalColumn: "WriterId");
                    table.ForeignKey(
                        name: "FK_Messages2_Writers_senderId",
                        column: x => x.senderId,
                        principalTable: "Writers",
                        principalColumn: "WriterId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages2_receiverId",
                table: "Messages2",
                column: "receiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages2_senderId",
                table: "Messages2",
                column: "senderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages2");
        }
    }
}
