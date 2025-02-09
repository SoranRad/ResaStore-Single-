using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.UI.Tab;
using MS_Control;
using MS_Control.Controls;
using Nz.Anbar.WinForms.App;
using NZ.Anbar.Business;
using Nz.Anbar.WinForms.Alarm;
using Nz.Anbar.WinForms.Component;
using Nz.Anbar.WinForms.EndYear;
using ShareLib;
using ShareLib.Interfaces;
using ShareLib.Models;
using ShareLib.Utils;
using ShareLib.ViewModel;

namespace Nz.Anbar.WinForms.Provider
{
    public class StorageProvider :  IEntryProvider
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private StorageMenuItems                Menues;
        public static Form                      MainForm;
        private StorageAlarm                    _storageAlarm;
        #endregion
        #region Constructors
        public StorageProvider()
        {
            Menues = new StorageMenuItems();
        }
        #endregion
        #region Mthods
        public string                       GetName             => "خرید و فروش";
        public ToolStripItem                MainMenuSysytem     => null;
        public IEnumerable<BillRowItem>     GetBillDetail       (long People, short? Year, DateTime? DateFrom, DateTime? DateTo, byte Group)
        {
            try
            {
                var Mgr     = new ReportManager();
                var list    = Mgr.GetReport<BillRowItem>(new {People,Year, DateFrom, DateTo, Group}, string.Empty);

                list.MSZ_ForEach(x =>
                {
                    x.KindTitle = ((Enums.NzFactorKind) x.Kind).NzToString();

                });

                return list;
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
                var Mgr  = new ReportManager();
                var list = Mgr.GetReport<CircularRowItem>
                    (new {People, Year, DateFrom, DateTo, TopCount= Group }, string.Empty);

                list?.MSZ_ForEach(x =>
                {
                    x.Title = ((Enums.NzFactorKind) x.Kind).NzToString() +@"(" + x.Title + @")";
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
                case Enums.FormOperation.Factors:
                    return new Form_Purchase();
                case Enums.FormOperation.SaleBack:
                    return new Form_SaleBack();
                case Enums.FormOperation.StorageEndYear:
                    return new FormEndYear();
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
                    return Menues.StorageMenu.DropDownItems;
                case Enums.MenuKind.Reports:
                    return Menues.NzReport.DropDownItems;
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
            throw new NotImplementedException();
        }
        public Enums.MS_System              GetSystemKind       ()
        {
            return Enums.MS_System.Anbar;
        }
        public void                         SetMainForm         (Form mainForm)
        {
            MainForm = mainForm;
        }
        public void                         SetProperty         (string Name, object Value)
        {
            throw new NotImplementedException();
        }

        public decimal                      GetRemaind          (long ID)
        {
            try
            {
                var Mgr     = new ReportManager();
                var item    = Mgr.GetItem<RemaindBalance>(new
                {
                    ID , 
                    Year = SystemConstant.ActiveYear.Salmali
                },null);
                return item?.Balance ?? 0;

            }
            catch (Exception ex)
            {
                log.Error(ex);
            }

            return 0;
        }
        public IEnumerable<RemaindPeople>   GetListRemaind      (DateTime? AzTarikh, DateTime? TaTarikh)
        {
            try
            {
                var Mgr     = new ReportManager();
                var list    = Mgr.GetReport<RemaindPeople>
                    (new
                        {
                            Year = SystemConstant.ActiveYear.Salmali,
                            AzTarikh,
                            TaTarikh
                    }, string.Empty
                    );
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
            _storageAlarm = new StorageAlarm();
            _storageAlarm.RefreshList();
        }
        public bool                         AnyAlaram           ()
        {
            return _storageAlarm.AnyAlarm();
        }
        public UITabPage                    GeTabPage           ()
        {
            return _storageAlarm.GetTabPage();
        }

        public async Task<MS_Chart[]>         GetChartSummarry    ()
        {
            return new MS_Chart[]
            {
                new ChartSummarry().Refresh(),
                new ChartSummarry().RefreshSud(),

            };
        }

        public Task<IEnumerable<DailyCircular>> GetDailyCircular(short Year, short Month)
        {
            try
            {
                var list = new ReportManager().GetReport<DailyCircular>
                    (new
                    {
                        Year, 
                        Month,
                        KindXarid       = Enums.NzFactorKind.Xarid,
                        KindFrosh       = Enums.NzFactorKind.Frosh,
                        KindBarFrosh    = Enums.NzFactorKind.BargshtFrosh,
                        KindBarXarid    = Enums.NzFactorKind.BargashXarid,
                        KinZayeat       = Enums.NzFactorKind.HavaleZayeat,
                        KindMasraf      = Enums.NzFactorKind.HavaleMasrafi,
                    }, "");

                return Task.FromResult(list);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return null;

            }
        }

        #endregion

    }
}
