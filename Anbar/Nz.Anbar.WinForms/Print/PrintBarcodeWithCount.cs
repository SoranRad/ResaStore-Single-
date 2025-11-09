using MS_Control;
using MS_Print_Dialog;
using NZ.Anbar.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Print
{
	public class PrintBarcodeWithCount
	{
		private readonly IEnumerable<ObjectCount> _objects;
		private List<MS_Report_Loading>     _ListReport;
		private string                      _ReportPath;
		private MSWait FrmWait              = new MSWait();
		private Print_Dialog                _PrintDiag;

		#region Property
		[DefaultValue(false)]
		public bool DirectPrint { get; set; }
		#endregion


		public PrintBarcodeWithCount(IEnumerable<ObjectCount> Objects)
		{
			_objects = Objects;
			FrmWait         .Show();
			Application     .DoEvents();
			SetPrintFile    ();
			Load            ();
		}
		private void        SetPrintFile    ()
		{
			_ReportPath = Utility.GetPrintDirectory()+ "\\Anbar\\Barcode.mrt";
		}
		private void        Load            ()
		{
			try
			{
				_ListReport =
					_objects
						.Select(x => new MS_Report_Loading
						{
							BusinessObject_Name = null,
							Report_Address      =_ReportPath,
							CopyCount			= x.Count,
							List_Data           = null,
							List_Parametter     =  
								new Dictionary<string, object>()
								{
	                                   
									{"BarCode"                      , x.NzObject.barcode},
									{"Company"                      , SystemConstant.ActiveCompany.title},
									{"Title"                        , x.NzObject.title},
									{"Title2"                       , x.NzObject.nameFani},
									{nameof(NzObject.nerkh_frosh)   , x.NzObject.nerkh_frosh},
									{nameof(NzObject.nerkh_frosh1)  , x.NzObject.nerkh_frosh1},
									{nameof(NzObject.nerkh_frosh2)  , x.NzObject.nerkh_frosh2},
									{nameof(NzObject.nerkh_frosh3)  , x.NzObject.nerkh_frosh3},
									{nameof(NzObject.Size)          , x.NzObject.Size},
								},
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
