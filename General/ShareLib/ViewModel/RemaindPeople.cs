using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib.ViewModel
{
    public class RemaindPeople
    {
        public long            ID            { get; set; }
        public short           FK_Group      { get; set; }
        public byte            kind          { get; set; }
        public int             code          { get; set; }
        public string          Title         { get; set; }
        public string          namePedar     { get; set; }
        public string          codeMeli      { get; set; }
        public string          tel           { get; set; }
        public string          mobile        { get; set; }
        public string          GroupTitle    { get; set; }
        public decimal         Balance       { get; set; }

        public string BalanceTitle
        {
            get
            {
                if (Balance > 0)
                    return "بدهکار";

                return Balance < 0 ? "بستانکار" : "بی حساب";
            }
        }
    }
}
