using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetForum.Models
{
    [Table("posts")]
    public class Post : BaseEntity
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostId { get; set; }

        [Column("title")]
        [Required(AllowEmptyStrings = false)]
        [MaxLength(128)]
        public string Title { get; set; }

        [Column("body")]
        [Required(AllowEmptyStrings = false)]
        public string Body { get; set; }

        public List<Attachment> Attachments { get; set; }

        public List<PostTag> PostTags { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
