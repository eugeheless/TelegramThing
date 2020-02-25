using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Telegram.Infrastructure.Migrations
{
    public partial class FinallyDone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conversations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConvName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserConversation",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    ConversId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserConversation", x => new { x.UserId, x.ConversId });
                    table.ForeignKey(
                        name: "FK_UserConversation_Conversations_ConversId",
                        column: x => x.ConversId,
                        principalTable: "Conversations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserConversation_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SendTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    UserConversationId = table.Column<int>(nullable: false),
                    UserConversation1Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_UserConversation_UserConversationId_UserConversation1Id",
                        columns: x => new { x.UserConversationId, x.UserConversation1Id },
                        principalTable: "UserConversation",
                        principalColumns: new[] { "UserId", "ConversId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserConversationId_UserConversation1Id",
                table: "Messages",
                columns: new[] { "UserConversationId", "UserConversation1Id" });

            migrationBuilder.CreateIndex(
                name: "IX_UserConversation_ConversId",
                table: "UserConversation",
                column: "ConversId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "UserConversation");

            migrationBuilder.DropTable(
                name: "Conversations");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
