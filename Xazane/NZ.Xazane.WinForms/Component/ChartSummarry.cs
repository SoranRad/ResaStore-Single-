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
using NZ.Xazane.Business;
using NZ.Xazane.Model.Report;
using ShareLib;
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.Component
{
    public partial class ChartSummarry : MS_Chart
    {
        public ChartSummarry()
        {
            InitializeComponent();
        }

        public MS_Chart RefreshDP()
        {
            var mgr = new ReportManager();
            var List = mgr.GetReport<PaymentsTransaction>(
                new
                {
                    Year            = SystemConstant.ActiveYear.Salmali,
                    DaryaftKind     = (byte)Enums.NzPaymentOperatingKind.Daryaft,
                    PardakhtKind    = (byte)Enums.NzPaymentOperatingKind.Pardaxt

                }, null);

            if (List != null || List.Any())
            {
                foreach (var item in List)
                {
                     
                        var dp              = new DataPoint();
                        dp.AxisLabel        = item.KindString;
                        dp.LabelForeColor   = Color.Black;
                        dp.SetValueY(Convert.ToDouble(item.Mablaq));
                        this.Series[0].Points.Add(dp);
                        dp.IsValueShownAsLabel = true;
                }
            }

            return this;
        }

        public MS_Chart RefreshCheque()
        {
            this.Titles[0].Text = "وضعیت چک هـا";
            this.Palette = ChartColorPalette.Chocolate;

            var mgr = new ReportManager();
            var list = mgr.GetReport<AnalyzeCheque>(
                new
                {
                    Year = SystemConstant.ActiveYear.Salmali
                }, null);

            foreach (var item in list)
            {
                var dp = new DataPoint();
                dp.AxisLabel = item.Title;
                dp.LabelForeColor = Color.Black;
                dp.SetValueY(Convert.ToDouble(item.Balance));
                this.Series[0].Points.Add(dp);
                dp.IsValueShownAsLabel = true;

            }

            return this;
        }

        public MS_Chart RefreshHazine()
        {
            this.Titles[0].Text = "هزینه ها";
            this.Palette        = ChartColorPalette.Fire;

            var mgr = new ReportManager();
            var list = mgr.GetReport<HazineDaramadGroping>(
                new
                {
                    Year = SystemConstant.ActiveYear.Salmali,
                    Kind = Enums.NzPaymentOperatingKind.Hazine
                }, null);

            foreach (var item in list)
            {
                var dp = new DataPoint();
                dp.AxisLabel = item.Title;
                dp.LabelForeColor = Color.Black;
                dp.SetValueY(Convert.ToDouble(item.Mablaq));
                this.Series[0].Points.Add(dp);
                dp.IsValueShownAsLabel = true;

            }


            return this;
        }
        public MS_Chart RefreshDaramad()
        {
            this.Titles[0].Text = "درآمد ها";

            var mgr = new ReportManager();
            var list = mgr.GetReport<HazineDaramadGroping>(
                new
                {
                    Year = SystemConstant.ActiveYear.Salmali,
                    Kind = Enums.NzPaymentOperatingKind.Daramad
                }, null);

            foreach (var item in list)
            {
                var dp = new DataPoint();
                dp.AxisLabel = item.Title;
                dp.LabelForeColor = Color.Black;
                dp.SetValueY(Convert.ToDouble(item.Mablaq));
                this.Series[0].Points.Add(dp);
                dp.IsValueShownAsLabel = true;

            }


            return this;
        }
    }
}
