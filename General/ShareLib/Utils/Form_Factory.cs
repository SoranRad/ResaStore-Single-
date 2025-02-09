using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShareLib.Interfaces;

namespace ShareLib.Utils
{
    public static class Form_Factory
    {
        #region Fields
        public static   IForm_Factory
                                                //_Form_Factory_General,
                                                _Form_Factory_Aqsat,
                                                _Form_Factory_Shoraka,
                                                _Form_Factory_Tajmihi;

        public static IEntryProvider            _Form_Factory_Anbar, 
                                                _Form_Factory_Xazaneh,
                                                _Form_Factory_General,
                                                _Form_Factory_Machine,
                                                _Form_Factory_Bar;

        public static List<IEntryProvider>      SystemList = new List<IEntryProvider>();
        #endregion
        #region Methods
        public static bool          IsSystemValid               (Enums.MS_System KindSystem)
        {
            return SystemList.Any(x => x.GetSystemKind() == KindSystem);
        }
        public static decimal       GetCustomerBillRemain       (long ID)
        {
            return 0;
        }
        
        #endregion
        public static Form LoadingForm  { get; set; }
        public static Form LoginForm    { get; set; }
        public static Form ExitForm     { get; set; }
        //================================

        public static ICommand CmdChangeUser, CmdChangeUsYear, CmdChangePass;
    }
}
