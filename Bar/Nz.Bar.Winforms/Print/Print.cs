using MS_Control;
using MS_Control.Tarikh;
using MS_Print_Dialog;
using Nz.Bar.Business;
using Nz.Bar.Model.Report;
using ShareLib;
using ShareLib.Utils;
using Stimulsoft.Editor;
using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.Schedule.Model;

namespace Nz.Bar.Winforms.Print
{
    public class Print
    {
	    private List<long>					_List;
	    private ReportManager               _Manager;
	    private Print_Dialog                _PrintDiag;
	    private List<MS_Report_Loading>     _ListReport;
	    private string                      _ReportPath;
	    private MSWait FrmWait              = new MSWait();

	    [DefaultValue(false)]
	    public bool DirectPrint { get; set; }

	    public Print(List<long> List)
	    {
            _Manager = new ReportManager();
            FrmWait.Show();
            Application.DoEvents();
            _List        = List;
            SetPrintFile    ();
            Load            ();

	    }

	    private void        SetPrintFile    ()
	    {
		    _ReportPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
		    _ReportPath += "\\Print\\Bar\\FactorBar_A5.mrt";
	    }
		private void        Load            ()
        {
            try
            {
	            var whereClause     ="AND ("+ string.Join(" OR ", _List.Select(x => "tbf.ID=" + x)) +") ";
	            var Factors         = _Manager.GetReport<BarFactorList>(new { Year = SystemConstant.ActiveYear.Salmali,Month=13}, whereClause);

                if (Factors == null)
                    throw new Exception();

                var Co                  = SystemConstant.ActiveCompany;

                _ListReport =
                    Factors
                    .GroupBy(x => new
                    {
                        x.ID,
                        x.CarTitle,
                        x.KalaTitle,
                        x.Serial,
                        x.Mablaq,
                        x.MablaqKeraye,
                        x.Nerkh,
                        x.PeopleTitle,
                        x.PersianStr,
                        x.VaznPorMachine,
                        x.VaznKHaliMachine,
                        x.SumKhaliBox,
                        x.TedadBox,
                        x.VaznKhaliBox,
                        x.VaznOft,
                        x.VaznKHales,
                        
                    })
                    .Select(x => new MS_Report_Loading
                    {
                        //BusinessObject_Name = "List",
                        Report_Address      =_ReportPath,

                        //List_Data           = null,
                        List_Parametter     = 
                         new Dictionary<string, object>()
                            {
                                {"company"          , SystemConstant.ActiveCompany.title},
                                {"Serial"           , x.Key.Serial.ToString()},
                                {"PersianStr"       , x.Key.PersianStr},
                                {"VaznPorMachine"   , x.Key.VaznPorMachine},
                                {"VaznKHaliMachine" , x.Key.VaznKHaliMachine},
                                {"TedadBox"         , x.Key.TedadBox},

                                {"VaznKhaliBox"     , x.Key.SumKhaliBox},
                                {"VaznOft"          , x.Key.VaznOft},
                                {"VaznKHales"       , x.Key.VaznKHales},
                                {"Nerkh"            , x.Key.Nerkh},
                                {"Mablaq"           , x.Key.Mablaq},
                                {"CarTitle"         , x.Key.CarTitle},

                                {"PeopleTitle"      , x.Key.PeopleTitle},
                                {"Address"          , Co.address},
                                {"Tozihat"          , Co.molahezat},
                               
                            }
                        
                    })
                    .ToList();
            }
            catch (Exception ex)
            {
                MS_Message.Show("سیستم قادر به لود فاکتور برای چاپ نیست","خطا",ex.Message,MessageBoxButtons.OK);
            }
        }
        public  void        Show            (IWin32Window Frm)
        {
            _PrintDiag = new Print_Dialog(_ListReport);
            FrmWait.Close();
            Print_Dialog._Do_Direct_Print = DirectPrint;
            _PrintDiag.ShowDialog(Frm);
        }
    }
}
