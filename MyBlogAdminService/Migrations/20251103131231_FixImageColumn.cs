using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlogAdminService.Migrations
{
    /// <inheritdoc />
    public partial class FixImageColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "imageFile",
                table: "Posts",
                newName: "ImageFile");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageFile",
                table: "Posts",
                newName: "imageFile");
        }
    }
}
