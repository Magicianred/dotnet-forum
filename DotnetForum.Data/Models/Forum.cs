using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetForum.Data.Models
{
    [Table("forums")]
    public class Forum : BaseEntity
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ForumId { get; set; }

        [Column("forum_name")]
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Column("description")]
        [Required(AllowEmptyStrings = false)]
        public string Description { get; set; }

        [Column("image_url")]
        public string ImageUrl { get; set; }

        public List<Post> Posts { get; set; }
    }
}
