using MS_Control;
using MS_Control.Tarikh;
using MS_Print_Dialog;
using Nz.Bar.Business;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Nz.Aqsat.Winforms.Print
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
