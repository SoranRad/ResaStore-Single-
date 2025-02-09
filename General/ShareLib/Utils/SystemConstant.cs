using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Models;
using ShareLib.ViewModel;

namespace ShareLib.Utils
{
    public static class SystemConstant
    {
        #region Property
        public static Year          ActiveYear;
        public static Company       ActiveCompany;
        public static User          ActiveUser;

        public static byte          NzMainGroupCodeLen   = 1;
        public static byte          NzSubGroupCodeLen    = 2;
        public static byte          NzObjectCodeLen      = 4;
        public static byte          NzPeopleCodeLen      = 5;

        public static string        NzPasswordHash       = "NzDecript@";
        public static string        BkImageName          = "Bk.jpg";
        public static int           DbCount              = 0;
        public static IEnumerable<DataBaseList> DBList   = null;
        public static string        Version;

        public static bool          OurAccount           = false;

        public static bool          IsDemo               = false;
        public static int           DemoCount            = 50;

        public static bool          HasVahedFari         = true;
        public static bool          AllowMultipleDatabase = true;

        #endregion
    }
}
