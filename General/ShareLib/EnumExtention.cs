using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib
{
    public static class EnumExtention
    {
        public static string NzToString (this Enums.NzStorageKind           Kind)
        {
            switch (Kind)
            {
                case Enums.NzStorageKind.Avg:
                    return "میانگین";
                case Enums.NzStorageKind.FiFo:
                    return "FiFo";
                case Enums.NzStorageKind.LiFo:
                    return "LiFo";
                default:
                    return Kind.ToString();
            }
        }
        public static string NzTostring (this Enums.NzObjectKind            Kind)
        {
            switch (Kind)
            {
                case Enums.NzObjectKind.Object:
                    return "کالا";
                case Enums.NzObjectKind.Service:
                    return "خدمات";
                default:
                    return Kind.ToString();
            }
        }
        public static string NzTostring(this Enums.NzObjectSeason Kind)
        {
            switch (Kind)
            {
                case Enums.NzObjectSeason.Spring:
                    return "بهار";
                case Enums.NzObjectSeason.Summer:
                    return "تابستان";
                case Enums.NzObjectSeason.Autumn:
                    return "پاییز";
                case Enums.NzObjectSeason.Winter:
                    return "زمستان";
                case Enums.NzObjectSeason.General:
                    return "عمومی";
                default:
                    return "";
            }
        }
        public static string NzTostring (this Enums.NzSalingKind            Kind)
        {
            switch (Kind)
            {
                case Enums.NzSalingKind.Normal:
                    return "عادی";
                case Enums.NzSalingKind.Crumbs:
                    return "عمده";
                case Enums.NzSalingKind.Colleague:
                    return "همکاری";
                case Enums.NzSalingKind.Misc:
                    return "متفرقه";
                default:
                    return Kind.ToString();
            }
        }
        public static string NzTostring (this Enums.NzUserKind              Kind)
        {
            switch (Kind)
            {
                case Enums.NzUserKind.Normal:
                    return "کاربرعادی";
                case Enums.NzUserKind.Manager:
                    return "مدیر سیستم";
                case Enums.NzUserKind.Captin:
                    return "کاربر ارشد";
                default:
                    return Kind.ToString();
            }
        }
        public static string NzTostring (this Enums.NzSex                   Kind)
        {
            switch (Kind)
            {
                case Enums.NzSex.Male:
                    return "مرد";
                case Enums.NzSex.Female:
                    return "زن";
                case Enums.NzSex.Other:
                    return "سایر موارد";
                default:
                    return Kind.ToString();
            }
        }
        public static string NzToString (this Enums.NzFactorKind            Kind)
        {
            switch (Kind)
            {
                case Enums.NzFactorKind.PishFaktor:
                    return @"پیش فاکتور ";
                case Enums.NzFactorKind.SefarshFrosh:
                    return @"سفارش فروش";
                case Enums.NzFactorKind.SefareshXarid:
                    return @"سفارش خرید";
                case Enums.NzFactorKind.AvalDore:
                    return @"اول دوره";
                case Enums.NzFactorKind.Xarid:
                    return @"فاکتور خرید";
                case Enums.NzFactorKind.BargshtFrosh:
                    return @"برگشت فروش";
                case Enums.NzFactorKind.BargshtFrosh_Ba_Mabna:
                    return @"برگشت فروش با مبنا";
                case Enums.NzFactorKind.XaridBar:
                    return @"خرید بار";
                case Enums.NzFactorKind.EnteqalBeynAnbarVorud:
                    return @"انتقال بین انبار(ورود)";
                case Enums.NzFactorKind.Frosh:
                    return @"فروش";
                case Enums.NzFactorKind.BargashXarid:
                    return @"برگشت خرید کالا";
                case Enums.NzFactorKind.BargashXarid_Ba_Mabna:
                    return @"برگشت خرید کالا با مبنا";
                case Enums.NzFactorKind.HavaleZayeat:
                    return @"حواله ضایعات";
                case Enums.NzFactorKind.HavaleMasrafi:
                    return @"حواله مصرف";
                case Enums.NzFactorKind.EnteqalBeynAnbarXoruj:
                    return @"انتقال بین انبار(خروج)";
                default:
                    return @"";
            }
        }
        public static string NzToString (this Enums.NzPaymentOperatingKind  Kind)
        {
            switch (Kind)
            {
                case Enums.NzPaymentOperatingKind.Daryaft:
                     return @"دریافت وجوه از اشخاص";
                case Enums.NzPaymentOperatingKind.Pardaxt:
                     return @"پرداخت وجوه به اشخاص";
                case Enums.NzPaymentOperatingKind.Daramad:
                     return @"درآمد";
                case Enums.NzPaymentOperatingKind.Hazine:
                     return @"هـزینه";
                case Enums.NzPaymentOperatingKind.Naql_Enteqal:
                     return @"نقل و انتقال";
                case Enums.NzPaymentOperatingKind.Kosurat:
                     return @"کسورات";
                case Enums.NzPaymentOperatingKind.Addition:
                     return @"اضافات";
                case Enums.NzPaymentOperatingKind.Enteqal_Shaxs:
                     return @"انتقال حساب بین اشخاص";
                case Enums.NzPaymentOperatingKind.Naqd:
                     return @"نقدی";
                case Enums.NzPaymentOperatingKind.Bank_POS:
                     return @"بانکی/کارتخوان";
                case Enums.NzPaymentOperatingKind.RemaindDebit:
                        return @"مانده قبلی ";
                case Enums.NzPaymentOperatingKind.RemaindCredit:
                    return @"مانده قبلی ";
                case Enums.NzPaymentOperatingKind.Cheque:
                    return @"چـک و اسناد بهادار ";
                case Enums.NzPaymentOperatingKind.Off:
                    return @"تخـفیفـات تسویه ";
                case Enums.NzPaymentOperatingKind.AssignCheque:
                    return @"واگذاری چک ";
                case Enums.NzPaymentOperatingKind.chequePayBack:
                    return @"برگشـت چـک ";
                default:
                    return @"";
            }
        }
        public static string NzToString (this Enums.NzChequeStateFlag       Kind)
        {
            switch (Kind)
            {
                case Enums.NzChequeStateFlag.Vosul:
                    return @"وصول شده";
                case Enums.NzChequeStateFlag.Vagozari:
                    return @"واگذار شده به شخص دیگر"; ;
                case Enums.NzChequeStateFlag.Bargasht:
                    return @"برگشت داده شده"; ;
                case Enums.NzChequeStateFlag.Nazd_Sanduq:
                    return @"نزد صندوق"; ;
                default:
                    return "";

            }
        }
        public static string NzToString (this Enums.NzAccountKind           Kind)
        {
            switch (Kind)
            {
                case Enums.NzAccountKind.Cache:
                    return "صندوق و نقدینگی";
                case Enums.NzAccountKind.BankAccount:
                    return "حسـاب بانکی";
                case Enums.NzAccountKind.Income:
                    return "درآمـد متفرقه";
                case Enums.NzAccountKind.Cost:
                    return "هـزینه";
                case Enums.NzAccountKind.Deficit:
                    return "کسـورات حسـاب شخـص";
                case Enums.NzAccountKind.Fund:
                    return "تنـخواه گردان";
                case Enums.NzAccountKind.Addition:
                    return "اضـافات بر حسـاب شخـص";
                default:
                    return "";
            }
        }
    }
}
