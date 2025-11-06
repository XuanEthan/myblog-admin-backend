using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlogAdminService.Migrations
{
    /// <inheritdoc />
    public partial class FixImageColumn2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageFile",
                table: "Posts",
                newName: "ImageBytes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageBytes",
                table: "Posts",
                newName: "ImageFile");
        }
    }
}
