using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.UI.Tab;
using MDIWindowManager;
using MS_Control;
using MS_Control.Controls;
using NZ.Xazane.Business;
using NZ.Xazane.WinForms.Alarm;
using NZ.Xazane.WinForms.App;
using NZ.Xazane.WinForms.Base;
using NZ.Xazane.WinForms.Component;
using NZ.Xazane.WinForms.EndYear;
using NZ.Xazane.WinForms.Factor;
using NZ.Xazane.WinForms.Provider;
using ShareLib;
using ShareLib.Interfaces;
using ShareLib.Models;
using ShareLib.Utils;
using ShareLib.ViewModel;

namespace NZ.Xazane.WinForms
{
    public class XazaneProvider : IEntryProvider,IFactoryControl
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        private XazaneMenuItems             Menues;
        private ChequeAlarm                 _chequeAlarm;
        public static Form                  MainForm;

        public XazaneProvider()
        {
            Menues = new XazaneMenuItems();
        }

        public string                       GetName             => "خزانه داری";
        public ToolStripItem                MainMenuSysytem     => null;
        public IEnumerable<BillRowItem>     GetBillDetail       (long People, short? Year, DateTime? DateFrom, DateTime? DateTo, byte Group)
        {
            try
            {
                var Mgr         = new ReportManager();
                var list        = Mgr.GetReport<BillRowItem>
                    (new {People,Year, DateFrom, DateTo, Group}, string.Empty);

                list.MSZ_ForEach(x =>
                {
                    x.KindTitle = ((Enums.NzPaymentOperatingKind) x.Kind).NzToString();
                    x.Title     = ((Enums.NzPaymentOperatingKind) x.Code).NzToString();

                    x.Code      = null;
                });

                return list.Where(x => x.Credit > 0 || x.Debit > 0);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return null;
            }


        }
        public IEnumerable<CircularRowItem> GetBillItems        (long People, short? Year, DateTime? DateFrom, DateTime? DateTo, byte Group)
        {
            try
            {
                var Mgr     = new ReportManager();
                var list = Mgr.GetReport<CircularRowItem>
                    (new {People, Year, DateFrom, DateTo, Group}, string.Empty);

                list.MSZ_ForEach(x =>
                {
                    if(     x.Kind != (byte)Enums.NzPaymentOperatingKind.Addition 
                        &&  x.Kind != (byte)Enums.NzPaymentOperatingKind.Kosurat
                        &&  x.Kind != (byte)Enums.NzPaymentOperatingKind.RemaindDebit
                        &&  x.Kind != (byte)Enums.NzPaymentOperatingKind.RemaindCredit
                        )
                            x.Title = ((Enums.NzPaymentOperatingKind) x.Kind).NzToString()+ @" " +x.Title;
                });

                return list;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return null;
            }

        }
        public IForm_Editor                 GetFormForEdit      (Enums.FormOperation FormKind,params object[] otherParam)
        {
            switch (FormKind)
            {
                case Enums.FormOperation.Recieve:
                    return new FormPayment();
                case Enums.FormOperation.Payment:
                    return new FormPayment(0,Enums.NzPaymentOperatingKind.Pardaxt);
                case Enums.FormOperation.Deficit:
                    return new App.FormDeficit(null);
                case Enums.FormOperation.Addition:
                    return new App.FormDeficit(null,0,Enums.NzPaymentOperatingKind.Addition);
                case Enums.FormOperation.Remaind:
                    return new FormListRemaind();
                case Enums.FormOperation.FactorPaymentList :
                    return new FactorPaymentService((otherParam[0] as FactorPaymentMessage)).GetForm();
                case Enums.FormOperation.XazaneEndYear:
                    return new FormEndYear();
                case Enums.FormOperation.BarcodePayment:
                    return new FormBarCodePayment();
                default:
                    return null;
            }
        }
        public ToolStripItemCollection      GetMenu             (Enums.MenuKind MenuType)
        {
            Menues.SetMenu();
            switch (MenuType)
            {
                case Enums.MenuKind.BaseInfo:
                    return Menues.ms_baseinfo.DropDownItems;
                case Enums.MenuKind.Operation:
                    return Menues.NzOptMenu.DropDownItems;
                case Enums.MenuKind.Reports:
                    return Menues.NzReports.DropDownItems;
                case Enums.MenuKind.Settings:
                    return null;
                case Enums.MenuKind.Management:
                    return null;
                case Enums.MenuKind.Sidebar:
                    return Menues.NzSideBarMenu.Items;
            }
            return null;
        }
        public object                       GetProperty         (string Name)
        {
            throw new NotImplementedException();
        }
        public decimal                      GetRemainAll        (long IDCustomer)
        {
            throw new NotImplementedException();
        }
        public Form                         GetSimpleForm       (Enums.FormOperation FormKind)
        {
            switch (FormKind)
            {
                case Enums.FormOperation.Recieve:
                    return new FormPayment();
                case Enums.FormOperation.Payment:
                    return new FormPayment(0, Enums.NzPaymentOperatingKind.Pardaxt);
                case Enums.FormOperation.Deficit:
                    return new App.FormDeficit(null);
                case Enums.FormOperation.Addition:
                    return new App.FormDeficit(null, 0, Enums.NzPaymentOperatingKind.Addition);
                default:
                    return null;
            }
        }
        public void                         SetMainForm         (Form mainForm)
        {
            MainForm = mainForm;
        }
        public void                         SetProperty         (string Name, object Value)
        {
            throw new NotImplementedException();
        }
        public Enums.MS_System              GetSystemKind       ()
        {
            return Enums.MS_System.Xazane;
        }

