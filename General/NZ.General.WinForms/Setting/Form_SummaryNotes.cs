using MS_Control.MainForms;
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
using NZ.General.Business;
using ShareLib.Models;

namespace NZ.General.WinForms.Setting
{
    public partial class Form_SummaryNotes :  Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private ReportManager             _Manager;
        private List<SummaryNote>   _List;
        #endregion
        public Form_SummaryNotes()
        {
            InitializeComponent();
            _Manager                    = new ReportManager();
        }

        private void GenerateYears      ()
        {
            var listYears = 
                _Manager
                    .GetReport<YearNoteList>
                    (new
                        {
                            Year =1399
                        },
                        null
                    )?.ToList();


            listYears
                ?.ForEach(list =>
                    {
                        var menuItem = new ToolStripMenuItem
                        (
                            " سـال " + list.PersianYearInt,
                            null,
                            MenuItem_Click
                        )
                        {
                            Tag             = list.PersianYearInt,
                            CheckOnClick    = true,
                        };
                        
                        NzYearList.DropDownItems.Add(menuItem);
                    });

            if (NzYearList.DropDownItems.OfType<ToolStripMenuItem>().Any())
            {
                var first = NzYearList.DropDownItems.OfType<ToolStripMenuItem>().First();
                first.PerformClick();
            }

        }
        private void RefreshGrid        (short Year)
        {
            try
            {
                _List = _Manager
                    .GetReport<SummaryNote>
                    (new
                        {
                            Year
                        },null
                    )?.ToList();

                NzGrid.DataSource  = _List.ToList();
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void MenuItem_Click     (object sender, EventArgs e)
        {
            foreach (var item in NzYearList.DropDownItems.OfType<ToolStripMenuItem>())
                item.Checked = false;

            if (sender is ToolStripMenuItem menuItem)
            {
                menuItem.Checked = true;
                RefreshGrid(Convert.ToInt16(menuItem.Tag));
                //NzGrid.CollapseGroups();
            }
        }

        private void Form_SummaryNotes_Shown(object sender, EventArgs e)
        {
            GenerateYears();
        }
    }
}
