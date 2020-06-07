using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetForum.Data.Models
{
    [Table("tags")]
    public class Tag : BaseEntity
    {
        [Key]
        [Column("tag_name")]
        [Required(AllowEmptyStrings = false)]
        public string TagName { get; set; }

        public List<PostTag> PostTags { get; set; }
    }
}
