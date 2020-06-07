using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotnetForum.Models
{
    [Table("user_agreements")]
    public class UserAgreement : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int AgreementId { get; set; }
        public Agreement Agreement { get; set; }
    }
}
