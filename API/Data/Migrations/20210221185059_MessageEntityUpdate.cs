using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class MessageEntityUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_RecipentId",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "content",
                table: "Messages",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "RecipentId",
                table: "Messages",
                newName: "RecipientId");

            migrationBuilder.RenameColumn(
                name: "RecipentDeleted",
                table: "Messages",
                newName: "RecipientDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_RecipentId",
                table: "Messages",
                newName: "IX_Messages_RecipientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_RecipientId",
                table: "Messages",
                column: "RecipientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_RecipientId",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Messages",
                newName: "content");

            migrationBuilder.RenameColumn(
                name: "RecipientId",
                table: "Messages",
                newName: "RecipentId");

            migrationBuilder.RenameColumn(
                name: "RecipientDeleted",
                table: "Messages",
                newName: "RecipentDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_RecipientId",
                table: "Messages",
                newName: "IX_Messages_RecipentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_RecipentId",
                table: "Messages",
                column: "RecipentId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
