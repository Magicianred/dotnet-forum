using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetForum.Data.Models
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

        [Column("upvote")]
        public int Upvote { get; set; }

        [Column("downvote")]
        public int Downvote { get; set; }

        [Column("archived")]
        public bool Archived { get; set; }

        public List<Attachment> Attachments { get; set; }

        public List<PostTag> PostTags { get; set; }

        public List<Reply> Replies { get; set; }

        public int ForumId { get; set; }
        public Forum Forum { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}
