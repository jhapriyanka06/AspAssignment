using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignmentPromact.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "posts",
                columns: new[] { "Post_Id", "Comments", "Likes", "Post", "userID" },
                values: new object[,]
                {
                    { 1, 6, 5, "This Is My First Post...Thankyou", "jha@06" },
                    { 2, 8, 5, "This Is Shusnavi's First Post...Thankyou", "shus@16" },
                    { 3, 5, 9, "Thankyou For Reading My First Post", "sweta@26" },
                    { 4, 16, 25, "Stay Still...There's More To Come..", "visu@21" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "posts",
                keyColumn: "Post_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "posts",
                keyColumn: "Post_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "posts",
                keyColumn: "Post_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "posts",
                keyColumn: "Post_Id",
                keyValue: 4);
        }
    }
}