        public decimal                      GetRemaind          (long ID)
        {
            try
            {
                var Mgr     = new ReportManager();
                var item    = Mgr.GetItem<RemaindBalance>(new { ID,Year= SystemConstant.ActiveYear.Salmali }, string.Empty);


                return item?.Balance ?? 0;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return 0;
            }
        }
        public IEnumerable<RemaindPeople>   GetListRemaind      (DateTime? AzTarikh, DateTime? TaTarikh)
        {
            try
            {
                var Mgr = new ReportManager();
                var list = Mgr.GetReport<RemaindPeople>(new
                {
                    Year = SystemConstant.ActiveYear.Salmali,
                    AzTarikh,
                    TaTarikh
                }, string.Empty);
                return list;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return null;
            }
        }

        public bool                         GetFeature          (short FeatureItem)
        {
            return true;
        }

        public void                         RefreshAlaram       ()
        {
            _chequeAlarm = new ChequeAlarm();
            _chequeAlarm.RefreshList();
        }
        public bool                         AnyAlaram           ()
        {
            return _chequeAlarm.AnyAlarm();
        }
        public UITabPage                    GeTabPage           ()
        {
            return _chequeAlarm.GetTabPage();
        }

        public async Task<MS_Chart[]>         GetChartSummarry    ()
        {
            return new MS_Chart[]
            {
                new ChartSummarry().RefreshDP(),
                new ChartSummarry().RefreshCheque(),
                new ChartSummarry().RefreshHazine(),
                new ChartSummarry().RefreshDaramad(),
            };
        }

        public Task<IEnumerable<DailyCircular>> GetDailyCircular(short Year, short Month)
        {
            try
            {
                var list = new ReportManager().GetReport<DailyCircular>(
                    new
                    {
                        Year, 
                        Month,
                        KindDaryaft     = Enums.NzPaymentOperatingKind.Daryaft,
                        KindPardaxt     = Enums.NzPaymentOperatingKind.Pardaxt,
                        KindCache       = Enums.NzPaymentOperatingKind.Naqd,
                        kindPOS         = Enums.NzPaymentOperatingKind.Bank_POS,
                        KindHazine      = Enums.NzPaymentOperatingKind.Hazine,
                        KindDaramad     = Enums.NzPaymentOperatingKind.Daramad,
                    }, "");

                return Task.FromResult(list);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return null;

            }
        }

        public Control                      CreateControl       (Enums.NzFactoryControlKind Kind)
        {
            switch (Kind)
            {
                case Enums.NzFactoryControlKind.CachePos:
                    return new PaymentControl();
                default:
                    return null;
            }
        }
    }
}
