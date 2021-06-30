using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class addvideo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Link", "PublishDate" },
                values: new object[] { "Pearl De'Chef", "https://youtu.be/VkdND06ZY4k", new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Link", "PublishDate" },
                values: new object[] { "Ritchie Carlyle", "https://youtu.be/zTF7LcpWhkI", new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Link", "PublishDate" },
                values: new object[] { "Author1", "https://www.youtube.com", new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Link", "PublishDate" },
                values: new object[] { "Author2", "https://www.youtube.com", new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
