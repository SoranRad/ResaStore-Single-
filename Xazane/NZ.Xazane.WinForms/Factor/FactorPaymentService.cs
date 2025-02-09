using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NZ.Xazane.Business;
using NZ.Xazane.Model.ViewModel;
using NZ.Xazane.WinForms.App;
using ShareLib;
using ShareLib.Interfaces;
using ShareLib.ViewModel;

namespace NZ.Xazane.WinForms.Factor
{
    public class FactorPaymentService 
    {
        private readonly FactorPaymentMessage _message;

        public FactorPaymentService(FactorPaymentMessage Message)
        {
            _message = Message;
        }

        private bool FactorHasPayment()
        {
            var mgr = new ReportManager();
            var payment = mgr.GetItem<FactorPaymentList>(new {IdFactor = _message.IDFactor}, null);
            return payment?.CountCheque > 0;
        }

        public IForm_Editor GetForm()
        {
            if(!FactorHasPayment())
            {
                switch (_message.Kind)
                {
                    case Enums.NzPaymentOperatingKind.Daryaft:
                        return new FormPayment(); 
                    case Enums.NzPaymentOperatingKind.Pardaxt:
                        return new FormPayment(0,Enums.NzPaymentOperatingKind.Pardaxt);
                    default:
                        return null;
                }
            }
            
            return new FormFactorPaymentList(_message);
        }
    }
}
