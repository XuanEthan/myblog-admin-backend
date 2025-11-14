using Azure.Identity;

namespace MyBlogAdminService.Models.Dtos.User
{
    public class LoginDto
    {
        public string? UserName {  get; set; }
        public string? Password { get; set; }
    }
}
