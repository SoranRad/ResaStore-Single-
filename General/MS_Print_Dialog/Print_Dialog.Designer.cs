namespace MS_Print_Dialog
{
    partial class Print_Dialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print_Dialog));
            Janus.Windows.GridEX.GridEXLayout ms_grid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference ms_grid_DesignTimeLayout_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference ms_grid_DesignTimeLayout_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.ButtonImage");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ms_grid = new MS_Control.Controls.MS_GridX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ms_copy = new MS_Control.Controls.MS_NumericTextBox();
            this.ms_ta = new MS_Control.Controls.MS_NumericTextBox();
            this.ms_az = new MS_Control.Controls.MS_NumericTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ms_page_as_ta = new System.Windows.Forms.RadioButton();
            this.ms_all_page = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.ms_preview = new Janus.Windows.EditControls.UIButton();
            this.ms_design = new Janus.Windows.EditControls.UIButton();
            this.ms_print = new Janus.Windows.EditControls.UIButton();
            this.ms_direct_print = new MS_Control.Controls.MS_CheckBox();
            this.ms_print_file = new System.Windows.Forms.CheckBox();
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.msLblWhite = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ms_grid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ms_grid);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(3, -6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(498, 277);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // ms_grid
            // 
            this.ms_grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.ms_grid.AlternatingColors = true;
            this.ms_grid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ms_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_grid.BackColor = System.Drawing.Color.White;
            this.ms_grid.BorderStyle = Janus.Windows.GridEX.BorderStyle.None;
            this.ms_grid.BuiltInTextsData = resources.GetString("ms_grid.BuiltInTextsData");
            this.ms_grid.ColumnAutoResize = true;
            this.ms_grid.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            ms_grid_DesignTimeLayout_Reference_0.Instance = ((object)(resources.GetObject("ms_grid_DesignTimeLayout_Reference_0.Instance")));
            ms_grid_DesignTimeLayout_Reference_1.Instance = ((object)(resources.GetObject("ms_grid_DesignTimeLayout_Reference_1.Instance")));
            ms_grid_DesignTimeLayout.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            ms_grid_DesignTimeLayout_Reference_0,
            ms_grid_DesignTimeLayout_Reference_1});
            ms_grid_DesignTimeLayout.LayoutString = resources.GetString("ms_grid_DesignTimeLayout.LayoutString");
            this.ms_grid.DesignTimeLayout = ms_grid_DesignTimeLayout;
            this.ms_grid.DynamicFiltering = true;
            this.ms_grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.ms_grid.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.ms_grid.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.ms_grid.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ms_grid.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.ms_grid.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ms_grid.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
            this.ms_grid.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_grid.GridLineColor = System.Drawing.Color.Red;
            this.ms_grid.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
            this.ms_grid.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.ms_grid.GroupByBoxVisible = false;
            this.ms_grid.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.ms_grid.Location = new System.Drawing.Point(-1, 8);
            this.ms_grid.Margin = new System.Windows.Forms.Padding(9, 19, 9, 19);
            this.ms_grid.Name = "ms_grid";
            this.ms_grid.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
            this.ms_grid.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
            this.ms_grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_grid.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.ms_grid.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ms_grid.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ms_grid.SelectOnExpand = false;
            this.ms_grid.Size = new System.Drawing.Size(500, 172);
            this.ms_grid.TabIndex = 21;
            this.ms_grid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ms_grid.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.ms_grid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.ms_grid.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.ms_grid_RowDoubleClick);
            this.ms_grid.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.ms_grid_ColumnButtonClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.ms_copy);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox3.Location = new System.Drawing.Point(4, 184);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(184, 87);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "تعداد کپی از هر صفحه";
            // 
            // ms_copy
            // 
            this.ms_copy.Font = new System.Drawing.Font("B Yekan", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_copy.Location = new System.Drawing.Point(4, 52);
            this.ms_copy.Margin = new System.Windows.Forms.Padding(4);
            this.ms_copy.MS_BorderColor = System.Drawing.Color.Black;
            this.ms_copy.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_copy.MS_Change_Border_Color_On_Enter = true;
            this.ms_copy.MS_Change_Color_On_Enter = true;
            this.ms_copy.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ms_copy.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_copy.MS_Exit_By_Down = true;
            this.ms_copy.MS_Exit_By_Enter = true;
            this.ms_copy.MS_Exit_By_Up = true;
            this.ms_copy.MS_Is_Negative = false;
            this.ms_copy.MS_Last_Control = this.ms_ta;
            this.ms_copy.MS_Next_Control = null;
            this.ms_copy.Name = "ms_copy";
            this.ms_copy.Size = new System.Drawing.Size(45, 28);
            this.ms_copy.TabIndex = 0;
            this.ms_copy.TabStop = false;
            this.ms_copy.Text = "0";
            this.ms_copy.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            // 
            // ms_ta
            // 
            this.ms_ta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_ta.Font = new System.Drawing.Font("B Yekan", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_ta.Location = new System.Drawing.Point(12, 53);
            this.ms_ta.Margin = new System.Windows.Forms.Padding(4);
            this.ms_ta.MS_BorderColor = System.Drawing.Color.Black;
            this.ms_ta.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_ta.MS_Change_Border_Color_On_Enter = true;
            this.ms_ta.MS_Change_Color_On_Enter = true;
            this.ms_ta.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ms_ta.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_ta.MS_Exit_By_Down = true;
            this.ms_ta.MS_Exit_By_Enter = true;
            this.ms_ta.MS_Exit_By_Up = true;
            this.ms_ta.MS_Is_Negative = false;
            this.ms_ta.MS_Last_Control = this.ms_az;
            this.ms_ta.MS_Next_Control = this.ms_copy;
            this.ms_ta.Name = "ms_ta";
            this.ms_ta.Size = new System.Drawing.Size(40, 28);
            this.ms_ta.TabIndex = 2;
            this.ms_ta.TabStop = false;
            this.ms_ta.Text = "0";
            this.ms_ta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            // 
            // ms_az
            // 
            this.ms_az.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_az.Font = new System.Drawing.Font("B Yekan", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_az.Location = new System.Drawing.Point(101, 53);
            this.ms_az.Margin = new System.Windows.Forms.Padding(4);
            this.ms_az.MS_BorderColor = System.Drawing.Color.Black;
            this.ms_az.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_az.MS_Change_Border_Color_On_Enter = true;
            this.ms_az.MS_Change_Color_On_Enter = true;
            this.ms_az.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ms_az.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_az.MS_Exit_By_Down = true;
            this.ms_az.MS_Exit_By_Enter = true;
            this.ms_az.MS_Exit_By_Up = true;
            this.ms_az.MS_Is_Negative = false;
            this.ms_az.MS_Last_Control = null;
            this.ms_az.MS_Next_Control = this.ms_ta;
            this.ms_az.Name = "ms_az";
            this.ms_az.Size = new System.Drawing.Size(42, 28);
            this.ms_az.TabIndex = 1;
            this.ms_az.TabStop = false;
            this.ms_az.Text = "0";
            this.ms_az.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "تعـداد کپـی هر صفحه :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ms_ta);
            this.groupBox2.Controls.Add(this.ms_az);
            this.groupBox2.Controls.Add(this.ms_page_as_ta);
            this.groupBox2.Controls.Add(this.ms_all_page);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(194, 184);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(301, 87);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "محدوده صفحـات";
            // 
            // ms_page_as_ta
            // 
            this.ms_page_as_ta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_page_as_ta.AutoSize = true;
            this.ms_page_as_ta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_page_as_ta.Location = new System.Drawing.Point(145, 54);
            this.ms_page_as_ta.Margin = new System.Windows.Forms.Padding(4);
            this.ms_page_as_ta.Name = "ms_page_as_ta";
            this.ms_page_as_ta.Size = new System.Drawing.Size(147, 20);
            this.ms_page_as_ta.TabIndex = 0;
            this.ms_page_as_ta.Text = "چـــاپ صفحــات     از :";
            this.ms_page_as_ta.UseVisualStyleBackColor = true;
            // 
            // ms_all_page
            // 
            this.ms_all_page.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_all_page.AutoSize = true;
            this.ms_all_page.Checked = true;
            this.ms_all_page.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_all_page.Location = new System.Drawing.Point(149, 23);
            this.ms_all_page.Margin = new System.Windows.Forms.Padding(4);
            this.ms_all_page.Name = "ms_all_page";
            this.ms_all_page.Size = new System.Drawing.Size(143, 20);
            this.ms_all_page.TabIndex = 0;
            this.ms_all_page.TabStop = true;
            this.ms_all_page.Text = "چــاپ کلیــه صفحـــات";
            this.ms_all_page.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "تـــا :";
            // 
            // ms_preview
            // 
            this.ms_preview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_preview.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_preview.Image = ((System.Drawing.Image)(resources.GetObject("ms_preview.Image")));
            this.ms_preview.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.ms_preview.ImageSize = new System.Drawing.Size(25, 25);
            this.ms_preview.Location = new System.Drawing.Point(133, 322);
            this.ms_preview.Margin = new System.Windows.Forms.Padding(4);
            this.ms_preview.Name = "ms_preview";
            this.ms_preview.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_preview.ShowFocusRectangle = false;
            this.ms_preview.Size = new System.Drawing.Size(125, 46);
            this.ms_preview.TabIndex = 1;
            this.ms_preview.Text = "پـیش نمایش چـاپ     [F6]";
            this.ms_preview.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.ms_preview.UseCompatibleTextRendering = false;
            this.ms_preview.UseThemes = false;
            this.ms_preview.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ms_preview.Click += new System.EventHandler(this.ms_preview_Click);
            // 
            // ms_design
            // 
            this.ms_design.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_design.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_design.Image = ((System.Drawing.Image)(resources.GetObject("ms_design.Image")));
            this.ms_design.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.ms_design.ImageSize = new System.Drawing.Size(25, 25);
            this.ms_design.Location = new System.Drawing.Point(4, 322);
            this.ms_design.Margin = new System.Windows.Forms.Padding(4);
            this.ms_design.Name = "ms_design";
            this.ms_design.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_design.ShowFocusRectangle = false;
            this.ms_design.Size = new System.Drawing.Size(125, 46);
            this.ms_design.TabIndex = 2;
            this.ms_design.Text = "ویرایـش قالب گزارش     [F8]";
            this.ms_design.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.ms_design.UseCompatibleTextRendering = false;
            this.ms_design.UseThemes = false;
            this.ms_design.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ms_design.Click += new System.EventHandler(this.ms_design_Click);
            // 
            // ms_print
            // 
            this.ms_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_print.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_print.Image = ((System.Drawing.Image)(resources.GetObject("ms_print.Image")));
            this.ms_print.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.ms_print.ImageSize = new System.Drawing.Size(25, 25);
            this.ms_print.Location = new System.Drawing.Point(264, 322);
            this.ms_print.Margin = new System.Windows.Forms.Padding(4);
            this.ms_print.Name = "ms_print";
            this.ms_print.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_print.ShowFocusRectangle = false;
            this.ms_print.Size = new System.Drawing.Size(141, 46);
            this.ms_print.TabIndex = 0;
            this.ms_print.Text = "ارسال مستقیم به چاپگـر     [F4]";
            this.ms_print.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.ms_print.UseCompatibleTextRendering = false;
            this.ms_print.UseThemes = false;
            this.ms_print.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ms_print.Click += new System.EventHandler(this.ms_print_Click);
            // 
            // ms_direct_print
            // 
            this.ms_direct_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_direct_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_direct_print.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_direct_print.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ms_direct_print.Location = new System.Drawing.Point(317, 273);
            this.ms_direct_print.MS_BorderColor = System.Drawing.Color.Transparent;
            this.ms_direct_print.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_direct_print.MS_Change_Border_Color_On_Enter = true;
            this.ms_direct_print.MS_Change_Color_On_Checked = true;
            this.ms_direct_print.MS_Change_Color_On_Enter = true;
            this.ms_direct_print.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_direct_print.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ms_direct_print.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ms_direct_print.MS_Exit_By_Down = false;
            this.ms_direct_print.MS_Exit_By_Enter = false;
            this.ms_direct_print.MS_Exit_By_Up = false;
            this.ms_direct_print.MS_Last_Control = null;
            this.ms_direct_print.MS_Next_Control = null;
            this.ms_direct_print.MS_UnChecked_Color = System.Drawing.Color.Empty;
            this.ms_direct_print.Name = "ms_direct_print";
            this.ms_direct_print.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_direct_print.ShowFocusRectangle = false;
            this.ms_direct_print.Size = new System.Drawing.Size(183, 20);
            this.ms_direct_print.TabIndex = 4;
            this.ms_direct_print.Text = "   سریعـاً به چاپگر ارسال شود";
            // 
            // ms_print_file
            // 
            this.ms_print_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_print_file.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_print_file.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ms_print_file.Location = new System.Drawing.Point(327, 296);
            this.ms_print_file.Margin = new System.Windows.Forms.Padding(4);
            this.ms_print_file.Name = "ms_print_file";
            this.ms_print_file.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_print_file.Size = new System.Drawing.Size(173, 20);
            this.ms_print_file.TabIndex = 5;
            this.ms_print_file.TabStop = false;
            this.ms_print_file.Text = "چـاپ در فایل";
            this.ms_print_file.UseVisualStyleBackColor = true;
            // 
            // stiReport1
            // 
            this.stiReport1.CookieContainer = null;
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport1.ReportAlias = "Report";
            this.stiReport1.ReportGuid = "59c7da09407b4d3ab5f2dfe2eec987a4";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = null;
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // msLblWhite
            // 
            this.msLblWhite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msLblWhite.AutoSize = true;
            this.msLblWhite.BackColor = System.Drawing.Color.Transparent;
            this.msLblWhite.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.msLblWhite.Location = new System.Drawing.Point(136, 379);
            this.msLblWhite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.msLblWhite.Name = "msLblWhite";
            this.msLblWhite.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.msLblWhite.Size = new System.Drawing.Size(230, 26);
            this.msLblWhite.TabIndex = 36;
            this.msLblWhite.Text = "پردازش توسط سیستم، کمی صبر نمائید.";
            this.msLblWhite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.msLblWhite.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(1, 377);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar1.Size = new System.Drawing.Size(500, 30);
            this.progressBar1.TabIndex = 37;
            // 
            // Print_Dialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(504, 372);
            this.Controls.Add(this.msLblWhite);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ms_preview);
            this.Controls.Add(this.ms_design);
            this.Controls.Add(this.ms_print);
            this.Controls.Add(this.ms_direct_print);
            this.Controls.Add(this.ms_print_file);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Print_Dialog";
            this.Text = "                                               چــاپ گــزارش";
            this.Load += new System.EventHandler(this.Print_Dialog_Load);
            this.Shown += new System.EventHandler(this.Print_Dialog_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Print_Dialog_KeyUp);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ms_grid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MS_Control.Controls.MS_GridX ms_grid;
        private System.Windows.Forms.GroupBox groupBox3;
        private MS_Control.Controls.MS_NumericTextBox ms_copy;
        private MS_Control.Controls.MS_NumericTextBox ms_ta;
        private MS_Control.Controls.MS_NumericTextBox ms_az;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ms_page_as_ta;
        private System.Windows.Forms.RadioButton ms_all_page;
        private System.Windows.Forms.Label label2;
        private Janus.Windows.EditControls.UIButton ms_preview;
        private Janus.Windows.EditControls.UIButton ms_design;
        private Janus.Windows.EditControls.UIButton ms_print;
        private MS_Control.Controls.MS_CheckBox ms_direct_print;
        private System.Windows.Forms.CheckBox ms_print_file;
        private Stimulsoft.Report.StiReport stiReport1;
        private System.Windows.Forms.Label msLblWhite;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}