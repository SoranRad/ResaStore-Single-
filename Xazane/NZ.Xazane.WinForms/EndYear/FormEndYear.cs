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
using NZ.Xazane.Business;
using NZ.Xazane.Model.Models;
using NZ.Xazane.Model.ViewModel;
using ShareLib;
using ShareLib.Interfaces;
using ShareLib.Models;
using ShareLib.Utils;
using ShareLib.ViewModel;

namespace NZ.Xazane.WinForms.EndYear
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
        public FormEndYear()
        {
            InitializeComponent();
            Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
            Init();
        }
        private void    RefreshGrid    ()
        {
            try
            {
                var List = new List<RemaindPeople>();
                Form_Factory
                    .SystemList
                    .MSZ_ForEach(x =>
                    {
                        var list = x.GetListRemaind(null,null);

                        if (list != null)
                            List.InsertRange(0, list);
                    });

                List = List.GroupBy(x => new
                {
                    x.ID          ,
                    x.FK_Group    ,
                    x.kind        ,
                    x.code        ,
                    x.Title       ,
                    x.namePedar   ,
                    x.codeMeli    ,
                    x.tel         ,
                    x.mobile      ,
                    x.GroupTitle  ,
                }).Select(x => new RemaindPeople
                {
                    ID          = x.Key.ID        ,
                    FK_Group    = x.Key.FK_Group  ,
                    kind        = x.Key.kind      ,
                    code        = x.Key.code      ,
                    Title       = x.Key.Title     ,
                    namePedar   = x.Key.namePedar ,
                    codeMeli    = x.Key.codeMeli  ,
                    tel         = x.Key.tel       ,
                    mobile      = x.Key.mobile    ,
                    GroupTitle  = x.Key.GroupTitle,
                    Balance     = x.Sum(y=> y.Balance ),

                }).ToList();

                NzGrid.DataSource = List.Where(x => x.Balance != 0).ToList();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);

            }
        }
        private void    Init           ()
        {
            RefreshGrid();
            NzYears.RefreshCombo();
        }
        private bool    IsOK           ()
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

            if (!NzGrid.GetCheckedRows().Any())
            {
                MS_Message.Show("هیچ ردیفی را برای انتقال به سال بعد انتخاب نکرده اید.");
                NzGrid.Focus();
                mS_Notify1.Show(NzGrid);
                return false;
            }

            return true;
        }
        private void    Save           ( )
        {
            var Mgr = new DpManager();
            var RemailList  = Mgr.GetView<RemaindList>(new
            {
                Year  = SystemConstant.ActiveYear.Salmali,
                Kind1 = (byte)Enums.NzPaymentOperatingKind.RemaindDebit,
                Kind2 = (byte)Enums.NzPaymentOperatingKind.RemaindCredit,

            }).ToList();

            NzGrid
                .GetCheckedRows ()
                .Select         (x => x.DataRow as RemaindPeople)
                .MSZ_ForEach    (people =>
                {
                    var row = RemailList.FirstOrDefault(x => x.ID == people.ID);

                    if(row==null)
                        return;

                    var Item = new DPOperation()
                    {
                        ID              = row.ID_DP ?? 0,
                        FK_Salmali      = SystemConstant.ActiveYear.Salmali,
                        FK_ShaXs        = row.ID,
                        FK_User_Add     = SystemConstant.ActiveUser.ID ,
                        FK_User_Edit    = row.ID_DP >0 ?(short?) SystemConstant.ActiveUser.ID : null,
                        kind            = people.Balance>0? (byte)Enums.NzPaymentOperatingKind.RemaindDebit: (byte)Enums.NzPaymentOperatingKind.RemaindCredit,
                        sharh           = "انتقال یافته از سال قبل",
                        takhfif         = decimal.Parse(Math.Abs(people.Balance).ToString("0.##")),
                        tarikh          = new MS_Structure_Shamsi(SystemConstant.ActiveYear.Salmali, 1, 1).ToDatetime().Date,
                        tarikh_add      = row.ID_DP == null ? DateTime.Now : row.tarikh_add ?? DateTime.Now,
                        tarikh_edit     = row.ID_DP == null ? null : (DateTime?)DateTime.Now,
                    };
                    var mgr = new Manager();
                    mgr.Save(Item);

                });


        }

        private void NzTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsOK())
                    return;

                var Current = SystemConstant.ActiveYear;
                var Dist    = NzYears.SelectedValue as Year;

                SystemConstant.ActiveYear = Dist;

                Save();

                //var factor = GetInitail(Dist.Salmali);

                //if (factor == null)
                //    return;


                //AddItems(factor);
                //Save(factor);

                SystemConstant.ActiveYear = Current;

                MS_Message.Show("عملیات انتقال مانده حساب اشخاص  با موفقیت ثبت شد");
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در ثبت عملیات پایان سال", "خطا", MessageBoxButtons.OK,
                    MSMessage.FarsiMessageBoxIcon.خطا);
                log.Error(ex);
            }
        }

        public void Set_Form_Param(params object[] List_Parametter)
        {}
    }
}
