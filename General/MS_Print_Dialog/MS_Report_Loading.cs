using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Stimulsoft.Report;

namespace MS_Print_Dialog
{
    public class MS_Report_Loading
    {
        public StiReport        _Report;
        public bool             _Loaded = false, 
                                _Rendered = false;
        private delegate void   Render_Delegate();

        public string           Report_Address          { get; set; }
        public string           BusinessObject_Name     { get; set; }
        public object           List_Data               { get; set; }
        public Dictionary<string,object> List_Parametter { get; set; }

        public MS_Report_Loading()
        {
            _Report = new StiReport();
        }

        public void Load()
        {
            _Report.Load(Report_Address);
            _Report.RegBusinessObject(BusinessObject_Name, List_Data);
            _Report.Compile();
        }

        public void Render()
        {
            foreach (KeyValuePair<string, object> parametter in List_Parametter)
                _Report[parametter.Key] = parametter.Value;

            _Report.Render(false);
        }
    }
}
