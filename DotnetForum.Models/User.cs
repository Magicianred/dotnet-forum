using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetForum.Models
{
    [Table("users")]
    public class User : BaseEntity
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Column("username")]
        [Required(AllowEmptyStrings = false)]
        public string UserName { get; set; }

        [Column("password_hash")]
        [Required(AllowEmptyStrings = false)]
        public string PasswordHash { get; set; }

        [Column("email")]
        [Required(AllowEmptyStrings = false)]
        public string Email { get; set; }

        public List<Post> Posts { get; set; }
    }
}
