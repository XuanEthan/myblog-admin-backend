using System.ComponentModel.DataAnnotations;

namespace MyBlogAdminService.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string? RoleName { get; set; }
        public ICollection<User>? Users { get; set; }
    }

}
