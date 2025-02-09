namespace Nz.Anbar.WinForms.Report
{
	partial class FormPriceChart
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPriceChart));
			Janus.Windows.GridEX.GridEXLayout ms_Grid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
			this.Tab_Control_Main = new Janus.Windows.UI.Tab.UITab();
			this.Ns_Chart = new MS_Control.Controls.MS_Chart();
			this.ms_Grid = new MS_Control.Controls.MS_GridX();
			this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
			this.NzReport = new MS_Control.Controls.MS_Button_GridX();
			this.label2 = new System.Windows.Forms.Label();
			this.uiTabPage12 = new Janus.Windows.UI.Tab.UITabPage();
			this.NzObjectSelection = new Nz.Anbar.WinForms.Component.NzObjectCombo();
			((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).BeginInit();
			this.Tab_Control_Main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Ns_Chart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ms_Grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
			this.uiGroupBox2.SuspendLayout();
			this.uiTabPage12.SuspendLayout();
			this.SuspendLayout();
			// 
			// Tab_Control_Main
			// 
			this.Tab_Control_Main.BackColor = System.Drawing.Color.Transparent;
			this.Tab_Control_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Tab_Control_Main.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Tab_Control_Main.Location = new System.Drawing.Point(0, 0);
			this.Tab_Control_Main.MultiLine = true;
			this.Tab_Control_Main.Name = "Tab_Control_Main";
			this.Tab_Control_Main.Office2007CustomColor = System.Drawing.Color.Transparent;
			this.Tab_Control_Main.ShowFocusRectangle = false;
			this.Tab_Control_Main.ShowTabs = false;
			this.Tab_Control_Main.Size = new System.Drawing.Size(1107, 455);
			this.Tab_Control_Main.TabIndex = 1;
			this.Tab_Control_Main.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage12});
			this.Tab_Control_Main.TabsStateStyles.DisabledFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Tab_Control_Main.TabsStateStyles.DisabledFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Tab_Control_Main.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.PowderBlue;
			this.Tab_Control_Main.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Gold;
			this.Tab_Control_Main.TabsStateStyles.SelectedFormatStyle.Font = new System.Drawing.Font("IRANSans(Small) Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Tab_Control_Main.TabsStateStyles.SelectedFormatStyle.FontSize = 14F;
			this.Tab_Control_Main.TabStripAlignment = Janus.Windows.UI.Tab.TabStripAlignment.Right;
			this.Tab_Control_Main.TextOrientation = Janus.Windows.UI.Tab.TextOrientation.Vertical;
			this.Tab_Control_Main.UseThemes = false;
			this.Tab_Control_Main.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
			// 
			// Ns_Chart
			// 
			this.Ns_Chart.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
			this.Ns_Chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Ns_Chart.BorderlineColor = System.Drawing.Color.Black;
			this.Ns_Chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea1.AxisX.Interval = 1D;
			chartArea1.AxisX.IsLabelAutoFit = false;
			chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
			chartArea1.AxisX.MajorGrid.Enabled = false;
			chartArea1.AxisX2.Interval = 1D;
			chartArea1.AxisX2.IsLabelAutoFit = false;
			chartArea1.AxisX2.LabelStyle.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
			chartArea1.AxisX2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
			chartArea1.AxisY.IsLabelAutoFit = false;
			chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
			chartArea1.AxisY.LabelStyle.Format = "0,0.##;(0,0.##); ";
			chartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
			chartArea1.AxisY.MajorGrid.Enabled = false;
			chartArea1.AxisY2.IsLabelAutoFit = false;
			chartArea1.AxisY2.LabelStyle.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
			chartArea1.AxisY2.LabelStyle.Format = "0,0.##;(0,0.##); ";
			chartArea1.Name = "ChartArea1";
			this.Ns_Chart.ChartAreas.Add(chartArea1);
			legend1.DockedToChartArea = "ChartArea1";
			legend1.Font = new System.Drawing.Font("IRANSans(Small)", 12F);
			legend1.IsTextAutoFit = false;
			legend1.Name = "Legend1";
			legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
			legend1.TitleFont = new System.Drawing.Font("IRANSans(Small)", 8F, System.Drawing.FontStyle.Bold);
			this.Ns_Chart.Legends.Add(legend1);
			this.Ns_Chart.Location = new System.Drawing.Point(241, 54);
			this.Ns_Chart.Name = "Ns_Chart";
			this.Ns_Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
			series1.IsValueShownAsLabel = true;
			series1.Label = "#VALY{0,0.##;0,0.##; }";
			series1.LabelFormat = "0,0.##;0,0.##; ";
			series1.Legend = "Legend1";
			series1.Name = "خرید";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series2.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
			series2.IsValueShownAsLabel = true;
			series2.Label = "#VALY{0,0.##;0,0.##; }";
			series2.LabelFormat = "0,0.##;0,0.##; ";
			series2.Legend = "Legend1";
			series2.Name = "فروش";
			this.Ns_Chart.Series.Add(series1);
			this.Ns_Chart.Series.Add(series2);
			this.Ns_Chart.Size = new System.Drawing.Size(861, 398);
			this.Ns_Chart.TabIndex = 3;
			// 
			// ms_Grid
			// 
			this.ms_Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.ms_Grid.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
			this.ms_Grid.AlternatingColors = true;
			this.ms_Grid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ms_Grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.ms_Grid.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ms_Grid.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
			this.ms_Grid.BuiltInTextsData = resources.GetString("ms_Grid.BuiltInTextsData");
			this.ms_Grid.ColumnAutoResize = true;
			this.ms_Grid.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
			this.ms_Grid.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.ms_Grid.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
			ms_Grid_DesignTimeLayout.LayoutString = resources.GetString("ms_Grid_DesignTimeLayout.LayoutString");
			this.ms_Grid.DesignTimeLayout = ms_Grid_DesignTimeLayout;
			this.ms_Grid.DynamicFiltering = true;
			this.ms_Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.ms_Grid.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.ms_Grid.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
			this.ms_Grid.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ms_Grid.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
			this.ms_Grid.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
			this.ms_Grid.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
			this.ms_Grid.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.ms_Grid.FrozenColumns = 2;
			this.ms_Grid.GridLineColor = System.Drawing.Color.Black;
			this.ms_Grid.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
			this.ms_Grid.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
			this.ms_Grid.GroupByBoxVisible = false;
			this.ms_Grid.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ms_Grid.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.ms_Grid.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			this.ms_Grid.Location = new System.Drawing.Point(-1, 54);
			this.ms_Grid.Name = "ms_Grid";
			this.ms_Grid.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
			this.ms_Grid.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
			this.ms_Grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ms_Grid.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
			this.ms_Grid.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ms_Grid.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.ms_Grid.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ms_Grid.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
			this.ms_Grid.SelectOnExpand = false;
			this.ms_Grid.Size = new System.Drawing.Size(242, 400);
			this.ms_Grid.TabIndex = 2;
			this.ms_Grid.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
			this.ms_Grid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ms_Grid.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.ms_Grid.TreeLineColor = System.Drawing.Color.Black;
			this.ms_Grid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// uiGroupBox2
			// 
			this.uiGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.uiGroupBox2.BackColor = System.Drawing.Color.Transparent;
			this.uiGroupBox2.BorderColor = System.Drawing.Color.LightBlue;
			this.uiGroupBox2.Controls.Add(this.NzObjectSelection);
			this.uiGroupBox2.Controls.Add(this.NzReport);
			this.uiGroupBox2.Controls.Add(this.label2);
			this.uiGroupBox2.Location = new System.Drawing.Point(4, -3);
			this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.uiGroupBox2.Name = "uiGroupBox2";
			this.uiGroupBox2.Size = new System.Drawing.Size(1096, 51);
			this.uiGroupBox2.TabIndex = 0;
			// 
			// NzReport
			// 
			this.NzReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzReport.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzReport.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NzReport.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzReport.Image = ((System.Drawing.Image)(resources.GetObject("NzReport.Image")));
			this.NzReport.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.NzReport.Location = new System.Drawing.Point(625, 9);
			this.NzReport.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzReport.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzReport.MS_Change_Border_Color_On_Enter = false;
			this.NzReport.MS_Change_Color_On_Enter = false;
			this.NzReport.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NzReport.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NzReport.Name = "NzReport";
			this.NzReport.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.NzReport.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.NzReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzReport.ShowFocusRectangle = false;
			this.NzReport.Size = new System.Drawing.Size(129, 35);
			this.NzReport.TabIndex = 3;
			this.NzReport.Text = "مشـاهده گزارش";
			this.NzReport.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
			this.NzReport.UseThemes = false;
			this.NzReport.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NzReport.WordWrap = false;
			this.NzReport.Click += new System.EventHandler(this.NzReport_Click);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label2.Location = new System.Drawing.Point(1052, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 23);
			this.label2.TabIndex = 756;
			this.label2.Text = " کالا :";
			// 
			// uiTabPage12
			// 
			this.uiTabPage12.Controls.Add(this.Ns_Chart);
			this.uiTabPage12.Controls.Add(this.ms_Grid);
			this.uiTabPage12.Controls.Add(this.uiGroupBox2);
			this.uiTabPage12.Location = new System.Drawing.Point(1, 1);
			this.uiTabPage12.Name = "uiTabPage12";
			this.uiTabPage12.PanelFormatStyle.Alpha = 70;
			this.uiTabPage12.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.uiTabPage12.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.uiTabPage12.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
			this.uiTabPage12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.uiTabPage12.Size = new System.Drawing.Size(1105, 453);
			this.uiTabPage12.TabStop = true;
			this.uiTabPage12.Text = "اطلاعات";
			// 
			// NzObjectSelection
			// 
			this.NzObjectSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzObjectSelection.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
			this.NzObjectSelection.DropSize = new System.Drawing.Size(290, 27);
			this.NzObjectSelection.Font = new System.Drawing.Font("IRANSans(Small)", 12F);
			this.NzObjectSelection.Location = new System.Drawing.Point(760, 15);
			this.NzObjectSelection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.NzObjectSelection.MS_Auto_Popup = false;
			this.NzObjectSelection.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzObjectSelection.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzObjectSelection.MS_CaptureFocus = false;
			this.NzObjectSelection.MS_Change_Border_Color_On_Enter = true;
			this.NzObjectSelection.MS_Change_Color_On_Enter = true;
			this.NzObjectSelection.MS_Drop_Direction = MS_Control.TSDD.KindShow.Right;
			this.NzObjectSelection.MS_DropDownSizeMode = MS_Control.TSDD.SizeMode.Control_Size;
			this.NzObjectSelection.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzObjectSelection.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzObjectSelection.MS_Exit_By_Down = true;
			this.NzObjectSelection.MS_Exit_By_Enter = true;
			this.NzObjectSelection.MS_Exit_By_Up = true;
			this.NzObjectSelection.MS_Last_Control = null;
			this.NzObjectSelection.MS_Next_Control = null;
			this.NzObjectSelection.Name = "NzObjectSelection";
			this.NzObjectSelection.Office2007CustomColor = System.Drawing.Color.SkyBlue;
			this.NzObjectSelection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzObjectSelection.Size = new System.Drawing.Size(290, 27);
			this.NzObjectSelection.TabIndex = 0;
			this.NzObjectSelection.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// FormPriceChart
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1107, 455);
			this.Controls.Add(this.Tab_Control_Main);
			this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormPriceChart";
			this.Text = "گزارش نوسان قیمت";
			((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).EndInit();
			this.Tab_Control_Main.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Ns_Chart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ms_Grid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
			this.uiGroupBox2.ResumeLayout(false);
			this.uiGroupBox2.PerformLayout();
			this.uiTabPage12.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Janus.Windows.UI.Tab.UITab Tab_Control_Main;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage12;
		private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
		private Component.NzObjectCombo NzObjectSelection;
		private MS_Control.Controls.MS_Button_GridX NzReport;
		private System.Windows.Forms.Label label2;
		private MS_Control.Controls.MS_GridX ms_Grid;
		private MS_Control.Controls.MS_Chart Ns_Chart;
	}
}