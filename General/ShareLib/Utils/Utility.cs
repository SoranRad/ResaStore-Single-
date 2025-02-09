using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Models;

namespace ShareLib.Utils
{
    public static class Utility
    {
        public static bool IsDateTruth(DateTime Date,Year ActiveYear)
        {
            return Date >= ActiveYear.StartDate && Date <= ActiveYear.EndDate;
        }

        public static string GetPrintDirectory()
        {
            return System
                    .IO
                    .Path
                    .GetDirectoryName
                            (System.Reflection.Assembly.GetExecutingAssembly().Location)
                    + "\\Print\\";
        }

         
    }
}
