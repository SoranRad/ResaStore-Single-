using Janus.Windows.UI.Tab;
using MS_Control;
using MS_Control.Controls;
using Nz.Bar.Business;
using Nz.Bar.Model.Report;
using Nz.Bar.Winforms.App;
using Nz.Bar.Winforms.Settings;
using Nz.Bar.WinForms.Settings;
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
using static ShareLib.Enums;

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
        public static Form                      MainForm;
        private BarMenuItems                    Menues;
        private TabSettingContainer             _settingContainer;
        private ISettingItems                   _settings;
        #endregion
        #region Constructor
        public ToolStripItem    MainMenuSysytem     => null;
        public string           GetName             => "محـصولات";

        public BarProvider()
        {
            Menues = new BarMenuItems();
            _settingContainer = new TabSettingContainer();

        }
        #endregion

        public IEnumerable<BillRowItem>         GetBillDetail           (long People, short? Year, DateTime? DateFrom, DateTime? DateTo, byte Group)
        {
	        try
	        {
		        var Mgr     = new ReportManager();
		        var list    = Mgr.GetReport<BillRowItem>(new {People,Year, DateFrom, DateTo, Group}, string.Empty);

		        list.MSZ_ForEach(x =>
		        {
                    if(((Enums.MS_System) x.Subsystem)==MS_System.Bar)
			            x.KindTitle = "خرید محصول";
                    else if (((Enums.MS_System) x.Subsystem)==MS_System.ErsalKarkhane)
	                    x.KindTitle = "ارسال محموله";
		        });

		        return list;
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
		        var Mgr  = new ReportManager();
		        var list = Mgr.GetReport<CircularRowItem>(new {People, Year, DateFrom, DateTo, TopCount= Group }, string.Empty);

		        return list;
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
		        var Mgr     = new ReportManager();
		        var list = Mgr.GetReport<BillRow>(new {People, Year, DateFrom, DateTo}, string.Empty);

		         

		        return list;
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
		        var Mgr     = new ReportManager();
		        var item    = Mgr.GetItem<RemaindBalance>(new
		        {
			        People = ID , 
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
        public IEnumerable<RemaindPeople>       GetListRemaind          (DateTime? AzTarikh, DateTime? TaTarikh)
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
                case Enums.FormOperation.Bar:
                    return new FormBar(0);
                case Enums.FormOperation.Karkhane:
	                return null;
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

        public async Task<MS_Chart[]>           GetChartSummarry        ()
        {
            return null;
        }

        public Task<IEnumerable<DailyCircular>> GetDailyCircular        (short Year, short Month)
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

		public NsSettingTabPage                 GetSettingTabPage       ()
		{
			_settingContainer = new TabSettingContainer();
			_settingContainer.LoadSetting((SettingItems)_settings );

			return _settingContainer.TabSetting;
		}

		public void                             SetSettings             (IEnumerable<dynamic> settings)
		{
			var setting = settings.SingleOrDefault(x => x.Name == SettingItems.KeyName);
			if (setting == null)
				_settings = SettingItems.GetDefault();
			else
				_settings = Converter.Convert<SettingItems>(setting);
		}

		public ISettingItems                    GetSettings             ()
		{
			return _settings;
		}

		public bool                             HasSrtartupForm         ()
		{
			return false;
		}

		public Form                             GetStartupPage          ()
		{
			return null;
		}
	}
}
