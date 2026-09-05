using Janus.Windows.UI.Tab;
using MS_Control;
using MS_Control.Controls;
using Nz.Anbar.Model.Report;
using Nz.Anbar.WinForms.Alarm;
using Nz.Anbar.WinForms.App;
using Nz.Anbar.WinForms.Component;
using Nz.Anbar.WinForms.EndYear;
using Nz.Anbar.WinForms.Settings;
using NZ.Anbar.Business;
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
using static Stimulsoft.Base.StiDbType;

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
        private TabSettingContainer             _settingContainer;
        private ISettingItems               _settings;

        #endregion
        #region Constructors
        public StorageProvider()
        {
            Menues = new StorageMenuItems();
            _settingContainer = new TabSettingContainer();
        }
        #endregion
        #region Mthods
        public string                               GetName                 => "خرید و فروش";
        public ToolStripItem                        MainMenuSysytem         => null;
        public IEnumerable<BillRowItem>             GetBillDetail           (long People, short? Year, DateTime? DateFrom, DateTime? DateTo, byte Group)
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
        public IEnumerable<CircularRowItem>         GetBillItems            (long People, short? Year, DateTime? DateFrom, DateTime? DateTo, byte Group)
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

        public IEnumerable<object>                  GetBillRows             (long People, short? Year, DateTime? DateFrom, DateTime? DateTo)
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

        public IForm_Editor                         GetFormForEdit          (Enums.FormOperation FormKind,params object[] otherParam)
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
        public ToolStripItemCollection              GetMenu                 (Enums.MenuKind MenuType)
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
        public object                               GetProperty             (string Name)
        {
            throw new NotImplementedException();
        }
        public decimal                              GetRemainAll            (long IDCustomer)
        {
            throw new NotImplementedException();
        }
        public Form                                 GetSimpleForm           (Enums.FormOperation FormKind)
        {
            throw new NotImplementedException();
        }
        public Enums.MS_System                      GetSystemKind           ()
        {
            return Enums.MS_System.Anbar;
        }
        public void                                 SetMainForm             (Form mainForm)
        {
            MainForm = mainForm;
        }
        public void                                 SetProperty             (string Name, object Value)
        {
            throw new NotImplementedException();
        }

        public decimal                              GetRemaind              (long ID)
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
        public IEnumerable<RemaindPeople>           GetListRemaind          (DateTime? AzTarikh, DateTime? TaTarikh)
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
        public bool                                 GetFeature              (short FeatureItem)
        {
            return true;
        }

        public void                                 RefreshAlaram           ()
        {
            _storageAlarm = new StorageAlarm();
            _storageAlarm.RefreshList();
        }
        public bool                                 AnyAlaram               ()
        {
            return _storageAlarm.AnyAlarm();
        }
        public UITabPage[]                          GetAlarmsTabPage        ()
        {
	        var tabs = _storageAlarm.GetTabPage();

			return tabs!=null && tabs.Any() ? tabs.ToArray(): null;
		}

        public async Task<MS_Chart[]>               GetChartSummarry        ()
        {
            return new MS_Chart[]
            {
                new ChartSummarry().Refresh(),
                new ChartSummarry().RefreshSud(),

            };
        }
        public Task<IEnumerable<DailyCircular>>     GetDailyCircular        (short Year, short Month)
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

		public NsSettingTabPage[]                     GetSettingTabPage       ()
		{
			_settingContainer = new TabSettingContainer();
            _settingContainer.LoadSetting((SettingItems)_settings );

			return new NsSettingTabPage[]{_settingContainer.TabSetting};
		}
		public void                                 SetSettings             (IEnumerable<dynamic> settings)
		{
			var setting = settings.SingleOrDefault(x => x.Name == SettingItems.KeyName);
			if (setting == null)
				_settings = SettingItems.GetDefault();
			else
				_settings = Converter.Convert<SettingItems>(setting);
		}
		public ISettingItems                        GetSettings             ()
		{
			return _settings;
		}

		public bool                                 HasSrtartupForm         ()
		{
			return false;
		}
		public Form                                 GetStartupPage          ()
		{
			return null;
		}

		public async Task<IEnumerable<T>> GetPartnerReportList<T>(DateTime? Start, DateTime? End, params long[] Ids) where T : class
		{
			try
			{
				var mgr = new ReportManager();
				return mgr.GetReport<T>(new { Start, End ,Year = SystemConstant.ActiveYear.Salmali}, null);
			}
			catch (Exception ex)
			{
				 log.Error(ex);
			}

			return null;
		}
		public async Task<T> GetPartnerReportItem<T>(DateTime? Start, DateTime? End, params long[] Ids) where T : class
		{
			try
			{
				var mgr = new ReportManager();

                //== trade off
				if (typeof(T).Name == "PartnerStatus")
				{

					var IdString = Ids==null|| !Ids.Any() 
						? "" 
						: (" AND tar.FK_Kala IN ("+ string.Join(",",Ids.Select(x=>x.ToString()))+")");

					var SqlStr = $@"
DECLARE 

@SumFroshKalaAmani		DECIMAL,
@SumFroshKalaAdi		DECIMAL,
@MandeKalaAdi			DECIMAL,
@MandeKalaAmani			DECIMAL,
@SumSoodKala			DECIMAL

SELECT 

@SumFroshKalaAmani  = SUM( CASE WHEN tatd.IsAmani = 1 THEN  (tar.meqdar - tar.Remain) * tar.nerkh    ELSE 0 END ) ,
@MandeKalaAmani     = SUM( CASE WHEN tatd.IsAmani = 1 THEN  (tar.Remain * tar.nerkh)                 ELSE 0 END ) ,
																												     
@SumFroshKalaAdi    = SUM( CASE WHEN tatd.IsAmani = 0 THEN  (tar.meqdar - tar.Remain) * tar.nerkh    ELSE 0 END ) ,
@MandeKalaAdi       = SUM( CASE WHEN tatd.IsAmani = 0 THEN  (tar.Remain * tar.nerkh)                 ELSE 0 END ) 

FROM        Anbar.tbl_Amaliat_Riz                AS tar 
INNER JOIN  Anbar.tbl_Amaliat_Title              AS tat     ON tat.ID   =   tar.FK_Title
INNER JOIN  Anbar.tbl_Amaliat_Title_Detail       AS tatd    ON tat.ID   =   tatd.ID 

WHERE 
    tat.FK_Salmali  = @Year 
AND tat.kind        = 12
AND (tat.tarikh >= @Start   OR @Start   IS NULL)
AND (tat.tarikh <= @End     OR @End     IS NULL)
{IdString}

SELECT 

@SumSoodKala    = SUM(tar.mablaq - tar.nerkh_2)  

FROM        Anbar.tbl_Amaliat_Riz                AS tar 
INNER JOIN  Anbar.tbl_Amaliat_Title              AS tat     ON tat.ID   =   tar.FK_Title
--INNER JOIN  Anbar.tbl_Amaliat_Title_Detail     AS tatd    ON tat.ID   =   tatd.ID 

WHERE 
    tat.FK_Salmali  = @Year 
AND tat.kind        = 50
AND (tat.tarikh >= @Start   OR @Start   IS NULL)
AND (tat.tarikh <= @End     OR @End     IS NULL)
{IdString}

SELECT	@SumFroshKalaAmani		AS SumFroshKalaAmani ,
		@SumFroshKalaAdi		AS SumFroshKalaAdi ,
		@MandeKalaAdi			AS MandeKalaAdi, 
		@MandeKalaAmani			AS MandeKalaAmani, 
		@SumSoodKala			AS SumSoodKala

";
					return mgr.GetItem<T>(new { Start, End, Year = SystemConstant.ActiveYear.Salmali }, SqlStr);
				}
				else
				{
					return mgr.GetItem<T>(new { Start, End, Year = SystemConstant.ActiveYear.Salmali }, null);
				}


			}
			catch (Exception ex)
			{
				log.Error(ex);
			}

			return null;
		}

		#endregion

	}
}
