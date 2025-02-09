using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using MS_Control;
using MS_Control.Controls;
using ShareLib.Utils;
using ShareLib.ViewModel;

namespace NZ.General.WinForms.Component
{
    public partial class ChartSummarry : MS_Chart
    {
        public ChartSummarry()
        {
            InitializeComponent();
        }

        public MS_Chart Refresh()
        {
            var List = new List<RemaindPeople>();
            Form_Factory
                .SystemList
                .MSZ_ForEach(x =>
                {
                    var list = x.GetListRemaind(null ,null);

                    if (list != null)
                        List.InsertRange(0, list);
                });

            List = List.GroupBy(x => new
            {
                x.ID,
               
            }).Select(x => new RemaindPeople
            {
                
                Balance = x.Sum(y => y.Balance),

            }).ToList();

            var BadMount = List.Where(x => x.Balance > 0).Sum(x=>x.Balance);
            var BasMount = List.Where(x => x.Balance < 0).Sum(x=>Math.Abs( x.Balance));


            this.Titles[0].Text = "مجموع بدهکاری و بستانکاری";

            var dp = new DataPoint();
            dp.AxisLabel = "مجموع بدهکاری";
            dp.LabelForeColor = Color.Black;
            dp.SetValueY(Convert.ToDouble(BadMount));
            this.Series[0].Points.Add(dp);
            dp.IsValueShownAsLabel = true;

            dp = new DataPoint();
            dp.AxisLabel = "مجموع بستانکاری";
            dp.LabelForeColor = Color.Black;
            dp.SetValueY(Convert.ToDouble(BasMount));
            this.Series[0].Points.Add(dp);
            dp.IsValueShownAsLabel = true;

            return this;
        }
    }
}
