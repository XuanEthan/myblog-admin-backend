using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace MyBlogAdminService.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string? ImagePath { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Content is required.")]
        public string? Content { get; set; }

        public DateTime? Created { get; set; }

        public ICollection<Category>? Categories { get; set; } = new List<Category>();

        public ICollection<Tag>? Tags { get; set; } = new List<Tag>();
    }
}
