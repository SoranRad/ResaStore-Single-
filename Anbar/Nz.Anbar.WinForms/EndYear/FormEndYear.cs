using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control;
using MS_Control.Tarikh;
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using Nz.Anbar.Model.Report;
using Nz.Anbar.Model.ViewModel;
using ShareLib;
using ShareLib.Interfaces;
using ShareLib.Models;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.EndYear
{
    public partial class FormEndYear : Form, IForm_Editor
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        public              FormEndYear     ()
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
            Init();
        }

        private void        RefreshGrid     ()
        {
            try
            {
                var Mgr = new ReportManager();
                var List = Mgr.GetReport<TransferObject>
                    (new
                {
                    Year            = SystemConstant.ActiveYear.Salmali,
                    KindAvalDore    = (byte)Enums.NzFactorKind.AvalDore,
                    KindFrosh       = (byte)Enums.NzFactorKind.Frosh,
                    }, null);

                ms_Grid.DataSource = List?.ToList();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
            }
        }
        private void        Init            ()
        {
            RefreshGrid();
            NzYears.RefreshCombo();
        }
        private bool        IsOK            ()
        {
            if (NzYears.SelectedValue == null)
            {
                MS_Message.Show("سال مالی مقصد را انتخاب کنید");
                NzYears.Focus();
                mS_Notify1.Show(NzYears);
                return false;
            }

            if (NzYears.SelectedValue is Year tmp && tmp.Salmali == SystemConstant.ActiveYear.Salmali)
            {
                MS_Message.Show("سال مالی مقصد نباید با سال مالی فعلی یکسان باشد");
                NzYears.Focus();
                mS_Notify1.Show(NzYears);
                return false;
            }

            if (!ms_Grid.GetCheckedRows().Any())
            {
                MS_Message.Show("هیچ ردیفی را برای انتقال به سال بعد انتخاب نکرده اید.");
                ms_Grid.Focus();
                mS_Notify1.Show(ms_Grid);
                return false;
            }

            return true;
        }
        private void        AddItems        (FactorHead Factor)
        {
            ms_Grid
                .GetCheckedRows()
                .Select(x => x.DataRow as TransferObject)
                .MSZ_ForEach(x =>
                {
                    var item = new FactorItem()
                    {
                        State       = Enums.NzItemState.AddedNew,
                        FK_Title    = Factor.ID,
                        FactorHead  = Factor,
                        FK_Anbar_Az = 1,
                        FK_Salmali  = SystemConstant.ActiveYear.Salmali,

                        FK_Kala     = x.Code,
                        nerkh       = x.nerkh,
                        mablaq      = x.mablaq,
                        meqdar      = x.Remain,
                        Remain      = x.Remain,

                        CostDescriptor = x.Serial.ToString()
                    };
                    Factor.FactorItems.Add(item);

                    var radif = 1;
                    Factor.FactorItems.MSZ_ForEach(row =>
                    {
                        row.radif = radif++;
                    });

                });
        }
        private void        Save            (FactorHead Factor)
        {
           
                if (Factor.ID == 0)
                {
                    Factor.FK_Salmali   = SystemConstant.ActiveYear.Salmali;
                    Factor.FK_User_Add  = SystemConstant.ActiveUser.ID;
                    Factor.tarikh_add   = DateTime.Now;
                    Factor.kind         = (byte)Enums.NzFactorKind.AvalDore;
                    Factor.Serial       = 1;
                    Factor.tarikh       = new MS_Structure_Shamsi
                                                (SystemConstant.ActiveYear.Salmali, 1, 1)
                                                .ToDatetime()
                                                .Date;
                }

                Factor.mablaq = Factor
                                    .FactorItems.Where(x => x.State != Enums.NzItemState.Deleted)
                                    .Sum(x => x.mablaq);

                var factorManager = new FactorManager();
                factorManager.Save(Factor,false);

            
        }
        private FactorHead  GetInitail      (short Salmali)
        {
            try
            {
                var Mgr     = new Manager();
                var facMgr  = new FactorManager();
                var item    = Mgr.GetItem<InitialStorage>(new
                {
                    Year = Salmali,
                    Kind = (byte)Enums.NzFactorKind.AvalDore
                });
                
               

                var factor = item == null ? new FactorHead() : facMgr.GetItem(item.ID);
                factor.FactorItems.MSZ_ForEach(x =>
                {
                    x.State = Enums.NzItemState.NotChanged;
                });

                return factor;
            }
            catch (Exception ex)
            {
                MS_Message.Show(ex.Message);
            }

            return null;
        }



        private void NzTransfer_Click       (object sender, EventArgs e)
        {
            try
            {
                if (!IsOK())
                    return;

                var Current     = SystemConstant.ActiveYear;
                var Dist        = NzYears.SelectedValue as Year;

                var factor      = GetInitail(Dist.Salmali);

                if (factor == null)
                    return;

                SystemConstant.ActiveYear = Dist;

                AddItems    (factor);
                Save        (factor);

                SystemConstant.ActiveYear = Current;

                MS_Message.Show("عملیات انتقال مانده انبار با موفقیت ثبت شد");
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در ثبت عملیات پایان سال", "خطا", MessageBoxButtons.OK,
                    MSMessage.FarsiMessageBoxIcon.خطا);
                log.Error(ex);
            }
        }
        public void Set_Form_Param          (params object[] List_Parametter)
        {
            
        }
        private void NzRefresh_Click        (object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
