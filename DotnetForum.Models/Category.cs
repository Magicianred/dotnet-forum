using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetForum.Models
{
    [Table("categories")]
    public class Category : BaseEntity
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        [Column("username")]
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        public List<Post> Posts { get; set; }
    }
}
