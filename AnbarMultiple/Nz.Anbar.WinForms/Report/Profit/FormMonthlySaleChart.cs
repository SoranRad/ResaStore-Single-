using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nz.Anbar.WinForms.Report.Profit
{
    public partial class FormMonthlySaleChart : Form
    {
        public FormMonthlySaleChart()
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
            RefreshChart();
        }

        private void RefreshChart()
        {
            var list = new List<MonthlyProfit>()
            {
                new MonthlyProfit(){MonthName = "فروردین",Value = 2000},
                new MonthlyProfit(){MonthName = "اردیبهشت",Value = 2500},
                new MonthlyProfit(){MonthName = "خرداد",Value = 2100},

                new MonthlyProfit(){MonthName = "تیر",Value = 2300},
                new MonthlyProfit(){MonthName = "مرداد",Value = 1000},
                new MonthlyProfit(){MonthName = "شهریور",Value = 1300},

                new MonthlyProfit(){MonthName = "مهر",Value = 1200},
                new MonthlyProfit(){MonthName = "آبان",Value = 3300},
                new MonthlyProfit(){MonthName = "آذر",Value = 2900},

                new MonthlyProfit(){MonthName = "دی",Value = 2700},
                new MonthlyProfit(){MonthName = "بهمن",Value = 2800},
                new MonthlyProfit(){MonthName = "اسقند",Value = 2600},
            };

            mS_Chart1.DataSource = list.ToList();

            mS_Chart1.Series[0].XValueMember = "MonthName";
            mS_Chart1.Series[0].YValueMembers = "Value";

            mS_Chart1.Series[1].XValueMember = "MonthName";
            mS_Chart1.Series[1].YValueMembers = "Value";
            //mS_Chart1.Series[0].IsValueShownAsLabel = true;
            mS_Chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
        }
    }
}
