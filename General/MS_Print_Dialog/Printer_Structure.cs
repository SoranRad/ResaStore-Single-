using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Print_Dialog
{
    public class Printer_Structure
    {
        public enum Extended_Printer_Status : int
        {
            سایر_حالات = 0,
            نامشخص = 1,
            آماده_چاپ = 2,
            درحال_چـاپ = 3,
            هشـدار = 5,
            توقف_چاپ = 6,
            آفلاین = 7,
            حالت_مکس = 8,
            خـطا = 9,
            مشغـول = 10,
            وجود_ندارد = 11,
            درحال_انتظار = 12,
            درحال_پردازش = 13,
            در_حال_بارگذاری = 14,
            روشن = 15,
            درحـال_حذف = 16,
            ورودی_خروجی_فعال = 17,
            حالت_دستی = 18,
        };
    }
}
