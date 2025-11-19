namespace Nz.Anbar.WinForms.Report.Profit
{
    partial class FormMonthlySaleChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.mS_Chart1 = new MS_Control.Controls.MS_Chart();
            this.mS_Panel1 = new MS_Control.Controls.MS_Panel();
            ((System.ComponentModel.ISupportInitialize)(this.mS_Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // mS_Chart1
            // 
            this.mS_Chart1.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.mS_Chart1.BorderlineColor = System.Drawing.Color.Black;
            this.mS_Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            chartArea1.AxisX.LineColor = System.Drawing.Color.Cyan;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("IRANSans(FaNum)", 8F);
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Cyan;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Cyan;
            chartArea1.Name = "ChartArea1";
            this.mS_Chart1.ChartAreas.Add(chartArea1);
            this.mS_Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mS_Chart1.Legends.Add(legend1);
            this.mS_Chart1.Location = new System.Drawing.Point(0, 52);
            this.mS_Chart1.Name = "mS_Chart1";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.MediumSeaGreen;
            series1.Font = new System.Drawing.Font("IRANSans(FaNum)", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "0,0.##;(0,0.##); ";
            series1.Legend = "Legend1";
            series1.LegendText = "فروش";
            series1.Name = "Sale";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.LegendText = "سود و زیان";
            series2.Name = "Profit";
            this.mS_Chart1.Series.Add(series1);
            this.mS_Chart1.Series.Add(series2);
            this.mS_Chart1.Size = new System.Drawing.Size(800, 398);
            this.mS_Chart1.TabIndex = 0;
            title1.Font = new System.Drawing.Font("IRANSans Medium", 12F);
            title1.Name = "Title1";
            title1.Text = "نمودار فروش به تفکیک ماه";
            this.mS_Chart1.Titles.Add(title1);
            // 
            // mS_Panel1
            // 
            this.mS_Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.mS_Panel1.Location = new System.Drawing.Point(0, 0);
            this.mS_Panel1.MS_BorderColor = System.Drawing.Color.Aqua;
            this.mS_Panel1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Panel1.MS_Color_End = System.Drawing.Color.PowderBlue;
            this.mS_Panel1.MS_Color_Start = System.Drawing.Color.LightSkyBlue;
            this.mS_Panel1.Name = "mS_Panel1";
            this.mS_Panel1.Size = new System.Drawing.Size(800, 52);
            this.mS_Panel1.TabIndex = 722;
            // 
            // FormMonthlySaleChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mS_Chart1);
            this.Controls.Add(this.mS_Panel1);
            this.Name = "FormMonthlySaleChart";
            this.Text = "گزارش نمودار فروش به تفکیک ماه";
            ((System.ComponentModel.ISupportInitialize)(this.mS_Chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MS_Control.Controls.MS_Chart mS_Chart1;
        private MS_Control.Controls.MS_Panel mS_Panel1;
    }
}