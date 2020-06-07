using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotnetForum.Models
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

        public virtual User From { get; set; }
        public virtual User To { get; set; }
    }
}
