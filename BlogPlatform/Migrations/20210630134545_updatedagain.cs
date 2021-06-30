using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class updatedagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "The Vibe On Air Ep 2");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Link", "PublishDate", "Title" },
                values: new object[] { "R&B GroupTwice", "https://www.youtube.com/embed/Kh8-ekuRmoI", new DateTime(2021, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Vibe On Air Ep 3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "THe Vibe On Air Ep 2");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Link", "PublishDate", "Title" },
                values: new object[] { "Author3", "https://www.youtube.com", new DateTime(2021, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Vibe On air Ep 3" });
        }
    }
}
