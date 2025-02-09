using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.UI.Tab;
using MS_Control.Controls;
using ShareLib.Models;
using ShareLib.ViewModel;

namespace ShareLib.Interfaces
{
    public interface IEntryProvider
    {
        IEnumerable<BillRowItem>        GetBillDetail           (long People ,short? Year ,DateTime? DateFrom,DateTime? DateTo,byte Group);
        IEnumerable<CircularRowItem>    GetBillItems            (long People ,short? Year ,DateTime? DateFrom,DateTime? DateTo,byte Group);

        decimal                         GetRemaind(long ID);
        IEnumerable<RemaindPeople>      GetListRemaind(DateTime? AzTarikh,DateTime? TaTarikh);

        decimal                         GetRemainAll            (long IDCustomer);
        ToolStripItemCollection         GetMenu                 (Enums.MenuKind MenuType);
        string                          GetName                 { get; }
        Enums.MS_System                 GetSystemKind           ();
        IForm_Editor                    GetFormForEdit          (Enums.FormOperation FormKind,params object[] otherParam);
        Form                            GetSimpleForm           (Enums.FormOperation FormKind);
        ToolStripItem                   MainMenuSysytem         { get; }
        void                            SetProperty             (string Name, object Value);
        object                          GetProperty             (string Name);
        void                            SetMainForm             (Form mainForm);
        bool                            GetFeature              (short FeatureItem);

        void                            RefreshAlaram           ();
        bool                            AnyAlaram               ();
        UITabPage                       GeTabPage               ();
        Task<MS_Chart[]>                GetChartSummarry        ();

        Task<IEnumerable<DailyCircular>> GetDailyCircular (short Year,short Month);

    }
}
