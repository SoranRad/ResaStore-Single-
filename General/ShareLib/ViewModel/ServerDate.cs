using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS_Control.Tarikh;
using ShareLib.Interfaces;

namespace ShareLib.ViewModel
{
    public class ServerDate :ISqlQueryMaker
    {
        public DateTime     Date            { get; set; }
        public string       ShortPersian    => new MS_Structure_Shamsi(this.Date).ToShamsi();
        public string       LongPersina     
        {
            get
            {
                var p   = new MS_Structure_Shamsi(this.Date);
                var str = p.RozOfHafteh() + " " 
                        + p._Mah + " " 
                        + p.Mah_name_persian() + " " 
                        + p._Sal ;

                return str;
            }
        }

        public string       GetItem()
        {
            return @"SELECT GETDATE() AS Date";
        }
        public string       GetList()
        {
            throw new NotImplementedException();
        }
    }
}
