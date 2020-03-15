using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignmentPromact.Migrations
{
    public partial class DeletedtwoRows : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "posts",
                keyColumn: "Post_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "posts",
                keyColumn: "Post_Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "comments",
                keyColumn: "Comment_Id",
                keyValue: 1,
                column: "comments",
                value: "Reply To Your Post");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "comments",
                keyColumn: "Comment_Id",
                keyValue: 1,
                column: "comments",
                value: "Reply To You Post");

            migrationBuilder.InsertData(
                table: "posts",
                columns: new[] { "Post_Id", "Comments", "Likes", "Post", "userID" },
                values: new object[] { 4, 16, 0, "Stay Still...There's More To Come..", "visu@21" });

            migrationBuilder.InsertData(
                table: "posts",
                columns: new[] { "Post_Id", "Comments", "Likes", "Post", "userID" },
                values: new object[] { 3, 5, 0, "Thankyou For Reading My First Post", "sweta@26" });
        }
    }
}
