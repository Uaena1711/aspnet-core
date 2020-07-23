using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static tmss.Customers.CusEnum;

namespace tmss.Customers
{
    [Table("Customer")]
    public class Customer : FullAuditedEntity 
    {
        [Key]
        [MaxLength(30)]
        public virtual int Id { set; get; }
        [Required]
        public virtual CustTypeItem CustType { set; get; }

        //public BizFieldScale

        //public ContactPerson
        [MaxLength(50)]
        public virtual string Owner { set; get; }

        [Required]
        [MaxLength(30)]
        public virtual string CustName { set; get; }

        [Required]
        [MaxLength(12)]
        public virtual string CustTel { set; get; }

        [Required]
        [MaxLength(90)]
        public virtual string CustDetailAddress { set; get; }

        [Required]
        public virtual CustSourceItem CustSource { set; get; }

        [Required]
        [MaxLength(10)]
        public virtual int ProvincaId { set; get; }

        [Required]
        [MaxLength(10)]
        public virtual int DistrictId { set; get; }

        [Required]
        public virtual HotnessItem Hotness { set; get; }

        [Required]
        public virtual ExpectedDelTimeItem ExpectedDelTime { set; get; }

        [Required]
        public virtual PaymentItem Payment { set; get; }

        public virtual DateTime DateOfBirth { set; get; }

        public virtual GenderItem Gender { set; get; }

        public virtual MaritalStatusItem MaritalStatus { set; get; }

        [MaxLength(50)]
        public virtual string Email { set; get; }

        [MaxLength(50)]
        public virtual string Occupation { set; get; }

        [MaxLength(50)]
        public virtual int  Income { set; get; }

        public virtual HobbyItem Hobby { set; get; }

        public virtual SocialChannelItem SocialChannel { set; get; }

        [MaxLength(20)]
        public virtual string SocialID { set; get; }

        public virtual DateTime Date { set; get; }

        public virtual string DrinkFood { set; get; }
    }
}
