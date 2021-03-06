// <auto-generated />
using System;
using BlogPlatform;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogPlatform.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20210629162917_fixedvideoembed")]
    partial class fixedvideoembed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogPlatform.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "stuff",
                            Name = "TOM",
                            PostId = 2
                        });
                });

            modelBuilder.Entity("BlogPlatform.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Pearl De'Chef",
                            Body = "body1",
                            Link = "https://youtu.be/embed/VkdND06ZY4k",
                            PublishDate = new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Vibe On Air Ep 1"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Ritchie Carlyle",
                            Body = "body2",
                            Link = "https://youtu.be/embed/zTF7LcpWhkI",
                            PublishDate = new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "THe Vibe On Air Ep 2"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Author3",
                            Body = "body3",
                            Link = "https://www.youtube.com",
                            PublishDate = new DateTime(2021, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Vibe On air Ep 3"
                        });
                });

            modelBuilder.Entity("BlogPlatform.Models.Comment", b =>
                {
                    b.HasOne("BlogPlatform.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("BlogPlatform.Models.Post", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
