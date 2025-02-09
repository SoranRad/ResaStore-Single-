using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MS_Control;
using MS_Control.MainForms;
using Nz.Anbar.Model.Report;
using Nz.Anbar.WinForms.App;
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using ShareLib;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Report
{
    public partial class FormAnalyze : Form
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        private byte    _Level      = 1;
        private int     _Code       = 0;
        private int[]   _ArrLevels  = new int[6];
        #region Constructor
        public FormAnalyze()
        {
            InitializeComponent();
        }
        #endregion
        #region Methods

        private void RefreshGrid<T> ()
        {
            try
            {
                var Mgr = new ReportManager();
                var List = Mgr.GetReport<T>(new
                {
                    Code        = _Code,
                    Year        = SystemConstant.ActiveYear.Salmali,
                    DateFrom    = (DateTime?)null,
                    DateTo      = (DateTime?)null,

                }, null);

                NzGrid.DataSource = List?.ToList();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در خواندن اطلاعات", "خطا", ex.Message, MessageBoxButtons.OK);
            }
        }
        private void SetLevel       ()
        {
            NzLevel1.Visible = _Level >= 1;
            NzLevel2.Visible = _Level >= 2;
            NzLevel3.Visible = _Level >= 3;
            NzLevel4.Visible = _Level >= 4;
            //NzLevel5.Visible = _Level >= 5;
        }
        private void SetLayout      ()
        {
            if(_Level==0)
                NzGrid.LoadLayout(NzGrid.Layouts["Storage"]);
            else if(_Level >= 1 && _Level <=3)
                NzGrid.LoadLayout(NzGrid.Layouts["Analyze"]);
            else
                NzGrid.LoadLayout(NzGrid.Layouts["Circular"]);

        }
        private void Init           ()
        {
            _Level = 0;
            LoadData();
        }
        private void LoadData       ()
        {
            SetLayout();
            SetLevel();
            SaveLevelCode();
            switch (_Level)
            {
                case 0:
                    RefreshGrid<Storage>();
                    break;
                case 1:
                    RefreshGrid<AnalyzeLevel1>();
                    break;
                case 2:
                    RefreshGrid<AnalyzeLevel2>();
                    break;
                case 3:
                    RefreshGrid<AnalyzeLevel3>();
                    break;
                case 4:
                    RefreshGrid<CircularObject>();
                    break;
                //case 5:
                //    RefreshGrid<AnalyzeLevel5>();
                //    break;
            }
        }
        private void LevelUp        ()
        {
            switch (_Level)
            {
                case 0:
                    var row0        = (NzGrid.CurrentRow.DataRow as Storage);
                    _Code           = row0?.Code ?? 0;
                    NzCode1.Text    = _Code.ToString();
                    NzTitle1.Text   = row0?.Title;
                    _Level++;
                    LoadData();
                    break;
                case 1:
                    var row1        = (NzGrid.CurrentRow.DataRow as AnalyzeLevel1);
                    _Code           = row1?.Code ?? 0;
                    NzCode2.Text    = _Code.ToString();
                    NzTitle2.Text   = row1?.Title;
                    _Level++;
                    LoadData();
                    break;
                case 2:
                    var row2        = (NzGrid.CurrentRow.DataRow as AnalyzeLevel2);
                    _Code           = row2?.Code ?? 0;
                    NzCode3.Text    = _Code.ToString();
                    NzTitle3.Text   = row2?.Title;
                    _Level++;
                    LoadData();
                    break;
                case 3:
                    var row3        = (NzGrid.CurrentRow.DataRow as AnalyzeLevel3);
                    _Code           = row3?.Code ?? 0;
                    NzCode4.Text    = _Code.ToString();
                    NzTitle4.Text   = row3?.Title;
                    _Level++;
                    LoadData();
                    break;
                case 4:
                    if (NzGrid.CurrentRow.DataRow is CircularObject row)
                    {
                        var kind = (Enums.NzFactorKind)row.kind;

                        if (kind == Enums.NzFactorKind.HavaleZayeat || kind == Enums.NzFactorKind.HavaleMasrafi)
                            new Form_Transfer(row.IDTitle, kind).ShowDialog();
                        else if (kind == Enums.NzFactorKind.AvalDore)
                        {
                            var frm = new Form_InitialStock(row.ID);
                            frm.MdiParent = this.MdiParent;
                            frm.Show();
                        }
                        else
                            new Form_Purchase(row.IDTitle, kind).ShowDialog();
                    }
                    break;
            }
        }
        private void SaveLevelCode  ()
        {
            _ArrLevels[_Level] = _Code;
        }
        #endregion

        private void FormAnalyze_Shown          (object sender, EventArgs e)
        {
            Init();
            //NzGrid.Controls.Add(ms_Open_Pic);
            //ms_Open_Pic.Left = NzGrid.Width - ms_Open_Pic.Width - 10;
            //ms_Open_Pic.Top = ms_Open_Pic.Height + 10;
            //ms_Open_Pic.BringToFront();
        }

        private void NzGrid_ColumnButtonClick   (object sender, ColumnActionEventArgs e)
        {
            if (e.Column.Key == "E")
                LevelUp();
        }
        private void NzGrid_RowDoubleClick      (object sender, RowActionEventArgs e)
        {
            if(NzGrid.CurrentRow?.RowType==RowType.Record)
                LevelUp();
        }
        private void NzGrid_MouseClick          (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (_Level > 0)
                {
                    _Level--;
                    _Code = _ArrLevels[_Level];
                    LoadData();
                }
            }
        }
        private void NzGrid_KeyPress            (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                if (NzGrid.CurrentRow?.RowType == RowType.Record)
                    LevelUp();
        }

        private void NzLable1_Click             (object sender, EventArgs e)
        {
            _Level  = 1;
            _Code   = _ArrLevels[_Level];
            LoadData();
        }
        private void NzTitle2_Click             (object sender, EventArgs e)
        {
            _Level = 2;
            _Code = _ArrLevels[_Level];
            LoadData();
        }
        private void NzTitle3_Click             (object sender, EventArgs e)
        {
            _Level = 3;
            _Code = _ArrLevels[_Level];
            LoadData();
        }
        private void toolStripLabel9_Click      (object sender, EventArgs e)
        {
            _Level = 4;
            _Code = _ArrLevels[_Level];
            LoadData();
        }

        private void FormAnalyze_PreviewKeyDown (object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                NzGrid_MouseClick(sender,new MouseEventArgs(MouseButtons.Right,1,0,0,0));
        }

        private void FormAnalyze_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)27)
                NzGrid_MouseClick(sender,new MouseEventArgs(MouseButtons.Right,1,0,0,0));
        }

        private void NzRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
