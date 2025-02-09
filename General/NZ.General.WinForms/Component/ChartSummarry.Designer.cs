namespace NZ.General.WinForms.Component
{
    partial class ChartSummarry
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartSummarry
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("IRANSans(FaNum)", 10F);
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.SteelBlue;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("IRANSans(FaNum)", 10F);
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.SteelBlue;
            chartArea1.AxisY.LabelStyle.Format = "0,0.##;(0,0.##); ";
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.ChartAreas.Add(chartArea1);
            this.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("IRANSans(FaNum)", 10F);
            series1.IsValueShownAsLabel = true;
            series1.Label = "#VALY{0,0.##;0,0.##; }";
            series1.LabelFormat = "0,0.##;0,0.##; ";
            series1.Name = "Series1";
            this.Series.Add(series1);
            title1.Font = new System.Drawing.Font("IRANSans(FaNum)", 10F);
            title1.ForeColor = System.Drawing.Color.Green;
            title1.Name = "Title1";
            this.Titles.Add(title1);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
