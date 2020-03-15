using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignmentPromact.Migrations
{
    public partial class SecondSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_posts_Post_Id1",
                table: "comments");

            migrationBuilder.DropIndex(
                name: "IX_comments_Post_Id1",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "Post_Id1",
                table: "comments");

            migrationBuilder.AddColumn<int>(
                name: "Post_Id",
                table: "comments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PostsPost_Id",
                table: "comments",
                nullable: true);

            migrationBuilder.InsertData(
                table: "comments",
                columns: new[] { "Comment_Id", "Post_Id", "PostsPost_Id", "comments" },
                values: new object[,]
                {
                    { 1, 1, null, "Reply To You Post" },
                    { 2, 2, null, "Reply To Your second Post" },
                    { 3, 1, null, "Reply To Your third Post" },
                    { 4, 3, null, "Reply To Your  Post" },
                    { 5, 4, null, "Reply To You Post" },
                    { 6, 2, null, "Reply To the Post" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_comments_PostsPost_Id",
                table: "comments",
                column: "PostsPost_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_comments_posts_PostsPost_Id",
                table: "comments",
                column: "PostsPost_Id",
                principalTable: "posts",
                principalColumn: "Post_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_posts_PostsPost_Id",
                table: "comments");

            migrationBuilder.DropIndex(
                name: "IX_comments_PostsPost_Id",
                table: "comments");

            migrationBuilder.DeleteData(
                table: "comments",
                keyColumn: "Comment_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "comments",
                keyColumn: "Comment_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "comments",
                keyColumn: "Comment_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "comments",
                keyColumn: "Comment_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "comments",
                keyColumn: "Comment_Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "comments",
                keyColumn: "Comment_Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "Post_Id",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "PostsPost_Id",
                table: "comments");

            migrationBuilder.AddColumn<int>(
                name: "Post_Id1",
                table: "comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_comments_Post_Id1",
                table: "comments",
                column: "Post_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_comments_posts_Post_Id1",
                table: "comments",
                column: "Post_Id1",
                principalTable: "posts",
                principalColumn: "Post_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
