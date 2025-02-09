using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using MS_Control.Controls;
using NZ.Anbar.Business;
using Nz.Anbar.Model.Report;
using Nz.Anbar.Model.Report.Profit;
using ShareLib;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Component
{
    public partial class ChartSummarry : MS_Chart
    {
        public ChartSummarry()
        {
            InitializeComponent();
        }

        public MS_Chart Refresh()
        {
            var Mgr     = new ReportManager();
            var List    = Mgr.GetReport<Model.Report.Profit.ChartSummarry>
                                (new
                                {
                                    Year = SystemConstant.ActiveYear.Salmali
                                }, null);

            var remaidList  = Mgr.GetReport<ObjectRemaind>(new { Year = SystemConstant.ActiveYear.Salmali }, null);
            var remaind     = remaidList.Select(x => (decimal?)x.RemainMablaq).Sum() ?? 0;

            if (List != null || List.Any())
            {

                foreach (var item in List)
                {
                        var dp              = new DataPoint();
                        dp.AxisLabel        = item.KindString;
                        dp.LabelForeColor   = Color.Black;
                        dp.SetValueY(Convert.ToDouble(item.mablaq));
                        this.Series[0].Points.Add(dp);
                        dp.IsValueShownAsLabel = true;
                }
                //================= افزودن مانده 
                var mande = Convert.ToDouble(remaind);
                var dp2 = new DataPoint();
                dp2.AxisLabel = "مانده کالا";
                dp2.LabelForeColor = Color.Black;
                dp2.SetValueY(mande);
                this.Series[0].Points.Add(dp2);
                dp2.IsValueShownAsLabel = true;

            }
            //===================
            
            return this;
        }

        public MS_Chart RefreshSud()
        {
            this.Titles[0].Text = "سود فروش کالا";

            var Mgr = new ReportManager();
            var List = Mgr
                .GetReport<ObjectProfit>
                (new
                {
                    Year = SystemConstant.ActiveYear.Salmali,
                    KindSale = (byte)Enums.NzFactorKind.Frosh,
                    KindSaleBack = (byte)Enums.NzFactorKind.BargshtFrosh,
                }, null);

            if (List == null)
                return null;

            var Frosh = List.Sum(x => x.MountSale - x.MountSaleBack);

            var dp = new DataPoint();
            dp.AxisLabel = "فروش خالص";
            dp.LabelForeColor = Color.Black;
            dp.SetValueY(Convert.ToDouble(Frosh));
            this.Series[0].Points.Add(dp);
            dp.IsValueShownAsLabel = true;

            var Sud = List.Sum(x => x.Profit );

            dp = new DataPoint();
            dp.AxisLabel = "سود کالا";
            dp.LabelForeColor = Color.Black;
            dp.SetValueY(Convert.ToDouble(Sud));
            this.Series[0].Points.Add(dp);
            dp.IsValueShownAsLabel = true;


            return this;
        }
    }
}
