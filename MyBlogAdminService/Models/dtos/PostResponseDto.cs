namespace MyBlogAdminService.Models.dtos
{
    public class PostResponseDto
    {
        public int Id { get; set; }
        public string? ImagePath { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public ICollection<int>? CategoryIds { get; set; }
        public ICollection<int>? TagIds { get; set; }
    }
}
