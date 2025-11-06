using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlogAdminService.Migrations
{
    /// <inheritdoc />
    public partial class ReplaceImageContentColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageBytes",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "imagePath",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imagePath",
                table: "Posts");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageBytes",
                table: "Posts",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
