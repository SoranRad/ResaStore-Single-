using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control;
using MS_Print_Dialog;
using Nz.Anbar.Model.ViewModel;
using NZ.Anbar.Business;
using ShareLib;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Print
{
    public class PrintTransfers
    {
        #region Fields
        private List<long>                  _ListIDs;
        private ReportManager               _Manager;
        private Print_Dialog                _PrintDiag;
        private List<MS_Report_Loading>     _ListReport;
        private string                      _ReportPath;
        private MS_Wait FrmWait =new MS_Wait();
        private Enums.NzFactorKind          _KindTransfer;
        #endregion
        public PrintTransfers(List<long> ListIDs,Enums.NzFactorKind KindTransfer)
        {
            FrmWait.Show();
            _ListIDs        = ListIDs;
            _KindTransfer   = KindTransfer;
            _Manager        = new ReportManager();
            _ReportPath     = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            _ReportPath     += "\\Print\\Anbar\\Transfer.mrt";

            Load();
        }
        #region Methods
        private void    Load    ()
        {
            try
            {
                var str     = " WHERE " +string.Join(" OR ", _ListIDs.Select(x => "tat.ID=" + x.ToString()));
                var Factors = _Manager.GetReport<PrintTransfer>(null,str);

                if (Factors == null)
                    throw new Exception();

                _ListReport =
                    Factors
                    .GroupBy(x => new
                    {
                        x.ID,
                        x.PersianStr,
                        x.Serial,
                        x.sharh,
                    })
                    .Select(x => new MS_Report_Loading
                    {
                        BusinessObject_Name = "List",
                        Report_Address = _ReportPath,

                        List_Data = x.Select(y => new
                        {
                            y.radif,
                            y.FK_Kala,
                            y.ObjectTitle,
                            y.UnitTitle,
                            y.meqdar,
                        })
                        .OrderBy(y => y.radif)
                        .ThenBy(y => y.FK_Kala)
                        ,
                        List_Parametter =
                         new Dictionary<string, object>()
                                   {
                                       {"txt"              , x.Key.sharh},
                                       {"noh_faktor"       , _KindTransfer.NzToString()},
                                       {"company"          , SystemConstant.ActiveCompany.title},
                                       {"serial"           , x.Key.Serial.ToString()},
                                       {"tarikh"           , x.Key.PersianStr},
                                    }
                    })
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("سیستم قادر به لود فاکتور برای چاپ نیست", ex);
            }
        }
        public  void    Show    (IWin32Window Frm)
        {
            FrmWait.Close();
            _PrintDiag = new Print_Dialog(_ListReport);
            _PrintDiag.ShowDialog(Frm);
        }
        #endregion

    }
}
