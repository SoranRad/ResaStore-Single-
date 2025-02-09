using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS_Control;
using MS_Print_Dialog;
using ShareLib;
using System.Windows.Forms;
using NZ.Xazane.Business;
using NZ.Xazane.Model.ViewModel;
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.App
{
    public class Print
    {
        #region Logging

        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion
        #region Fields
        private List<long>                      _ListIDs;
        private Print_Dialog                    _PrintDiag;
        private List<MS_Report_Loading>         _ListReport;
        private string                          _ReportPath;
        private MSWait                         FrmWait         = new MSWait();
        private ReportManager                   _Manager;
        private Enums.NzKindPrint               _PrintKind;
        private Enums.NzPaymentOperatingKind    _Kind;
        #endregion
        #region Constructor
        public          Print           (List<long> ListIDs, Enums.NzKindPrint PrintKind,Enums.NzPaymentOperatingKind Kind)
        {
            FrmWait.Show();
            Application.DoEvents();
            _Manager    = new ReportManager();
            _ListIDs    = ListIDs;
            _PrintKind  = PrintKind;
            _Kind       = Kind;
            SetPrintFile();
            Load();

        }
        #endregion
        #region Methods
        private void    SetPrintFile    ()
        {
            _ReportPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            _ReportPath += "\\Print\\DP\\";

            switch (_PrintKind)
            {
                case Enums.NzKindPrint.PaperA4:
                    _ReportPath += "ResidDP_A4.mrt";
                    break;
                case Enums.NzKindPrint.PaperA5:
                    _ReportPath += "ResidDP_A5.mrt";
                    break;
            }
        }
        private void    Load            ()
        {
            try
            {
                
                var IDs     = " AND (" + string.Join(" OR ", _ListIDs.Select(x => " tad.ID=" + x.ToString()))+" )";
                var list    = _Manager.GetReport<PrintDP>(null, IDs);

                var Co      = SystemConstant.ActiveCompany;
                var User    = SystemConstant.ActiveUser.title;
                var Title   = "رسید "+ (_Kind == Enums.NzPaymentOperatingKind.Daryaft 
                                ? @"دریافت وجوه از اشخاص " 
                                : @"پرداخت وجوه به اشخاص");
                var Verb    = _Kind == Enums.NzPaymentOperatingKind.Daryaft
                                ? @"دریافت"
                                : @"پرداخت";
                var ChequeHead = _Kind == Enums.NzPaymentOperatingKind.Daryaft
                                ? @"بانک عامل"
                                : @"حسـاب پرداختی";
                _ListReport =
                list.GroupBy(x => new
                {
                    x.ID             ,          
                    x.tarikh         ,
                    x.serial         ,
                    x.Name           ,
                    x.Address        ,
                    x.CodeMeli       ,
                    x.Mobile         ,
                    x.Tel            ,
                    x.Cache          ,
                    x.CacheDesc      ,
                    x.POS            ,
                    x.SerialPeygiri  ,
                    x.POSDesc        ,
                    x.POSTitle       ,
                    x.takhfif        ,
                    x.sharh          ,

                })
                .Select(x=>new MS_Report_Loading
                    {
                        BusinessObject_Name = "ListCheque",
                        Report_Address      = _ReportPath,

                        List_Data           = x.Where(y=> y.IDCheque !=null ).Select(y => new
                        {
                            y.shomare_check,
                            y.tarikh_sar_resid,
                            y.NameBank,
                            
                            y.ChequeDesc,
                            y.mablaq,
                        }),

                    List_Parametter         = new Dictionary<string, object>()
                        {
                            {"tarikh"           , x.Key.tarikh},
                            {"user"             , User},
                            {"serial"           , x.Key.serial.ToString()},
                            {"Company"          , Co.title},
                            {"Title"            , Title},
                            {"Name"             , x.Key.Name},
                            {"Address"          , x.Key.Address},
                            {"CodeMeli"         , x.Key.CodeMeli},
                            {"Mobile"           , x.Key.Mobile},
                            {"Tel"              , x.Key.Tel},
                            {"DPVerb"           , Verb},
                            {"Cache"            , x.Key.Cache},
                            {"POS"              , x.Key.POS},
                            {"CacheDesc"        , x.Key.CacheDesc},
                            {"POSTitle"         , x.Key.POSTitle},
                            {"SerialPeygiri"    , x.Key.SerialPeygiri.ToString()},
                            {"POSDesc"          , x.Key.POSDesc},
                            {"OFF"              , x.Key.takhfif},
                            {"Desc"             , x.Key.sharh},
                            {"ChequeHead"       , ChequeHead},
                        },

                    })
                    .ToList();

            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در لود چاپ اسناد","خطای چاپ", ex.Message,MessageBoxButtons.OK);
            }
        }
        public  void    Show            (IWin32Window Owner)
        {
            FrmWait.Close();
            _PrintDiag = new Print_Dialog(_ListReport);
            _PrintDiag.ShowDialog(Owner);
        }
        #endregion

    }
}
