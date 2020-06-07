using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetForum.Data.Models
{
    [Table("messages")]
    public class Message : BaseEntity
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MessageId { get; set; }

        [Column("message")]
        [Required(AllowEmptyStrings = false)]
        public string Text { get; set; }

        public virtual Member From { get; set; }
        public virtual Member To { get; set; }
    }
}
