using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetForum.Models
{
    [Table("posts_tags")]
    public class PostTag
    {
        public int PostId { get; set; }
        public Post Post { get; set; }

        public string TagName { get; set; }
        public Tag Tag { get; set; }
    }
}
