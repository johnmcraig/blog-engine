﻿// <auto-generated />
using BlogApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BlogApp.Migrations
{
    [DbContext(typeof(BloggingDbContext))]
    [Migration("20171214003026_AddedPostCategory")]
    partial class AddedPostCategory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogApp.Models.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<int>("Rating");

                    b.Property<string>("Url");

                    b.HasKey("BlogId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("BlogApp.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlogId");

                    b.Property<string>("Content");

                    b.Property<int>("PostCategoryId");

                    b.Property<string>("Title");

                    b.HasKey("PostId");

                    b.HasIndex("BlogId");

                    b.HasIndex("PostCategoryId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("BlogApp.Models.PostCategory", b =>
                {
                    b.Property<int>("PostCategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("PostCategoryId");

                    b.ToTable("PostCategory");
                });

            modelBuilder.Entity("BlogApp.Models.Post", b =>
                {
                    b.HasOne("BlogApp.Models.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BlogApp.Models.PostCategory", "PostCategory")
                        .WithMany()
                        .HasForeignKey("PostCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
