using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace tmss.Customers
{
    public class CusEnum
    {
        public enum CustSourceItem
        {
            [Description("DLR-Online")]
            DLR_Online = 1,
            [Description("DLR-Call-in")]
            DLR_Call_in = 2,
            [Description("DLR-Walk-in")]
            DLR_Walk_in = 3,
            [Description("DLR-Event")]
            DLR_Event = 4,
            [Description("DLR-Existing Customer")]
            DLR_Exist_Customer = 5,
            [Description("DLR-Other")]
            DLR_Other = 6,
            [Description("SP-Online")]
            SP_Online = 7,
            [Description("Sp-Referral")]
            SP_Referral = 8,
            [Description("SP-Feild Visit")]
            SP_Feild_Visit = 9,
            [Description("Sp-Other")]
            SP_Other = 10,
            [Description("TMV-Online")]
            TMV_Online = 11,
            [Description("TMV-Hotline")]
            TMV_HostLine = 12,
            [Description("TMV-Other")]
            TMV_Other = 13,
            [Description("Other")]
            Other = 14
        }
        public enum CustTypeItem
        {
            [Description("Individual")]
            Individual = 1,
            [Description("Company")]
            Company = 2

        }

        public enum HotnessItem
        {
            [Description("Hot")]
            Hot = 1,
            [Description("Warm")]
            Warm = 2,
            [Description("Cold")]
            Cold = 3,
            [Description("Undefine")]
            Undefine = 4

        }

        public enum ExpectedDelTimeItem
        {
            [Description("Withthin 7-10 days")]
            About_One_week = 1,
            [Description("Withthin 1 month")]
            One_month = 2,
            [Description("Withthin 2-3 month")]
            About_two_three_month = 3,
            [Description("More than 3 month")]
            More_than_three = 4,
            [Description("Undefine")]
            Undefine = 5

        }

        public enum PaymentItem
        {
            [Description("Cash")]
            Cash = 1,
            [Description("Bank loan")]
            Bank_Loan = 2,
            [Description("Leasing")]
            Leasing = 3

        }

        public enum GenderItem
        {
            [Description("Male")]
            Male = 1,
            [Description("Female")]
            Female = 2
        }

        public enum MaritalStatusItem
        {
            [Description("Single")]
            Single = 1,
            [Description("Married")]
            Married = 2,
            [Description("Divorced")]
            Divorced = 3,
        }

        public enum HobbyItem
        {
            [Description("Golf")]
            Golf = 1,
            [Description("Làm đẹp")]
            Makeup = 2,
            [Description("Ăn uống")]
            Eating = 3,
            [Description("Giải trí")]
            Relax = 4,
            [Description("Khác")]
            Other = 5
        }

        public enum SocialChannelItem
        {
            [Description("Zalo")]
            Zalo = 1,
            [Description("Facebook")]
            Facebook = 2,
            [Description("Instagram")]
            Instagram = 3
        }

        public enum SocialIdItem
        {
            [Description("Zalo")]
            Zalo = 1,
            [Description("Facebook")]
            Facebook = 2,
            [Description("Viber")]
            Viber = 3,
            [Description("Instagram")]
            Instagram = 4

        }
    }
}
