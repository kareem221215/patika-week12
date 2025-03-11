using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace Code_First_Relation.Modles
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
