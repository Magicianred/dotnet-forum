using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetForum.Data.Models
{
    [Table("member_agreements")]
    public class MemberAgreement : BaseEntity
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; }

        public int AgreementId { get; set; }
        public Agreement Agreement { get; set; }
    }
}
