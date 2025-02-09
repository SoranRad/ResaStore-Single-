using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MdiTabStrip;
using MS_Control;
using MS_Control.MainForms;
using MS_Control.Tarikh;
using ShareLib;
using ShareLib.Interfaces;
using ShareLib.Utils;

namespace NZ.Resaa.Store
{
    public partial class Form_Resaa_Store : Form_Mother_IRANSans
    {
        //=========Get List Module And Load
        #region Logging

        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private string _BkImage = "Bk.jpg";
        int MenuIndex           = 1;
        #endregion
        #region Constructor
        public Form_Resaa_Store         ()
        {
            InitializeComponent();
            
            ms_MdiTab.Tabs.OfType<MdiTab>().ToList().MSZ_ForEach(tab =>
            {
                tab.Dispose();
            });
        }
        #endregion
        #region Methods
        private void    LoadBKImage                 ()
        {
            try
            {
                var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                if (File.Exists(path + @"\" + _BkImage))
                    Pic_Back_Main.ImageLocation = path + @"\" + _BkImage;
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private bool    LoadModule                  ()
        {
            var loadingGeneral = LoadGeneral();
            loadingGeneral = LoadBar();
            loadingGeneral = LoadStorage();
            loadingGeneral = LoadXazane();
            loadingGeneral = Loadmachine();
            return true;
        }
        private bool    LoadGeneral                 ()
        {
            var tmp = Form_Factory._Form_Factory_General;
            
            tmp.SetMainForm(this);
            
            ms_baseinfo
                .DropDownItems
                .AddRange(tmp.GetMenu(Enums.MenuKind.BaseInfo)
                    .OfType<ToolStripItem>()
                    .ToArray());

            ms_settings
                .DropDownItems
                .AddRange(tmp.GetMenu(Enums.MenuKind.Settings)
                    .OfType<ToolStripItem>()
                    .ToArray());

            NzReports
                .DropDownItems
                .AddRange(tmp.GetMenu(Enums.MenuKind.Reports)
                    .OfType<ToolStripItem>()
                    .ToArray());

            NzSidebar
                .Items
                .AddRange(
                            tmp
                            .GetMenu(Enums.MenuKind.Sidebar)
                            .OfType<ToolStripItem>()
                            .ToArray()
                         );

            return true;
        }
        private bool    LoadXazane                  ()
        {
            var dir = Path.GetDirectoryName(Application.ExecutablePath);

            if (!File.Exists(Path.Combine(dir, "NZ.Xazane.WinForms.dll")))
                return true;

            Assembly asm = Assembly.LoadFrom("NZ.Xazane.WinForms.dll");
            var i = asm
                .GetTypes()
                .FirstOrDefault(x => x.GetInterfaces().Contains(typeof(IEntryProvider)));

            var costruc = i.GetConstructors();
            var item = costruc.FirstOrDefault();
            object c = item.Invoke(null);

            Form_Factory._Form_Factory_Xazaneh = c as IEntryProvider;
            var tmp = (c as IEntryProvider);

            Form_Factory.SystemList.Add(tmp);

            tmp?.SetMainForm(this);

            //mS_Menu1.Items.Insert(1, tmp.MainMenuSysytem);

            ms_baseinfo
                .DropDownItems
                .AddRange(tmp.GetMenu(Enums.MenuKind.BaseInfo)
                    .OfType<ToolStripItem>()
                    .ToArray());

            var optMenu = new ToolStripMenuItem(tmp.GetName)
            {
                Font = new Font("IRANSans(Small) Medium", 14.5f),
                Image = global::MS_Resource.GlobalResources.Negin__64_,
            };

            optMenu
                .DropDownItems
                .AddRange(tmp.GetMenu(Enums.MenuKind.Operation)
                    .OfType<ToolStripItem>()
                    .ToArray());

            mS_Menu1.Items.Insert(mS_Menu1.Items.Count - 3, optMenu);

            NzSidebar
                .Items
                .AddRange(
                    tmp
                        .GetMenu(Enums.MenuKind.Sidebar)
                        .OfType<ToolStripItem>()
                        .ToArray()
                );
            return true;
        }
        private bool    LoadBar                     ()
        {
            try
            {

                var dir = Path.GetDirectoryName(Application.ExecutablePath);

                if (!File.Exists(Path.Combine(dir, "Nz.Bar.WinForms.dll")))
                    return true;

                Assembly asm = Assembly.LoadFrom("Nz.Bar.WinForms.dll");
                var i = asm
                    .GetTypes()
                    .FirstOrDefault(x => x.GetInterfaces().Contains(typeof(IEntryProvider)));

                var costruc = i.GetConstructors();
                if (!costruc.Any())
                    return false;

                var item = costruc.FirstOrDefault();

                if (item == null)
                    return false;

                object c = item.Invoke(null);

                Form_Factory._Form_Factory_Bar = c as IEntryProvider;
                var tmp = (c as IEntryProvider);
                Form_Factory.SystemList.Add(tmp);

                if (tmp == null)
                    return false;

                tmp.SetMainForm(this);


                ms_baseinfo
                    .DropDownItems
                    .AddRange(tmp.GetMenu(Enums.MenuKind.BaseInfo)
                        .OfType<ToolStripItem>()
                        .ToArray());
                var optMenu = new ToolStripMenuItem(tmp.GetName)
                {
                    Font = new Font("IRANSans(Small) Medium", 14.5f),
                    Image = global::MS_Resource.GlobalResources.StoreHouse,
                };

                optMenu
                    .DropDownItems
                    .AddRange(tmp.GetMenu(Enums.MenuKind.Operation)
                        .OfType<ToolStripItem>()
                        .ToArray());

                mS_Menu1.Items.Insert(mS_Menu1.Items.Count - 3, optMenu);
                NzSidebar
                    .Items
                    .AddRange(
                        tmp
                            .GetMenu(Enums.MenuKind.Sidebar)
                            .OfType<ToolStripItem>()
                            .ToArray()
                    );

            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
            return true;
        }
        private bool    LoadStorage                 ()
        {
            try
            {

                var dir=Path.GetDirectoryName(Application.ExecutablePath);

                if (!File.Exists(Path.Combine(dir, "Nz.Anbar.WinForms.dll")))
                    return true;

                Assembly asm = Assembly.LoadFrom("Nz.Anbar.WinForms.dll");
                var i = asm
                    .GetTypes()
                    .FirstOrDefault(x => x.GetInterfaces().Contains(typeof(IEntryProvider)));

                var costruc = i.GetConstructors();
                if (!costruc.Any())
                    return false;

                var item = costruc.FirstOrDefault();

                if (item == null)
                    return false;

                object c = item.Invoke(null);

                Form_Factory._Form_Factory_Anbar = c as IEntryProvider;
                var tmp = (c as IEntryProvider);
                Form_Factory.SystemList.Add(tmp);

                if (tmp == null)
                    return false;

                tmp.SetMainForm(this);


                    ms_baseinfo
                        .DropDownItems
                        .AddRange(tmp.GetMenu(Enums.MenuKind.BaseInfo)
                            .OfType<ToolStripItem>()
                            .ToArray());
                var optMenu = new ToolStripMenuItem(tmp.GetName)
                {
                    Font = new Font("IRANSans(Small) Medium", 14.5f),
                    Image =  global::MS_Resource.GlobalResources.StoreHouse,
                };

                optMenu
                    .DropDownItems
                    .AddRange(tmp.GetMenu(Enums.MenuKind.Operation)
                        .OfType<ToolStripItem>()
                        .ToArray());

                mS_Menu1.Items.Insert(mS_Menu1.Items.Count - 3, optMenu);
                NzSidebar
                    .Items
                    .AddRange(
                        tmp
                            .GetMenu(Enums.MenuKind.Sidebar)
                            .OfType<ToolStripItem>()
                            .ToArray()
                    );

            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
            return true;
        }
        private bool    Loadmachine                 ()
        {
            try
            {

                var dir = Path.GetDirectoryName(Application.ExecutablePath);

                if (!File.Exists(Path.Combine(dir, "Nz.Machine.WinForms.dll")))
                    return true;

                Assembly asm = Assembly.LoadFrom("Nz.Machine.WinForms.dll");
                var i = asm
                    .GetTypes()
                    .FirstOrDefault(x => x.GetInterfaces().Contains(typeof(IEntryProvider)));

                var costruc = i.GetConstructors();
                if (!costruc.Any())
                    return false;

                var item = costruc.FirstOrDefault();

                if (item == null)
                    return false;

                object c = item.Invoke(null);

                Form_Factory._Form_Factory_Machine = c as IEntryProvider;
                var tmp = (c as IEntryProvider);
                Form_Factory.SystemList.Add(tmp);

                if (tmp == null)
                    return false;

                tmp.SetMainForm(this);


                ms_baseinfo
                    .DropDownItems
                    .AddRange(tmp.GetMenu(Enums.MenuKind.BaseInfo)
                        .OfType<ToolStripItem>()
                        .ToArray());
                var optMenu = new ToolStripMenuItem(tmp.GetName)
                {
                    Font = new Font("IRANSans(Small) Medium", 14.5f),
                    Image = global::MS_Resource.GlobalResources.StoreHouse,
                };

                optMenu
                    .DropDownItems
                    .AddRange(tmp.GetMenu(Enums.MenuKind.Operation)
                        .OfType<ToolStripItem>()
                        .ToArray());

                mS_Menu1.Items.Insert(mS_Menu1.Items.Count - 3, optMenu);
                NzSidebar
                    .Items
                    .AddRange(
                        tmp
                            .GetMenu(Enums.MenuKind.Sidebar)
                            .OfType<ToolStripItem>()
                            .ToArray()
                    );

            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
            return true;
        }
        private void    LoadReportMenus             ()
        {
            try
            {
                Form_Factory
                    .SystemList
                    .Where(x => x.GetSystemKind() != Enums.MS_System.General)
                    .MSZ_ForEach(x =>
                    {
                        var optMenu = new ToolStripMenuItem(@"گزارشـات "+x.GetName)
                        {
                            Font = new Font("IRANSans(Small) Medium", 14f),
                        };

                        var submenu = x.GetMenu(Enums.MenuKind.Reports);
                        if (submenu != null)
                            optMenu
                            .DropDownItems
                            .AddRange(submenu
                                        .OfType<ToolStripItem>()
                                            .ToArray());

                        NzReports.DropDownItems.Add(optMenu);

                    });
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void    LoadFooterStrip             ()
        {
            NzDate.Text         = new MS_Structure_Shamsi(DateTime.Now).ToShamsi();
            NzChangeUser.Text   = SystemConstant.ActiveUser.title +@"("+ SystemConstant.ActiveUser.user_name+ @")";
            NzChangeYear.Text   = SystemConstant.ActiveYear.Salmali.ToString();
            NzCompanyTitle.Text = SystemConstant.ActiveCompany.title;
        }

        private void    ApplyAccessRole             ()
        {
            var accessCode = SystemConstant.ActiveUser?.OriginalAccess;
            if (string.IsNullOrEmpty(accessCode))
                return;
            accessCode = Conversion.HexToBin(accessCode);
            accessCode = string.Join("", accessCode.Reverse());

            foreach (ToolStripItem item in mS_Menu1.Items)
                if (item is ToolStripMenuItem menu)
                    ApplyAccessRole(ref accessCode, menu);
        }
        private void    ApplyAccessRole             (ref string AccessBitString, ToolStripMenuItem MenuItem)
        {
            var ListMenu = MenuItem.DropDownItems;
            foreach (var item in ListMenu)
                if (item is ToolStripMenuItem menu)
                {
                    var index = Convert.ToInt32(menu.Tag.ToString());
                    if (index < AccessBitString.Length)
                        menu.Enabled = AccessBitString[index] == '1';
                    //else  حالت پیش فرض برای منو
                    //    menu.Enabled = false;
                    ApplyAccessRole(ref AccessBitString, menu);
                }
        }

        private void    GenerateMenuIndex           ()
        {
            foreach (ToolStripItem item in mS_Menu1.Items)
                if (item is ToolStripMenuItem menu)
                {
                    menu.Tag = MenuIndex++;
                    GenerateMenuIndex(menu);
                }

        }
        private void    GenerateMenuIndex           (ToolStripMenuItem MenuItem)
        {
            var ListMenu = MenuItem.DropDownItems;

            foreach(var item in ListMenu)
                if (item is ToolStripMenuItem menu)
                {
                    menu.Tag = MenuIndex++;
                    GenerateMenuIndex(menu);
                }
        }

        private void    GetVersion                  ()
        {
             
            NzVersion.Text = @"نسخه : " + SystemConstant.Version;
        }

        private void    RunUpdate                   ()
        {
            try
            {
                var app = Path.GetDirectoryName(Application.ExecutablePath);
                app = Path.Combine(app, "Updater.exe");

                if (File.Exists(app))
                {
                    Process p = new Process();
                    p.StartInfo.FileName = app;
                    p.Start();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        #endregion

        private void    ms_MdiTab_MdiTabAdded               (object sender, MdiTabStripTabEventArgs e)
        {
            ms_MdiTab.Visible = ms_MdiTab.Tabs.Count > 0;
            if (ms_MdiTab.Visible)
            {
                mS_Menu1.SendToBack();
                //Application.DoEvents();
                //e.MdiTab.Refresh();
            }
        }
        private void    ms_MdiTab_MdiTabRemoved             (object sender, MdiTabStripTabEventArgs e)
        {
            ms_MdiTab.Visible = ms_MdiTab.Tabs.Count > 0;
        }
        private void    ms_MdiTab_CurrentMdiTabChanged      (object sender, EventArgs e)
        {
            //ms_MdiTab.ActiveTab?.Refresh();
        }
        private void    ms_MdiTab_VisibleChanged            (object sender, EventArgs e)
        {
            Pic_Back_Main.Visible = !ms_MdiTab.Visible;
        }


        private void    Form_Resaa_Store_Load               (object sender, EventArgs e)
        {
            LoadBKImage         ();
            LoadModule          ();
            LoadReportMenus     ();
            LoadFooterStrip     ();
            GenerateMenuIndex   ();
            ApplyAccessRole     ();
        }
        private void    Form_Resaa_Store_FormClosing        (object sender, FormClosingEventArgs e)
        {
            if (Form_Factory.ExitForm?.ShowDialog(this) != DialogResult.OK)
                e.Cancel = true;

            if (!e.Cancel && SystemConstant.OurAccount)
            {
                try
                {
                    var start = new ProcessStartInfo();
                    start.Arguments = "/Sync.NO 40980";
                    //start.FileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Sync\\ClientSync.exe";
                    start.FileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Sync\\Sync.exe";
                    //start.
                    //start.FileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\ClientSync.exe";
                    using (var proc = Process.Start(start))
                    {
                        //proc.Start();
                    }
                }
                catch(Exception ex)
                {
                    log.Error(ex);
                }
            }
        }
        private void    Form_Resaa_Store_Shown              (object sender, EventArgs e)
        {
            bool _AnyAlarm = false;
            foreach (var system  in Form_Factory.SystemList)
            {
                system.RefreshAlaram();
                if (system.AnyAlaram())
                    _AnyAlarm = true;
            }

            if (_AnyAlarm)
                new Form_Alarm().ShowDialog(this);

            GetVersion();
            RunUpdate();
        }
        private void    NzChangeUser_Click                  (object sender, EventArgs e)
        {
            InvokeCommand.Invoke(Form_Factory.CmdChangeUser);
            ApplyAccessRole ();
            LoadFooterStrip ();
        }
        private void    NzChangePass_Click                  (object sender, EventArgs e)
        {
            InvokeCommand.Invoke(Form_Factory.CmdChangePass);
            LoadFooterStrip();
        }
        private void    NzChangeYear_Click                  (object sender, EventArgs e)
        {
            InvokeCommand.Invoke(Form_Factory.CmdChangeUsYear);
            LoadFooterStrip();
        }

        private void    NzAbout_Click                       (object sender, EventArgs e)
        {
            new FormAbout().ShowDialog(this);
             
        }


    }
}
