using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control;
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using ShareLib;

namespace Nz.Anbar.WinForms.App
{
    public class ConvertToFactor
    {
        #region Fields

        private FactorManager _Manager;
        #endregion
        #region Constructor
        public ConvertToFactor()
        {
            _Manager = new FactorManager();
        }
        #endregion
        #region Methods
        public bool Convert(long ID, Enums.NzFactorKind DestinationKind)
        {
            try
            {
                var Source  = _Manager.GetItem(ID);
                Source.ID   = 0;
                Source.kind = (byte)DestinationKind;

                foreach (var item in Source.FactorItems)
                {
                    item.ID     = 0;
                    item.State  = Enums.NzItemState.AddedNew;
                }

                if(Source.FactorDetail!=null)
                    Source.FactorDetail.State = Enums.NzItemState.AddedNew;

                _Manager.Save(Source);
                return true;
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در زخیره فاکتور", "خطا", ex.Message
                    , MessageBoxButtons.OK, MSMessage.FarsiMessageBoxIcon.خطا);
                return false;
            }
        }
        #endregion
    }
}
