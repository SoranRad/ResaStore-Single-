using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control;
using MS_Control.Tarikh;
using NZ.General.Business;
using ShareLib;
using ShareLib.Utils;
using ShareLib.ViewModel;

namespace NZ.General.WinForms.Report
{
    public partial class FormDialyCircular : Form
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        private Manager _Manager;


        public FormDialyCircular()
        {
            InitializeComponent();
            var mah                     = new MS_Structure_Shamsi(DateTime.Now)._Mah;
            ms_mah.SelectedIndex        = 13 - mah;
            this.Icon                   = global::MS_Resource.GlobalResources.Logo_Resaa;
            _Manager                    = new Manager();
            ms_mah.SelectedTabChanged   += ms_mah_SelectedTabChanged;
            RefreshGrid();
        }
        private void RefreshGrid()
        {
            try
            {
                mS_GridX1.DataSource = null;
                var Month = (short) (13 - ms_mah.SelectedIndex);


                var list = new List<DailyCircular>();

                foreach (var system in Form_Factory.SystemList)
                {
                    var rr = system.GetDailyCircular(SystemConstant.ActiveYear.Salmali, Month).Result;
                    if(rr != null)
                        list.AddRange(rr);
                }
                //================= تجمیع روزها

                var ff = list
                    .GroupBy(x => new { x.GregorianDate, x.PersianStr })
                    .Select(x => new DailyCircular
                    {
                        GregorianDate   = x.Key.GregorianDate,
                        PersianStr      = x.Key.PersianStr,

                        Xarid           = x.Select(y => y.Xarid).Sum() ?? 0,
                        Frosh           = x.Select(y => y.Frosh).Sum() ?? 0,
                        BargashtFrosh   = x.Select(y => y.BargashtFrosh).Sum() ?? 0,
                        BargashtXarid   = x.Select(y => y.BargashtXarid).Sum() ?? 0,
                        Zayat           = x.Select(y => y.Zayat).Sum() ?? 0,
                        Masraf          = x.Select(y => y.Masraf).Sum() ?? 0,

                        DaryaftCache    = x.Select(y => y.DaryaftCache).Sum() ?? 0,
                        DaryaftPos      = x.Select(y => y.DaryaftPos).Sum() ?? 0,
                        DaryaftCheck    = x.Select(y => y.DaryaftCheck).Sum() ?? 0,

                        PardaxtCache    = x.Select(y => y.PardaxtCache).Sum() ?? 0,
                        PardaxtPos      = x.Select(y => y.PardaxtPos).Sum() ?? 0,
                        PardaxtCheck    = x.Select(y => y.PardaxtCheck).Sum() ?? 0,



                        Daramad = x.Select(y => y.Daramad).Sum() ?? 0,
                        Hazineh = x.Select(y => y.Hazineh).Sum() ?? 0,

                    })
                    .ToList();

                //=================
                mS_GridX1.DataSource = ff;
                
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void ms_mah_SelectedTabChanged(object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {
            RefreshGrid();
        }
    }
}
