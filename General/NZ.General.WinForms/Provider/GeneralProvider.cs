using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MDIWindowManager;
using ShareLib;
using ShareLib.Interfaces;
using ShareLib.Models;
using System.Windows.Forms;
using NZ.General.WinForms.Misc;
using NZ.General.WinForms.Provider;
using NZ.General.WinForms.Setting;
using ShareLib.Utils;
using ShareLib.ViewModel;
using Janus.Windows.UI.Tab;
using MS_Control.Controls;
using NZ.General.WinForms.Alarm;
using NZ.General.WinForms.Component;

namespace NZ.General.WinForms
{
    public class GeneralProvider :IEntryProvider
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private GeneralMenuItems            Menues;
        private NoteDailyAlarm              _dailyAlarm;
        public static Form                  MainForm;
        #endregion
        #region Consructor
        public GeneralProvider()
        {
            Menues                          = new GeneralMenuItems  ();
            Form_Factory.LoadingForm        = new FormLoading       ();
            Form_Factory.LoginForm          = new FormLogin         ();
            Form_Factory.ExitForm           = new FormExit          ();

            Form_Factory.CmdChangePass      = new CommandChangePass (MainForm);
            Form_Factory.CmdChangeUsYear    = new CommandChangeYear (MainForm);
            Form_Factory.CmdChangeUser      = new CommandChangeUser (MainForm);
        }
        #endregion
        #region Methods
        public string                   GetName =>          "عمومی";
        public ToolStripItem            MainMenuSysytem =>  null;
        public Enums.MS_System          GetSystemKind()     => Enums.MS_System.General;
        public IEnumerable<BillRowItem> GetBillDetail       (long People, short? Year, DateTime? DateFrom, DateTime? DateTo, byte Group)
        {
            return null;
        }
        public IEnumerable<CircularRowItem> GetBillItems    (long People, short? Year, DateTime? DateFrom, DateTime? DateTo, byte Group)
        {

            return null;
        }
        public IForm_Editor             GetFormForEdit      (Enums.FormOperation FormKind,params object[] otherParam)
        {
            throw new NotImplementedException();
        }
        public ToolStripItemCollection  GetMenu             (Enums.MenuKind MenuType)
        {
            Menues.SetMenu();
            switch (MenuType)
            {
                case Enums.MenuKind.BaseInfo:
                    return Menues.ms_baseinfo.DropDownItems;
                case Enums.MenuKind.Operation:
                    return null;
                case Enums.MenuKind.Reports:
                    return Menues.NzReports.DropDownItems;
                case Enums.MenuKind.Settings:
                    return Menues.ms_settings.DropDownItems;
                case Enums.MenuKind.Management:
                    return null;
                case Enums.MenuKind.Sidebar:
                    return Menues.NzSideBarMenu.Items;
            }
            return null;
        }
        public object                   GetProperty         (string Name)
        {
            throw new NotImplementedException();
        }
        public decimal                  GetRemainAll        (long IDCustomer)
        {
            throw new NotImplementedException();
        }
        public Form                     GetSimpleForm       (Enums.FormOperation FormKind)
        {
            throw new NotImplementedException();
        }
        public void                     SetMainForm         (Form mainForm)
        {
            MainForm = mainForm;
        }
        public void                     SetProperty         (string Name, object Value)
        {
            throw new NotImplementedException();
        }

        public decimal                  GetRemaind          (long ID)
        {
            return 0;
        }
        public bool                     GetFeature          (short FeatureItem)
        {
            return true;
        }

        public void RefreshAlaram()
        {
            _dailyAlarm = new NoteDailyAlarm();
            _dailyAlarm.RefreshList();
        }

        public IEnumerable<RemaindPeople> GetListRemaind(DateTime? AzTarikh, DateTime? TaTarikh)
        {
            return null;
        }

        public bool AnyAlaram()
        {
            return _dailyAlarm.AnyAlarm();
        }

        public UITabPage GeTabPage()
        {
            return _dailyAlarm.GetTabPage();
        }

        public async Task<MS_Chart[]> GetChartSummarry()
        {
            //await Task.Delay(2000);
            return new MS_Chart[]
            {
                new ChartSummarry().Refresh()
            };

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

        #endregion
    }
}
