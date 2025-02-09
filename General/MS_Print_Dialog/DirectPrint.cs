using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS_Control;
using Stimulsoft.Report.Components;
using Janus.Windows.GridEX;
using Stimulsoft.Report;

namespace MS_Print_Dialog
{
    public class DirectPrint
    {
        public DirectPrint( string                      PathReport,
                            Dictionary<string,object>   DataSource, 
                            Dictionary<string, object>  Variables,
                            bool                        Print       = false,
                            bool                        Progress    = false)
        {
            var report = new StiReport();
            report.Load(PathReport);
            if(DataSource!=null)
                foreach (var item in DataSource)
                    report.RegBusinessObject(item.Key, item.Value);
            report.Compile();
            
            if(Variables!= null)
                foreach (var variable in Variables)
                    report[variable.Key] = variable.Value;

            if(Print)
                report.Print(false);
            else 
                report.Show(Progress);
        }

        public DirectPrint(IEnumerable<NzStimulReport> ListReport, bool Print = false, bool Progress = false)
        {
            var MainReport = new StiReport();

            foreach (NzStimulReport items in ListReport)
            {
                Task.Run(() =>
                {
                    var report = new StiReport();
                    report.Load(items.PathReport);
                    if (items.DataSource != null)
                        foreach (var item in items.DataSource)
                            report.RegBusinessObject(item.Key, item.Value);
                    //report.Compile();

                    if (items.Variables != null)
                        foreach (var variable in items.Variables)
                            report[variable.Key] = variable.Value;

                    lock (report)
                    {
                        report.Render();
                    }
                    //report.Render();
                    //report.InvokeBeginRender();

                    //MainReport.Pages.Add();
                    
                    MainReport.RenderedPages.AddRange(report.CompiledReport.RenderedPages);
                    //MainReport.InvokeRefreshViewer();
                    

                });

            }
            MainReport.InvokeRefreshViewer();
            if (Print)
                MainReport.Print(false);
            else
                MainReport.Show(Progress);
        }
    }

    public class NzStimulReport
    {
        public  string                          PathReport     { get; set; }
        public  Dictionary<string, object>      DataSource     { get; set; }
        public  Dictionary<string, object>      Variables      { get; set; }
    }
    
}
