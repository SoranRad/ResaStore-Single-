using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control;
using NZ.General.Business;
using ShareLib.Models;
using ShareLib.Utils;

namespace NZ.General.WinForms.Component
{
    public partial class NzRemainCustomer : MS_Control.Controls.MS_Lable_Ex
    {
        private People      _people;
        private decimal     _balance;
        private long        _Id_People;

        public NzRemainCustomer()
        {
            InitializeComponent();
			this.Click += NzRemainCustomer_Click;
        }

		private void NzRemainCustomer_Click(object sender, EventArgs e)
		{
			NzSetCustoemr(_Id_People);
		}

		public  void    NzSetCustoemr       (long FK_People)
        {
            Task.Run( async () =>
            {
	            _Id_People = FK_People;
                List<decimal> Balance = new List<decimal>();
                Form_Factory.SystemList.MSZ_ForEach(x =>
                {
                    Balance.Add(x.GetRemaind(FK_People));
                });
                
                _balance = Balance.Sum();
                
                await Show(_balance);

                var mgr = new Manager();
                _people = mgr.GetItem<People>(new { ID = FK_People });

            });
        }


        public bool IsUserBlocked(decimal Mablaq)
        {
	        if (!_people.isBlock.HasValue)
		        return false;

	        if (_people.isBlock == true && _people.BlockMablaq!=0)
	        {
		        if ((Math.Abs(_balance) + Math.Abs(Mablaq)) > Math.Abs(_people.BlockMablaq ?? 0))
			        return true;
	        }
             
            return false;
        }

        private async  Task  Show     (decimal Balance)
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
