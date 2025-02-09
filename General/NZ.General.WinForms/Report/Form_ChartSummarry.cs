using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShareLib.Utils;

namespace NZ.General.WinForms.Report
{
    public partial class Form_ChartSummarry : Form
    {
        public Form_ChartSummarry()
        {
            InitializeComponent();
        }

        private async void Form_ChartSummarry_Shown(object sender, EventArgs e)
        {
            foreach (var system in Form_Factory.SystemList)
            {
                var charts = await system.GetChartSummarry();

                if(charts == null)
                    continue;

                foreach (var chart in charts)
                {
                    
                    this.Invoke((MethodInvoker)(() =>
                    {
                        tableLayoutPanel1.Controls.Add(chart);
                        chart.Dock = DockStyle.Fill;
                    }));
                }
            }
        }
    }
}
