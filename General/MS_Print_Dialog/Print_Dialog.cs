using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

using MS_Control;
using Stimulsoft.Report.Components;
using Janus.Windows.GridEX;

namespace MS_Print_Dialog
{
    public partial class Print_Dialog : MS_Mother_Two
    {
        public Print_Dialog()
        {
            InitializeComponent();
        }
        #region DllImport
        [DllImport("winspool.Drv", EntryPoint = "DocumentPropertiesW", SetLastError = true,
        ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        static extern int DocumentProperties(IntPtr hwnd, IntPtr hPrinter,
        [MarshalAs(UnmanagedType.LPWStr)] string pDeviceName,
        IntPtr pDevModeOutput, ref IntPtr pDevModeInput, int fMode);
        [DllImport("kernel32.dll")]
        static extern IntPtr GlobalLock(IntPtr hMem);
        [DllImport("kernel32.dll")]
        static extern bool GlobalUnlock(IntPtr hMem);
        [DllImport("kernel32.dll")]
        static extern bool GlobalFree(IntPtr hMem);
        #endregion
        #region فیلد
        public static PrinterSettings   _Printer_Setting;
        public static bool?             _Do_Direct_Print;
        //private bool                    _Do_Refresh     = true;
        string                          pathReport      = "";
        //=====
        public static ManagementObjectSearcher      search = null; //= new ManagementObjectSearcher();
        public static ManagementObjectCollection    results;
        Object[]                                    args = new Object[1];
        StiPage                                     Page = new StiPage();
        private List<MS_Report_Loading>             _List_Report;
        private bool                                _Print_List = false,
                                                    _Is_Rendered = false;
        private int                                 TempHeight = 400;
        private delegate void Progress_Change();
        //=====
        #endregion
        #region متد
        private void Load_Printer_Setting           ()
        {
            //_Do_Refresh = false;
            if (_Printer_Setting == null)
                _Printer_Setting = new PrinterSettings();
            Load_List_Printers();
            //_Do_Refresh = true;
            ms_copy.MS_Decimal = _Printer_Setting.Copies;
            ms_az.MS_Decimal = _Printer_Setting.FromPage;
            ms_ta.MS_Decimal = _Printer_Setting.ToPage;
        }
        private void Load_List_Printers             ()
        {
            if (_Do_Direct_Print.HasValue)
                ms_direct_print.Checked = _Do_Direct_Print.Value;
            try
            {
                //=============================
                MemoryStream ms = new MemoryStream();
                Properties.Resources.check.Save(ms, Properties.Resources.check.RawFormat);
                byte[] arrImage = ms.GetBuffer();

                var list = (from i in  System.Drawing.Printing.PrinterSettings.InstalledPrinters.OfType<string>()
                           select new 
                           {
                               title = i,
                               is_default = _Printer_Setting.PrinterName.Equals(i)
	                               ? arrImage
                                   : null,
                           })
	                        .ToList();

                ms_grid.DataSource = list;
                ms_grid.FilterMode = FilterMode.None;
                ms_grid.Refresh();

                var r = ms_grid.GetRows()
                    .FirstOrDefault(x => x.Cells["title"].Text == _Printer_Setting.PrinterName);
                if (r != null)
                {
                    ms_grid.MoveTo(r);
                    ms_grid.EnsureVisible(r.Position);
                }

                //foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                //{
                // MessageBox.Show(printer);
                //}

                //if (search == null)
                //{
                //    search = new ManagementObjectSearcher();
                //    search = new ManagementObjectSearcher("select * from win32_printer");
                //    results = search.Get();
                //}
                ////=============================
                //MemoryStream ms = new MemoryStream();
                //Properties.Resources.check.Save(ms, Properties.Resources.check.RawFormat);
                //byte[] arrImage = ms.GetBuffer();

                //var list = (from print in results.OfType<ManagementObject>()
                //            select new
                //            {
                //                title = print["Name"],
                //                vaziat = print["ExtendedPrinterStatus"] != null
                //                ? ((Printer_Structure.Extended_Printer_Status)
                //                    Convert.ToInt32(print["ExtendedPrinterStatus"].ToString())
                //                    ).ToString()
                //                : string.Empty,
                //                is_default = _Printer_Setting.PrinterName.Equals(print["Name"])
                //                ? arrImage
                //                : null,
                //            }).ToList();
                //ms_grid.DataSource = list;
                //ms_grid.FilterMode = FilterMode.None;
                //ms_grid.Refresh();
                //var r = ms_grid.GetRows()
                //    .FirstOrDefault(x => x.Cells["title"].Text == _Printer_Setting.PrinterName);
                //if (r != null)
                //{
                //    ms_grid.MoveTo(r);
                //    ms_grid.EnsureVisible(r.Position);
                //}
            }
            catch (Exception)
            { 
                new Form_Notify("خطا", "سیستم قادر به لود چاپـگرها نیست.",
		                Form_Notify.FarsiMessageBoxIcon.اضافه)
	                .Popup(Form_Notify.Direction_Show.Right_To_Left, 1000);
            }
        }
        private void Load_Form_Dar_Printer          ()
        {
            GridEXRow Row = ms_grid.CurrentRow ?? ms_grid.GetRows().FirstOrDefault();

            Set_Printer_Default();
            _Printer_Setting = new PrinterSettings();
            _Printer_Setting.PrinterName = Row.Cells["title"].Text;
            _Printer_Setting.PrintToFile = ms_print_file.Checked;
            _Printer_Setting.Copies = Convert.ToInt16(ms_copy.MS_Decimal);
            if (ms_page_as_ta.Checked)
            {
                _Printer_Setting.FromPage = Convert.ToInt32(ms_az.MS_Decimal);
                _Printer_Setting.ToPage = Convert.ToInt32(ms_ta.MS_Decimal);
            }
        }
        private void Set_Printer_Default            ()
        {
            try
            {
                foreach (ManagementObject print in results)
                {
                    GridEXRow Row = ms_grid.CurrentRow ?? ms_grid.GetRows().FirstOrDefault();

                    if (print["Name"].Equals(Row.Cells["title"].Text))
                    {
                        print.InvokeMethod("SetDefaultPrinter", args);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void OpenPrinterPropertiesDialog    (PrinterSettings printerSettings)
        {
            IntPtr hDevMode = printerSettings.GetHdevmode(printerSettings.DefaultPageSettings);
            IntPtr pDevMode = GlobalLock(hDevMode);
            int sizeNeeded = DocumentProperties(this.Handle, IntPtr.Zero, printerSettings.PrinterName, pDevMode, ref pDevMode, 0);
            IntPtr devModeData = Marshal.AllocHGlobal(sizeNeeded);
            DocumentProperties(this.Handle, IntPtr.Zero, printerSettings.PrinterName, devModeData, ref pDevMode, 14);
            GlobalUnlock(hDevMode);
            printerSettings.SetHdevmode(devModeData);
            printerSettings.DefaultPageSettings.SetHdevmode(devModeData);
            GlobalFree(hDevMode);
            Marshal.FreeHGlobal(devModeData);
        }
        private void Progress_Increase              ()
        {
            if (progressBar1.InvokeRequired)
            {
                var d = new Progress_Change(Progress_Increase);
                progressBar1.Invoke(d);
            }
            else
            {
                if (progressBar1.Value < progressBar1.Maximum)
                {
                    progressBar1.Value++;
                    progressBar1.Refresh();
                    Application.DoEvents();
                }
                else
                    Enable_Preview();
            }
        }
        private void Enable_Preview                 ()
        {
            if (ms_preview.InvokeRequired)
            {
                var d = new Progress_Change(Enable_Preview);
                ms_preview.Invoke(d);
            }
            else
            {
                ms_preview.Enabled = ms_design.Enabled = ms_print.Enabled = true;
                msLblWhite.Visible = false;
                this.Height = TempHeight;
                var max = _List_Report.Select(x => x._Report.Pages.Count).Sum();
                ms_all_page.Text += "  (" + max + " صفحــه " + ")  ";
            }
        }
        #endregion

        public Print_Dialog         (string Report_Stream, string Business_Object_Name, object Data_Source)
        {
            InitializeComponent();
            pathReport = Report_Stream;
            stiReport1 = new Stimulsoft.Report.StiReport();
            stiReport1.Load(Report_Stream);
            stiReport1.RegBusinessObject(Business_Object_Name, Data_Source);
            stiReport1.Compile();

        }
        public Print_Dialog         (string Report_Stream, string Business_Object_Name, object Data_Source, string Name, Image Tasvir)
        {
            InitializeComponent();
            pathReport = Report_Stream;
            stiReport1 = new Stimulsoft.Report.StiReport();
            stiReport1.Load(Report_Stream);
            stiReport1.RegBusinessObject(Business_Object_Name, Data_Source);
            StiImage image = stiReport1.GetComponents()[Name] as StiImage;
            image.Image = Tasvir;
            stiReport1.Compile();
        }
        public Print_Dialog         (string Report_Stream, string[] Business_Object_Names, object[] Data_Sources)
        {
            InitializeComponent();
            pathReport = Report_Stream;
            stiReport1 = new Stimulsoft.Report.StiReport();
            stiReport1.Load(Report_Stream);

            if (Business_Object_Names != null && Data_Sources != null)
                for (int i = 0; i < Business_Object_Names.Length && i < Data_Sources.Length; i++)
                    stiReport1.RegBusinessObject(Business_Object_Names[i], Data_Sources[i]);

            stiReport1.Compile();
        }
        public Print_Dialog         (string Report_Stream)
        {
            InitializeComponent();
            pathReport = Report_Stream;
            stiReport1 = new Stimulsoft.Report.StiReport();
            stiReport1.Load(Report_Stream);
            stiReport1.Compile();

        }
        public Print_Dialog         (byte[] Report_Stream, string Business_Object_Name, object Data_Source)
        {
            InitializeComponent();
            pathReport = Business_Object_Name;
            stiReport1 = new Stimulsoft.Report.StiReport();
            stiReport1.Load(Report_Stream);
            stiReport1.RegBusinessObject(Business_Object_Name, Data_Source);
            stiReport1.Compile();
            ms_design.Enabled = false;
        }
        public Print_Dialog         (byte[] Report_Stream)
        {
            InitializeComponent();
            stiReport1 = new Stimulsoft.Report.StiReport();
            stiReport1.Load(Report_Stream);
            stiReport1.Compile();
            ms_design.Enabled = false;
        }
        public Print_Dialog         (List<MS_Report_Loading> List_Report)
        {
            InitializeComponent();
            Print_Dialog.CheckForIllegalCrossThreadCalls = false;
            stiReport1 = new Stimulsoft.Report.StiReport();
            //====================
            stiReport1.RenderedPages.Clear();
            stiReport1.NeedsCompiling = false;
            stiReport1.IsRendered = true;

            //====================
            _List_Report = List_Report;
            _Print_List = true;
            pathReport = List_Report.FirstOrDefault()?.Report_Address;
            progressBar1.Maximum = _List_Report.Count;
            progressBar1.Minimum = 1;
            progressBar1.Value = 1;
            ms_preview.Enabled = ms_design.Enabled = ms_print.Enabled = false;
            msLblWhite.Visible = true;
            TempHeight = this.Height;
            this.Height = 448;


            this.Shown += (z, y) =>
            {
                Application.DoEvents();
                List_Report.MSZ_ForEach((x) =>
                {
                    new Thread(new ThreadStart(() =>
                    {
                        x.Load();
                        Progress_Increase();
                        Application.DoEvents();
                    })).Start();
                });
                //this.Height = h;
            };
            Application.DoEvents();
        }


        public void Set_Variable    (string Name, object Value)
        {
            stiReport1[Name] = Value;
        }
        public void Set_DataSource  (string Business_Object_Name, object Data_Source)
        {
            stiReport1.RegBusinessObject(Business_Object_Name, Data_Source);
        }
        public void Show_Form       ()
        {
            stiReport1.Show();
        }

        private void ms_refresh_Click   (object sender, EventArgs e)
        {
            search = null;
            Load_List_Printers();
        }
        private void ms_preview_Click   (object sender, EventArgs e)
        {
            //if (_Print_List && !_Is_Rendered)
            //{
            //    stiReport1.Show(this);
            //    _List_Report.MSZ_ForEach((x) =>
            //    {
            //        new Thread(new ThreadStart(() =>
            //        {
            //            x.Render();
            //            lock (stiReport1)
            //            {
            //                stiReport1.RenderedPages.AddRange(x._Report.CompiledReport.RenderedPages);
            //                stiReport1.InvokeRefreshViewer();
            //            }
            //        })).Start();
            //    });
            //    _Is_Rendered = true;
            //}
            //else stiReport1.Show(this);

            if (_Print_List && !_Is_Rendered)
            {
                stiReport1.RenderedPages.Clear();
                stiReport1.Pages.Clear();
                stiReport1.Show(this);
                _List_Report.MSZ_ForEach((x) =>
                {
                    new Thread(new ThreadStart(() =>
                    {
                        x.Render();
                        lock (stiReport1)
                        {
                            foreach (StiPage page in x._Report.RenderedPages.Items)
                            {
                                page.Report = stiReport1;
                                stiReport1.RenderedPages.Add(page);
                                stiReport1.InvokeRefreshViewer();
                            }
                        }
                    })).Start();
                });
                _Is_Rendered = true;
            }
            else stiReport1.Show(this);
        }
        private void ms_print_Click     (object sender, EventArgs e)
        {
            //if (_Print_List && !_Is_Rendered)
            //{
            //    _List_Report.MSZ_ForEach((x) =>
            //    {
            //        new Thread(new ThreadStart(() =>
            //        {
            //            x.Render();
            //            lock (stiReport1)
            //            {
            //                stiReport1.RenderedPages.AddRange(x._Report.CompiledReport.RenderedPages);
            //                //stiReport1.InvokeRefreshViewer();
            //            }
            //        })).Start();
            //    });
            //}
            //_Is_Rendered = true;
            //_Do_Direct_Print = ms_direct_print.Checked;
            //Load_Form_Dar_Printer();
            //stiReport1.Print(false, _Printer_Setting);
            //if (_Do_Direct_Print.HasValue && _Do_Direct_Print.Value)
            //    //if (!_Do_Direct_Print.HasValue || (_Do_Direct_Print.HasValue && !_Do_Direct_Print.Value))
            //    this.Close();

            if (_Print_List && !_Is_Rendered)
            {
                stiReport1.RenderedPages.Clear();
                stiReport1.Pages.Clear();
                _List_Report.MSZ_ForEach((x) =>
                {
                    x.Render();
                    lock (stiReport1)
                    {
                        foreach (StiPage page in x._Report.RenderedPages.Items)
                        {
                            page.Report = stiReport1;
                            stiReport1.RenderedPages.Add(page);
                        }
                    }
                });
                _Is_Rendered = true;
            }
            _Do_Direct_Print = ms_direct_print.Checked;
            Load_Form_Dar_Printer();
            stiReport1.Print(false, _Printer_Setting);
            if (!_Do_Direct_Print.HasValue || (_Do_Direct_Print.HasValue && !_Do_Direct_Print.Value))
                this.Close();
        }
        private void Print_Dialog_Shown (object sender, EventArgs e)
        {
            if (!_Do_Direct_Print.HasValue) return;
            if (_Do_Direct_Print.Value)
                ms_print.PerformClick();
        }
        private void Print_Dialog_KeyUp (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                e.Handled = true;
                ms_print.PerformClick();
            }
            if (e.KeyCode == Keys.F6)
            {
                e.Handled = true;
                ms_preview.PerformClick();
            }
            if (e.KeyCode == Keys.F8)
            {
                e.Handled = true;
                ms_design.PerformClick();
            }
        }
        private void Print_Dialog_Load  (object sender, EventArgs e)
        {
            Load_Printer_Setting();
            if (!_Print_List)
                ms_all_page.Text += @"  (" + stiReport1.Pages.Count + @" صفحــه " + @")";
        }
        private void ms_setting_Click   (object sender, EventArgs e)
        {
            try
            {
                GridEXRow Row = ms_grid.CurrentRow ?? ms_grid.GetRows().FirstOrDefault();

                PrinterSettings ps = new PrinterSettings();
                ps.PrinterName =
                    PrinterSettings.
                    InstalledPrinters.Cast<String>().
                    SingleOrDefault(x => x == Row.Cells["title"].Text);

                if (!string.IsNullOrEmpty(ps.PrinterName))
                    OpenPrinterPropertiesDialog(ps);
            }
            catch (Exception ex)
            {
                MSMessage.Show("امکان مشاهده مشخصات چاپگر وجود ندارد\n\n" + ex.Message);
            }
        }
        private void ms_design_Click    (object sender, EventArgs e)
        {
            if (pathReport == "") return;
            stiReport1.Load(pathReport);
            stiReport1.Design();
            this.Close();
        }

        private void ms_grid_ColumnButtonClick      (object sender, ColumnActionEventArgs e)
        {
            if (e.Column.Key == "P")
            {
                ms_print.PerformClick();
            }
            else if (e.Column.Key == "T")
            {
                ms_setting_Click(null, null);
            }
        }
        private void ms_grid_RowDoubleClick         (object sender, RowActionEventArgs e)
        {
            ms_print.PerformClick();
        }
    }
}
