using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetForum.Data.Models
{
    [Table("members")]
    public class Member : IdentityUser<int>
    {
        [Column("inactive_datetime")]
        public DateTime? InactiveDateTime { get; set; }

        [Column("profile_image_url")]
        [Required(AllowEmptyStrings = true)]
        public string ProfileImageUrl { get; set; }

        [Column("member_description")]
        [Required(AllowEmptyStrings = true)]
        public string MemberDescription { get; set; }

        [Column("rating")]
        public int Rating { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; }

        [Column("is_admin")]
        public bool IsAdmin { get; set; }

        [Column("member_since")]
        public DateTime MemberSince { get; set; }

        public List<MemberAgreement> MemberAgreements { get; set; }

        public List<Post> Posts { get; set; }
    }
}
