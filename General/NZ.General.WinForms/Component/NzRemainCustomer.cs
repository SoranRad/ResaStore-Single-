using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control;
using ShareLib.Utils;

namespace NZ.General.WinForms.Component
{
    public partial class NzRemainCustomer : MS_Control.Controls.MS_Lable_Ex
    {
        public NzRemainCustomer()
        {
            InitializeComponent();
        }

        public  void    NzSetCustoemr       (long FK_People)
        {
            Task.Run(() =>
            {
                List<decimal> Balance = new List<decimal>();
                Form_Factory.SystemList.MSZ_ForEach(x =>
                {
                    Balance.Add(x.GetRemaind(FK_People));
                });
                Show(Balance.Sum());
            });
        }
        private void    Show     (decimal Balance)
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(delegate
                {
                    this.Text = Balance.ToString("0,0.##;(0,0.##); ")
                                + @"  "
                                + (Balance > 0 ? @"بدهکار" :(Balance<0 ? @"بستانکار" : ""));
                }));
            else
                    this.Text = Balance.ToString("0,0.##;(0,0.##); ")
                                + @"  "
                                + (Balance > 0 ? @"بدهکار" : (Balance < 0 ? @"بستانکار" : ""));
        }
    }
}
