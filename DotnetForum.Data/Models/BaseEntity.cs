using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetForum.Data.Models
{
    public abstract class BaseEntity
    {
        [Column("created_datetime_utc")]
        [Required]
        public DateTime CreatedDateTimeUtc { get; set; }

        [Column("last_modified_datetime_utc")]
        public DateTime? LastModifiedDateTimeUtc { get; set; }
    }
}
