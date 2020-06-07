using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotnetForum.Models
{
    [Table("replies")]
    public class Reply : BaseEntity
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReplyId { get; set; }

        [Column("message")]
        [Required(AllowEmptyStrings = false)]
        public string Message { get; set; }

        [Column("upvote")]
        public int Upvote { get; set; }

        [Column("downvote")]
        public int Downvote { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
