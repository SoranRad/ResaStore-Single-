using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control.Controls;
using ShareLib;
using ShareLib.Interfaces;
using ShareLib.Models;
using ShareLib.ViewModel;

namespace Nz.Machine.Winforms.Provider
{
    public class MachineProvider : IEntryProvider
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        public  static Form     MainForm;
        private MachineMenuBar  Menues;
        public  string          GetName         => "پذیرش خودرو";
        public  ToolStripItem   MainMenuSysytem => null;

        #endregion
        #region Constructor

        public MachineProvider()
        {
            Menues = new MachineMenuBar();
        }
        #endregion
        public bool                                     AnyAlaram   ()
        {
            return false;
        }
        public global::Janus.Windows.UI.Tab.UITabPage   GeTabPage   ()
        {
            return null;
        }

        public IEnumerable<BillRowItem>                 GetBillDetail(long People, short? Year, DateTime? DateFrom, DateTime? DateTo, byte Group)
        {
            return null;
        }
        public IEnumerable<CircularRowItem>             GetBillItems(long People, short? Year, DateTime? DateFrom, DateTime? DateTo, byte Group)
        {
            return null;
        }

        public bool GetFeature(short FeatureItem)
        {
            return true;
        }

        public IForm_Editor GetFormForEdit(Enums.FormOperation FormKind, params object[] otherParam)
        {
            return null;
        }

        public IEnumerable<RemaindPeople> GetListRemaind(DateTime? AzTarikh, DateTime? TaTarikh)
        {
            return null;
        }

        public ToolStripItemCollection GetMenu(Enums.MenuKind MenuType)
        { 
            switch (MenuType)
            {
                case Enums.MenuKind.BaseInfo:
                    return Menues.ms_baseinfo.DropDownItems;
                case Enums.MenuKind.Operation:
                    return Menues.MachineMenu.DropDownItems;
                case Enums.MenuKind.Reports:
                    return Menues.NzReport.DropDownItems;
                case Enums.MenuKind.Settings:
                    return null;
                case Enums.MenuKind.Management:
                    return null;
                default:
                    return null;
            }
        }

      

        public decimal GetRemainAll(long IDCustomer)
        {
            return 0;
        }

        public decimal GetRemaind(long ID)
        {
            return 0;
        }

        public Form GetSimpleForm(Enums.FormOperation FormKind)
        {
            return null;
        }

        public Enums.MS_System GetSystemKind()
        {
            return Enums.MS_System.Machine;
        }

        public void RefreshAlaram()
        {
             
        }

        public void SetMainForm(Form mainForm)
        {
            MainForm = mainForm;
        }

        public void SetProperty(string Name, object Value)
        {
            throw new NotImplementedException();
        }
        public object GetProperty(string Name)
        {
            throw new NotImplementedException();
        }

        public async Task<MS_Chart[]> GetChartSummarry()
        {
            return null;
        }

        public Task<IEnumerable<DailyCircular>> GetDailyCircular(short Year, short Month)
        {
            try
            {
                return Task.FromResult((IEnumerable<DailyCircular>)null) ;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return null;

            }
        }
    }
}
