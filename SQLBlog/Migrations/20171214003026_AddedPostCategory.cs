using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BlogApp.Migrations
{
    public partial class AddedPostCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PostCategoryId",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PostCategory",
                columns: table => new
                {
                    PostCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostCategory", x => x.PostCategoryId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostCategoryId",
                table: "Posts",
                column: "PostCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_PostCategory_PostCategoryId",
                table: "Posts",
                column: "PostCategoryId",
                principalTable: "PostCategory",
                principalColumn: "PostCategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_PostCategory_PostCategoryId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "PostCategory");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PostCategoryId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostCategoryId",
                table: "Posts");
        }
    }
}
