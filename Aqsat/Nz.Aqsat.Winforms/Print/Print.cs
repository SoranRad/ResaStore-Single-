using MS_Control;
using MS_Control.Tarikh;
using MS_Print_Dialog;
using Nz.Aqsat.Business;
using ShareLib.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Nz.Aqsat.Model.Report;
using ShareLib;

namespace Nz.Aqsat.Winforms.Print
{
    public class Print
    {
	    private List<long>					_List;
	    private Print_Dialog                _PrintDiag;
	    private List<MS_Report_Loading>     _ListReport;
	    private string                      _ReportPath;
	    private MSWait FrmWait              = new MSWait();

	    [DefaultValue(false)]
	    public bool DirectPrint { get; set; }

	    public Print(List<long> List)
	    {
            FrmWait.Show();
            Application.DoEvents();
            _List        = List;
            SetPrintFile    ();
            Load            ();

	    }

	    private void        SetPrintFile    ()
	    {
		    _ReportPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
		    _ReportPath += "\\Print\\Aqsat\\AqsatNote.mrt";
	    }
		private void        Load            ()
        {
			try
			{
				var OrStatment	= string.Join(" OR ", _List.Select(x => "tam.ID=" + x));
				var mgr			= new ReportManager();
				var Aqsats		= mgr.GetReport<PrintAqsatNote>(null,OrStatment);

				if (Aqsats == null)
					throw new Exception();
				 
				_ListReport =
					Aqsats
					.GroupBy(x => new
					{
						x.ID,
						x.ShaxsTitle			,
						x.ShaxsMobile			,
						x.ZamenTitle			,
						x.ZamenMobile			,
						x.NohTitle				,
						x.PersianTarixSodur		,
						x.PersianStartDate		,
						x.Serial				,
						x.DoreQest				,
						x.MablaqAqsat			,
						x.MablaqPishpardaxt		,
						x.MablaqMandeAqsat		,
						x.DarsadSoud			,
						x.MablaqSoud			,
						x.MablaqFinalAqsat		,
						x.TedadAqsat			,
						x.Sharh					,
					})
					.Select(x => new MS_Report_Loading
					{
						BusinessObject_Name = "List",
						Report_Address = _ReportPath,

						List_Data = x.Select(y => new
						{
							y.Id_Radif,
							y.Radif,
							y.PersianTarixQest,
							y.mablaqQest,

						}).OrderBy(y => y.Radif).ThenBy(y => y.PersianTarixQest),
						List_Parametter = new Dictionary<string, object>()
								   {
									   {"Company"						, SystemConstant.ActiveCompany.title},
									   {"mola"							, SystemConstant.ActiveCompany.molahezat??""},
									   {"Serial"						, x.Key.Serial.ToString()},
									   {nameof(x.Key.PersianTarixSodur) , x.Key.PersianTarixSodur},
									   {nameof(x.Key.PersianStartDate)  , x.Key.PersianStartDate},
									   {nameof(x.Key.ShaxsTitle)		, x.Key.ShaxsTitle},
									   {nameof(x.Key.ShaxsMobile)		, x.Key.ShaxsMobile},
									   {nameof(x.Key.ZamenTitle)		, x.Key.ZamenTitle},
									   {nameof(x.Key.ZamenMobile)		, x.Key.ZamenMobile},
									   {nameof(x.Key.Sharh)				, x.Key.Sharh},
									   {nameof(x.Key.NohTitle)			, x.Key.NohTitle},
									   {nameof(x.Key.DoreQest)			, x.Key.DoreQest},
									   {nameof(x.Key.TedadAqsat)		, x.Key.TedadAqsat},
									   {nameof(x.Key.MablaqAqsat)		, x.Key.MablaqAqsat},
									   {nameof(x.Key.MablaqPishpardaxt)	, x.Key.MablaqPishpardaxt},
									   {nameof(x.Key.MablaqMandeAqsat)	, x.Key.MablaqMandeAqsat},
									   {nameof(x.Key.DarsadSoud)        , x.Key.DarsadSoud},
									   {nameof(x.Key.MablaqSoud)        , x.Key.MablaqSoud},
									   {nameof(x.Key.MablaqFinalAqsat)  , x.Key.MablaqFinalAqsat},
									}
					})
					.ToList();
			}
			catch (Exception ex)
			{
				MS_Message.Show("سیستم قادر به لود فاکتور برای چاپ نیست", "خطا", ex.Message, MessageBoxButtons.OK);
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
