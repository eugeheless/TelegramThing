using Microsoft.EntityFrameworkCore.Migrations;

namespace Telegram.Infrastructure.Migrations
{
    public partial class Try : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserConversation_Conversations_ConversationId",
                table: "UserConversation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserConversation",
                table: "UserConversation");

            migrationBuilder.DropIndex(
                name: "IX_UserConversation_ConversationId",
                table: "UserConversation");

            migrationBuilder.DropColumn(
                name: "ConversationId",
                table: "UserConversation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserConversation",
                table: "UserConversation",
                columns: new[] { "UserId", "ConversId" });

            migrationBuilder.CreateIndex(
                name: "IX_UserConversation_ConversId",
                table: "UserConversation",
                column: "ConversId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserConversation_Conversations_ConversId",
                table: "UserConversation",
                column: "ConversId",
                principalTable: "Conversations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserConversation_Conversations_ConversId",
                table: "UserConversation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserConversation",
                table: "UserConversation");

            migrationBuilder.DropIndex(
                name: "IX_UserConversation_ConversId",
                table: "UserConversation");

            migrationBuilder.AddColumn<int>(
                name: "ConversationId",
                table: "UserConversation",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserConversation",
                table: "UserConversation",
                columns: new[] { "UserId", "MessageId" });

            migrationBuilder.CreateIndex(
                name: "IX_UserConversation_ConversationId",
                table: "UserConversation",
                column: "ConversationId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserConversation_Conversations_ConversationId",
                table: "UserConversation",
                column: "ConversationId",
                principalTable: "Conversations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
