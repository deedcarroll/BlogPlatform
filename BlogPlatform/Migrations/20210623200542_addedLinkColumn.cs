using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class addedLinkColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    PublishDate = table.Column<DateTime>(nullable: false),
                    Link = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PostId = table.Column<int>(nullable: false),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "Body", "Link", "PublishDate", "Title" },
                values: new object[] { 1, "Author1", "body1", "https://www.youtube.com", new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Vibe On Air Ep 1" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "Body", "Link", "PublishDate", "Title" },
                values: new object[] { 2, "Author2", "body2", "https://www.youtube.com", new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "THe Vibe On Air Ep 2" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "Body", "Link", "PublishDate", "Title" },
                values: new object[] { 3, "Author3", "body3", "https://www.youtube.com", new DateTime(2021, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Vibe On air Ep 3" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "Name", "PostId" },
                values: new object[] { 1, "stuff", "TOM", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
