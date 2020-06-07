using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetForum.Data.Models
{
    [Table("attachments")]
    public class Attachment : BaseEntity
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AttachmentId { get; set; }

        [Column("file_name")]
        [Required(AllowEmptyStrings = false)]
        public string FileName { get; set; }

        [Column("file_size")]
        [Required(AllowEmptyStrings = false)]
        public long FileSize { get; set; }

        [Column("file_content_type")]
        [Required(AllowEmptyStrings = false)]
        public string FileContentType { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
