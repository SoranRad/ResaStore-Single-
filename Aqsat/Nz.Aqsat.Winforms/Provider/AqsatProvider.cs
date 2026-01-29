using Janus.Windows.UI.Tab;
using MS_Control;
using MS_Control.Controls;
using ShareLib;
using ShareLib.Component;
using ShareLib.Interfaces;
using ShareLib.Models;
using ShareLib.Utils;
using ShareLib.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nz.Aqsat.Business;
using Nz.Aqsat.Model.Report;
using Nz.Aqsat.Winforms.Alarm;
using Nz.Aqsat.WinForms.Settings;
using Nz.Asat.Winforms.Settings;
using static ShareLib.Enums;

namespace Nz.Bar.Winforms.Provider
{
    public class AqsatProvider : IEntryProvider
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        public static Form                      MainForm;
        private AqsatMenuItems                    Menues;
        private TabSettingContainer             _settingContainer;
        private ISettingItems                   _settings;
        private AqsatAlarm _aqsatAlarm;
		#endregion
		#region Constructor
		public ToolStripItem    MainMenuSysytem     => null;
        public string           GetName             => "اقسـاط";

        public AqsatProvider()
        {
            Menues = new AqsatMenuItems();
            _settingContainer = new TabSettingContainer();

        }
        #endregion

        public IEnumerable<BillRowItem>         GetBillDetail           (long People, short? Year, DateTime? DateFrom, DateTime? DateTo, byte Group)
        {
	        try
	        {
		        

		        return null;
	        }
	        catch (Exception ex)
	        {
		        log.Error(ex);
		        return null;
	        }
        }
        public IEnumerable<CircularRowItem>     GetBillItems            (long People, short? Year, DateTime? DateFrom, DateTime? DateTo, byte Group)
        {
	        try
			{
				return null;
			}
	        catch (Exception ex)
	        {
		        log.Error(ex);
		        return null;
	        }
        }
        public IEnumerable<object>              GetBillRows             (long People, short? Year, DateTime? DateFrom, DateTime? DateTo)
        {
	        try
	        {
		        
		        return null;
	        }
	        catch (Exception ex)
	        {
		        log.Error(ex);
		        return null;
	        }
        }

        public decimal                          GetRemaind              (long ID)
        {
	        try
	        {
		         
		        return   0;

	        }
	        catch (Exception ex)
	        {
		        log.Error(ex);
	        }

	        return 0;
        }
        public IEnumerable<RemaindPeople>       GetListRemaind          (DateTime? AzTarikh, DateTime? TaTarikh)
        {
	        try
	        {
		         
		        return null;
	        }
	        catch (Exception ex)
	        {
		        log.Error(ex);
		        return null;
	        }
        }
        public decimal                          GetRemainAll            (long IDCustomer)
        {
	        return 0;
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
            return Enums.MS_System.Aqsat;
        }
        public IForm_Editor                     GetFormForEdit          (Enums.FormOperation FormKind, params object[] otherParam)
        {
			return null;
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
			_aqsatAlarm = new AqsatAlarm();
			_aqsatAlarm.RefreshList();
		}
        public bool                             AnyAlaram               ()
        {
            return _aqsatAlarm.AnyAlarm();
        }

        public UITabPage[] GetAlarmsTabPage()               
        {
            return _aqsatAlarm.GetTabPage().ToArray();
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

		public NsSettingTabPage[] GetSettingTabPage()
		{
			_settingContainer = new TabSettingContainer();
			_settingContainer.LoadSetting((SettingItems)_settings );

			return new NsSettingTabPage[] { _settingContainer.TabSetting };
		}

		public void SetSettings(IEnumerable<dynamic> settings)
		{
			var setting = settings.SingleOrDefault(x => x.Name == SettingItems.KeyName);
			if (setting == null)
				_settings = SettingItems.GetDefault();
			else
				_settings = Converter.Convert<SettingItems>(setting);
		}

		public ISettingItems GetSettings()
		{
			return _settings;
		}

		public bool HasSrtartupForm()
		{
			return false;
		}

		public Form GetStartupPage()
		{
			return null;
		}
	}
}
