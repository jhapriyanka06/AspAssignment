using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignmentPromact.Migrations
{
    public partial class RemovedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "userID",
                table: "posts",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Post_Id",
                keyValue: 1,
                column: "Likes",
                value: 0);

            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Post_Id",
                keyValue: 2,
                column: "Likes",
                value: 0);

            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Post_Id",
                keyValue: 3,
                column: "Likes",
                value: 0);

            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Post_Id",
                keyValue: 4,
                column: "Likes",
                value: 0);

            migrationBuilder.CreateIndex(
                name: "IX_posts_userID",
                table: "posts",
                column: "userID");

            migrationBuilder.AddForeignKey(
                name: "FK_posts_users_userID",
                table: "posts",
                column: "userID",
                principalTable: "users",
                principalColumn: "userID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_posts_users_userID",
                table: "posts");

            migrationBuilder.DropIndex(
                name: "IX_posts_userID",
                table: "posts");

            migrationBuilder.AlterColumn<string>(
                name: "userID",
                table: "posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Post_Id",
                keyValue: 1,
                column: "Likes",
                value: 5);

            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Post_Id",
                keyValue: 2,
                column: "Likes",
                value: 5);

            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Post_Id",
                keyValue: 3,
                column: "Likes",
                value: 9);

            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Post_Id",
                keyValue: 4,
                column: "Likes",
                value: 25);
        }
    }
}
