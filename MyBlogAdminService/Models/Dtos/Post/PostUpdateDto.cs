using System.ComponentModel.DataAnnotations;

namespace MyBlogAdminService.Models.Dtos.PostDtos
{
    public class PostUpdateDto
    {
        public int Id { get; set; }
        public IFormFile? ImageFile { get; set; } = null;

        [Required(ErrorMessage = "Title is required.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Content is required.")]
        public string? Content { get; set; }
        public ICollection<int>? CategoryIds { get; set; } = new List<int>();
        public ICollection<int>? TagIds { get; set; } = new List<int>();
    }
}
