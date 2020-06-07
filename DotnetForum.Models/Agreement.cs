using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotnetForum.Models
{
    [Table("agreements")]
    public class Agreement : BaseEntity
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AgreementId { get; set; }

        [Column("effective_datetime")]
        public DateTime EffectiveDateTime { get; set; }

        [Column("lang_region")]
        [Required(AllowEmptyStrings = false)]
        public string LanguageRegion { get; set; }

        [Column("statements")]
        [Required(AllowEmptyStrings = false)]
        public string Statements { get; set; }

        [Column("version")]
        public int Version { get; set; }
    }
}
