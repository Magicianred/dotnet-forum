using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetForum.Models
{
    [Table("users")]
    public class User : IdentityUser
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Column("inactive_datetime")]
        public DateTime? InactiveDateTime { get; set; }

        public List<UserAgreement> UserAgreements { get; set; }

        public List<Post> Posts { get; set; }
    }
}
