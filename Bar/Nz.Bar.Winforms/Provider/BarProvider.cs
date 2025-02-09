using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.UI.Tab;
using MS_Control.Controls;
using Nz.Bar.Winforms.App;
using ShareLib;
using ShareLib.Interfaces;
using ShareLib.Models;
using ShareLib.ViewModel;

namespace Nz.Bar.Winforms.Provider
{
    public class BarProvider : IEntryProvider
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        public static Form MainForm;
        private BarMenuItems Menues;
        #endregion
        #region Constructor
        public ToolStripItem    MainMenuSysytem     => null;
        public string           GetName             => "میکس و بسته بندی";

        public BarProvider()
        {
            Menues = new BarMenuItems();
        }
        #endregion

        public IEnumerable<BillRowItem>         GetBillDetail           (long People, short? Year, DateTime? DateFrom, DateTime? DateTo, byte Group)
        {
            return null;
        }
        public IEnumerable<CircularRowItem>     GetBillItems            (long People, short? Year, DateTime? DateFrom, DateTime? DateTo, byte Group)
        {
            return null;
        }

        public decimal                          GetRemaind              (long ID)
        {
            return 0;
        }
        public IEnumerable<RemaindPeople>       GetListRemaind          (DateTime? AzTarikh, DateTime? TaTarikh)
        {
            return null;
        }
        public decimal                          GetRemainAll            (long IDCustomer)
        {
            throw new NotImplementedException();
        }

        public ToolStripItemCollection          GetMenu                 (Enums.MenuKind MenuType)
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
            }
            return null;
        }

       
        public Enums.MS_System                  GetSystemKind           ()
        {
            return Enums.MS_System.Bar;
        }
        public IForm_Editor                     GetFormForEdit          (Enums.FormOperation FormKind, params object[] otherParam)
        {
            switch (FormKind)
            {
                case Enums.FormOperation.Factors:
                    return new FormBar();
                default:
                    return null;
            }
        }
        public Form                             GetSimpleForm           (Enums.FormOperation FormKind)
        {
            throw new NotImplementedException();
        }

        public void                             SetProperty             (string Name, object Value)
        {
            throw new NotImplementedException();
        }
        public object                           GetProperty             (string Name)
        {
            throw new NotImplementedException();
        }

        public void                             SetMainForm             (Form mainForm)
        {
            MainForm = mainForm;
        }
        public bool                             GetFeature              (short FeatureItem)
        {
            return true;
        }
        public void                             RefreshAlaram           ()
        {
            //throw new NotImplementedException();
        }
        public bool                             AnyAlaram               ()
        {
            return false;
        }

        public UITabPage                        GeTabPage               ()
        {
            return null;
        }

        public async Task<MS_Chart[]> GetChartSummarry()
        {
            return null;
        }

        public Task<IEnumerable<DailyCircular>> GetDailyCircular(short Year, short Month)
        {
            try
            {
                return Task.FromResult((IEnumerable<DailyCircular>)null);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return null;

            }
        }
    }
}
