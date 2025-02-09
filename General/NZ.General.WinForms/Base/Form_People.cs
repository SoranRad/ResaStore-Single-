using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control;
using MS_Control.MainForms;
using MS_Control.Tarikh;
using NZ.General.Business;
using ShareLib;
using ShareLib.Models;
using ShareLib.Utils;
using ShareLib.ViewModel;

namespace NZ.General.WinForms.Base
{
    public partial class Form_People : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
                                log4net
                                    .LogManager
                                    .GetLogger
                                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private         People          _Item           = null;
        public event    EventHandler    MS_Do_Save;
        private bool                    _Is_Edit        = false,
                                        _FirstLoad      = true;

        private         Manager         _Manager;
        private         long?           _FK_Pic, 
                                        _FK_Sign, 
                                        _FK_Warranty;
        #endregion
        public Form_People  (Manager Manager, People People)
        {
            InitializeComponent();
            _Item       = People;
            _Manager    = Manager;
            //Init();
        }
        public Form_People  (DbConnection Connection, People People)
        {
            InitializeComponent();
            _Item       = People;
            _Manager    = new Manager(Connection);
            //Init();
        }
        #region Methods
        private void    Save        ()
        {
            _Item.kind          = (byte) Enums.PeopleKind.Customer;
            #region اطلاعات کلی

            _Item.FK_Group      = (NzGroup.MS_Get_Selected() as PeopleGroup).ID;
            _Item.title         = NzTitle.Text.Trim();
            _Item.code          = Convert.ToInt32(NzCode.ButtonText + NzCode.Text);
            _Item.tel           = NzTel.Text;
            _Item.mobile        = NzMobile.Text;
            _Item.is_Xaridar    = NzXaridar.Checked;
            _Item.is_Froshande  = NzFrushande.Checked;
            _Item.is_disable    = NzState.SelectedIndex == 1;
            _Item.Plak          = NzPlak.Text;
            #endregion
            #region اظلاعات مالی

            _Item.isBlock           = NzBlock.Checked;
            _Item.shomareHesab      = string.IsNullOrEmpty(nzAccountNumber.Text.Trim()) ? null : nzAccountNumber.Text.Trim();
            _Item.FK_Bank           = (NzBank1.MS_Get_Selected() as Bank)?.ID;

            if (NzSaqf_Etebar.MS_Decimal == 0)
                _Item.BlockMablaq   = null;
            else 
                _Item.BlockMablaq   = NzKindCredit.SelectedIndex == 0
                                        ? NzSaqf_Etebar.MS_Decimal
                                        : -NzSaqf_Etebar.MS_Decimal;
            #endregion
            #region سایر اطلاعات

            _Item.FK_Shahr          = (NzCity1.MS_Get_Selected() as City)?.ID;
            _Item.tarix             = Nz_BirthDay.MS_Tarikh?.ToDatetime();
            _Item.sex               = Convert.ToByte(NzSex.SelectedIndex + 1);
            _Item.codeMeli          = string.IsNullOrEmpty  (NzNationalCode.Text.Trim())  ? null : NzNationalCode.Text.Trim();
            _Item.mobDowom          = string.IsNullOrEmpty  (NzMobile2.Text.Trim())       ? null : NzMobile2.Text.Trim();
            _Item.telDowom          = string.IsNullOrEmpty  (NzTel2.Text.Trim())          ? null : NzTel2.Text.Trim();
            _Item.fax               = string.IsNullOrEmpty  (NzFax.Text.Trim())           ? null : NzFax.Text.Trim();
            _Item.addressHome       = string.IsNullOrEmpty  (NzHomeAddress.Text.Trim())   ? null : NzHomeAddress.Text.Trim();

            _Item.shomareShenasname = string.IsNullOrEmpty  (NzNo_Shenasname.Text.Trim()) ? null : NzNo_Shenasname.Text.Trim();
            _Item.namePedar         = string.IsNullOrEmpty  (NzFather.Text.Trim())        ? null : NzFather.Text.Trim();
            _Item.codeEqtesadi      = string.IsNullOrEmpty  (NzEconomyNo.Text.Trim())     ? null : NzEconomyNo.Text.Trim();
            _Item.codePosti         = string.IsNullOrEmpty  (NzPostalCode.Text.Trim())    ? null : NzPostalCode.Text.Trim();
            _Item.addresswork       = string.IsNullOrEmpty  (NzWorkAddress.Text.Trim())   ? null : NzWorkAddress.Text.Trim();
            #endregion

            #region مستندات

            if (NzPic.Image != null)
            {
                MemoryStream     ms      = new MemoryStream();
                using (Bitmap    bitmap  = (Bitmap)NzPic.Image)
                {
                    using (Bitmap newBitmap = new Bitmap(bitmap,new Size(250,250)))
                    {
                        newBitmap.SetResolution(80, 80);
                        newBitmap.Save(ms, ImageFormat.Jpeg);
                    }
                }

                var             arr1     = ms.GetBuffer();
                if (_Item.ImagePicture == null)
                    _Item.ImagePicture = new ImageDocument();

                _Item.ImagePicture.Image = arr1;
            }
            else
                _Item.FK_Image_Tasvir = null;
            //==============================

            if (NzSign.Image != null)
            {
                MemoryStream     ms      = new MemoryStream();
                using (Bitmap    bitmap  = (Bitmap)NzSign.Image)
                {
                    using (Bitmap newBitmap = new Bitmap(bitmap,new Size(300,300)))
                    {
                        newBitmap.SetResolution(80, 80);
                        newBitmap.Save(ms, ImageFormat.Jpeg);
                    }
                }

                var             arr2     = ms.GetBuffer();
                if (_Item.ImageSign == null)
                    _Item.ImageSign = new ImageDocument();

                _Item.ImageSign.Image = arr2;
            }
            else
                _Item.FK_Image_Emza = null;
            //==============================

            if (NzWarranty.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                using (Bitmap bitmap = (Bitmap)NzWarranty.Image)
                {
                    using (Bitmap newBitmap = new Bitmap(bitmap, NzWarranty.Image.Size))
                    {
                        newBitmap.SetResolution(80, 80);
                        newBitmap.Save(ms, ImageFormat.Jpeg);
                    }
                }

                var arr     = ms.GetBuffer();
                if (_Item.ImageWarranty == null)
                    _Item.ImageWarranty = new ImageDocument();

                _Item.ImageWarranty.Image = arr;
            }
            else
                _Item.FK_Image_Zemanat = null;
            #endregion
        }
        private void    LoadItem    ()
        {
            try
            {
                _Is_Edit = true;

                #region اطلاعات کلی

                NzGroup.MS_Set_Select       (_Item.FK_Group);
                NzTitle.Text                = _Item.title;
                NzCode.ButtonText           = _Item.FK_Group.ToString();
                NzCode.Text                 = _Item.code.ToString().Substring(NzCode.ButtonText.Length);
                NzTel.Text                  = _Item.tel ;
                NzMobile.Text               = _Item.mobile;
                NzXaridar.Checked           = _Item.is_Xaridar  ;
                NzFrushande.Checked         = _Item.is_Froshande ;
                NzState.SelectedIndex       = _Item.is_disable ? 1 : 0;
                NzPlak.Text                 = _Item.Plak;
                #endregion
                #region اظلاعات مالی

                NzBlock.Checked             =_Item.isBlock??false;
                nzAccountNumber.Text        = _Item.shomareHesab;
                NzBank1.MS_Set_Select       ( _Item.FK_Bank);

                if (_Item.BlockMablaq == null || _Item.BlockMablaq == 0)
                {
                    NzSaqf_Etebar.MS_Decimal    = 0;
                    NzKindCredit.SelectedIndex  = -1;
                }
                else
                {
                    NzSaqf_Etebar.MS_Decimal    = Math.Abs(_Item.BlockMablaq ??0);
                    NzKindCredit.SelectedIndex  = _Item.BlockMablaq > 0 ? 0 : 1;
                }

                #endregion
                #region سایر اطلاعات

                NzCity1.MS_Set_Select   (_Item.FK_Shahr);
                if(_Item.tarix==null)
                    Nz_BirthDay.MS_Tarikh   = null;
                else
                    Nz_BirthDay.MS_Tarikh   = new MS_Structure_Shamsi(_Item.tarix.Value);
                NzSex.SelectedIndex     = _Item.sex -1;
                NzNationalCode.Text     = _Item.codeMeli ;
                NzMobile2.Text          = _Item.mobDowom;
                NzTel2.Text             = _Item.telDowom ;
                NzFax.Text              = _Item.fax;
                NzHomeAddress.Text      = _Item.addressHome;
                NzNo_Shenasname.Text    = _Item.shomareShenasname;
                NzFather.Text           = _Item.namePedar ;
                NzEconomyNo.Text        = _Item.codeEqtesadi;
                NzPostalCode.Text       = _Item.codePosti;
                NzWorkAddress.Text      =  _Item.addresswork;

                #endregion
                #region مستندات

                _FK_Pic                 = _Item.FK_Image_Tasvir;
                _FK_Sign                = _Item.FK_Image_Emza;
                _FK_Warranty            = _Item.FK_Image_Zemanat;

                #endregion

            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void    Reset       ()
        {
            try
            {
                _Item           = new People();
                _Is_Edit        = false;
                _FK_Pic         = null;
                _FK_Sign        = null;
                _FK_Warranty    = null;

                #region اطلاعات کلی
                NzTitle.Text =
                    NzCode.Text =
                        NzTel.Text =
                            NzMobile.Text   = "";

                NzState.SelectedIndex       = 0;
                NzTitle.Focus   ();
                #endregion
                #region اظلاعات مالی

                nzAccountNumber.Text        =
                NzSaqf_Etebar.Text          = "";
                NzBank1.MS_Set_Select       (null);
                NzKindCredit.SelectedIndex  = -1;
                NzBlock.Checked             = false;
                #endregion
                #region سایر اطلاعات

                NzNationalCode.Text     =
                NzNo_Shenasname.Text    =
                NzFather.Text           =
                NzMobile2.Text          =
                NzTel2.Text             =
                NzFax.Text              =
                NzEconomyNo.Text        =
                NzPostalCode.Text       =
                NzHomeAddress.Text      =
                NzWorkAddress.Text      = "";

                Nz_BirthDay.MS_Tarikh   = null;
                NzCity1.MS_Set_Select   (null);

                #endregion
                #region مستندات

                NzPic.Image         = 
                NzSign.Image        = 
                NzWarranty.Image    = null;
                #endregion
               
                GetNewCode      ();
                NzCode.Enabled  = true;
            }
            catch (Exception ex)
            {
                MS_Message.Show("سیستم قادر به اتصال به بانک اطلاعاتی نیست",
                    "خطا در تولید کد", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private bool    IsOK        ()
        {
            if (SystemConstant.ActiveYear.is_close)
            {
                MS_Message.Show("سال مالی جاری بسته شده است " +
                                "\n نمی توانید ادامه دهید");
                return false;
            }
            #region اطلاعات کلی

            if (NzGroup.MS_Get_Selected() == null)
            {
                NzTabInfo.SelectedTab = NzTab1;
                mS_Notify1.Show(NzGroup);
                NzGroup.Focus();
                return false;
            }
            if (NzCode.MS_Decimal == 0)
            {
                NzTabInfo.SelectedTab = NzTab1;
                mS_Notify1.Show(NzGroup);
                NzGroup.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(NzTitle.Text))
            {
                NzTabInfo.SelectedTab = NzTab1;
                mS_Notify1.Show(NzTitle);
                NzTitle.Focus();
                return false;
            }
            ////if (_PeopleGroup.ID == 0 || (_PeopleGroup.ID > 0 && _PeopleGroup.ID != NzCode.MS_Decimal))
            //{
            //    var result = _Manager.IsCodeUnique<PeopleGroup>(new { Code = NzCode.MS_Decimal });
            //    if (!result)
            //    {
            //        mS_Notify1.Show(NzCode);
            //        NzCode.Focus();
            //        new Form_Notify("تـوجـه تـوجـه", "کــد تکراری است.",
            //                Form_Notify.FarsiMessageBoxIcon.اخطار)
            //            .Popup(Form_Notify.Direction_Show.Down_To_Up, 500);
            //        return false;
            //    }
            //}

            #endregion
            #region اظلاعات مالی
            if (NzSaqf_Etebar.MS_Decimal > 0 && NzKindCredit.SelectedIndex == -1)
            {
                NzTabInfo.SelectedTab = NzTab2;
                mS_Notify1.Show(NzKindCredit);
                NzKindCredit.Focus();
                return false;
            }
            #endregion
            return true;
        }
        private void    Init        ()
        {
            #region اطلاعات کلی
            NzGroup.Refresh_Grid((object)_Manager.Connection);
            NzState.SelectedIndex = 0;
            #endregion

            #region اظلاعات مالی
            NzBank1.Refresh_Grid();
            #endregion

            #region سایر اطلاعات
            NzCity1.Refresh_Grid((object)_Manager.Connection);
            #endregion

            if (_Item != null && _Item.ID > 0)
                LoadItem(); 
            else
                Reset();

            NzTabInfo.SelectedTab = NzTab1;
            NzGroup.Focus();
        }
        private void    LoadImages  ()
        {
            var Images          = _Manager.GetItem<PeopleDocument>(new {_Item.ID});

            if (Images.Pic != null && Images.Pic.LongLength>0)
            {
                MemoryStream ms = new MemoryStream(Images.Pic);
                NzPic.Image     = Image.FromStream(ms);
            }

            if (Images.Sign != null && Images.Sign.LongLength > 0)
            {
                MemoryStream ms = new MemoryStream(Images.Sign);
                NzSign.Image    = Image.FromStream(ms);
            }

            if (Images.Warranty != null && Images.Warranty.LongLength > 0)
            {
                MemoryStream ms     = new MemoryStream(Images.Warranty);
                NzWarranty.Image    = Image.FromStream(ms);
            }
        }
        private void    GetNewCode  ()
        {
            if (NzGroup.MS_Get_Selected() != null)
            {
                var Group               = NzGroup.MS_Get_Selected() as PeopleGroup;
                var NewCode             = _Manager.GenerateCode<People, int>(0, new { Code = Group.ID });
                    NzCode.ButtonText   = Group.ID.ToString();

                if (NewCode == 0)
                {
                    var Code            = Group.ID * Math.Pow(10, SystemConstant.NzPeopleCodeLen) + 1;
                    NzCode.Text         = Code.ToString().Substring(NzCode.ButtonText.Length);
                }
                else
                {
                    NzCode.Text = (NewCode + 1).ToString().Substring(NzCode.ButtonText.Length);
                }
            }
        }
        #endregion
        private void ms_Save_Click                  (object sender, EventArgs e)
        {
            try
            {
                if (!IsOK())
                    return;

                Save();

                if (_Item.ImagePicture != null)
                {
                    _Manager.Save(_Item.ImagePicture);
                    _Item.FK_Image_Tasvir = _Item.ImagePicture.ID;

                }
                if (_Item.ImageSign != null)
                {
                    _Manager.Save(_Item.ImageSign);
                    _Item.FK_Image_Emza = _Item.ImageSign.ID;
                }
                if (_Item.ImageWarranty != null)
                {
                    _Manager.Save(_Item.ImageWarranty);
                    _Item.FK_Image_Zemanat = _Item.ImageWarranty.ID;
                }

                _Manager.Save(_Item);

                if (_Item.FK_Image_Tasvir == null && _FK_Pic != null)
                    _Manager.Delete(new ImageDocument() {ID = _FK_Pic.Value});

                if (_Item.FK_Image_Emza == null && _FK_Sign != null)
                    _Manager.Delete(new ImageDocument() { ID = _FK_Sign.Value });

                if (_Item.FK_Image_Zemanat == null && _FK_Warranty != null)
                    _Manager.Delete(new ImageDocument() { ID = _FK_Warranty.Value });

                MS_Do_Save?.Invoke(_Is_Edit, new AddingNewEventArgs(_Item.ID));

                new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
                            .Popup(Form_Notify.Direction_Show.Right_To_Left, 1500);

                this.Tag = _Item.ID;

                if (_Is_Edit)
                    Close();
                else
                    Reset();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MS_Message.Show("سیستم قادر به ثبت اطلاعات نیست",
                    "خطا در ثبت", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void ms_Exit_Click                  (object sender, EventArgs e)
        {
            Close();
        }

        private void NzGroup_MS_On_Row_Selected     (object sender, MS_Control.TSDD.On_Selected e)
        {
            GetNewCode();
        }

        private void NzOpenPic_Click                (object sender, EventArgs e)
        {
            OpenFileDialog b    = new OpenFileDialog();
            b.Filter            = MS_Util.GetImageFilter(false);
            b.Title             = "انتخاب فایل برای تصویر شخص";
            var d               = b.ShowDialog();

            if (d == DialogResult.Cancel)
                return;

            var Img             = Image.FromFile(b.FileName);
            if (Img.Width > 250 || Img.Height > 250)
            {
                var result = MS_Message.Show("کاربر گرامی اندازه تصویر شما بزگتر از اندازه مشخص شده است" +
                                                "\n ایا مایلید تصویر مورد نظرتان را ویرایش کنید؟"
                                                    , "بزرگی تصویر", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                    return;

                var frm         = new MS_Control.Image.Form_Image_Editor(new Size(250, 250));
                frm.MS_Image    = Img;
                if (frm.ShowDialog() != DialogResult.OK)
                    return;

                NzPic.Image     = frm.MS_Image;
            }
            else
            {
                NzPic.Image = Img;
            }


        }
        private void NzDeletePic_Click              (object sender, EventArgs e)
        {
            NzPic.Image = null;
        }

        private void NzOpenSign_Click               (object sender, EventArgs e)
        {
            OpenFileDialog b = new OpenFileDialog();
            b.Filter = MS_Util.GetImageFilter(false);
            b.Title = "انتخاب فایل برای تصویرامضای شخص";
            var d = b.ShowDialog();

            if (d == DialogResult.Cancel)
                return;

            var Img = Image.FromFile(b.FileName);
            if (Img.Width > 300 || Img.Height > 300)
            {
                var result = MS_Message.Show("کاربر گرامی اندازه تصویر شما بزگتر از اندازه مشخص شده است" +
                                             "\n ایا مایلید تصویر مورد نظرتان را ویرایش کنید؟"
                    , "بزرگی تصویر", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                    return;

                var frm = new MS_Control.Image.Form_Image_Editor(new Size(300, 300));
                frm.MS_Image = Img;
                if (frm.ShowDialog() != DialogResult.OK)
                    return;

                NzSign.Image = frm.MS_Image;
            }
            else
            {
                NzSign.Image = Img;
            }

        }
        private void NzDeleteSign_Click             (object sender, EventArgs e)
        {
            NzSign.Image = null;
        }

        private void NzOpenWarranty_Click           (object sender, EventArgs e)
        {
            OpenFileDialog b = new OpenFileDialog();
            b.Filter = MS_Util.GetImageFilter(false);
            b.Title = "انتخاب فایل برای تصویرامضای شخص";
            var d = b.ShowDialog();

            if (d == DialogResult.Cancel)
                return;

            FileInfo fi = new FileInfo(b.FileName);
            if(fi.Length>102400)
            {
                MS_Message.Show("کاربر گرامی اندازه تصویر شما بزگتر از اندازه مشخص شده است" +
                                "\n ایا مایلید تصویر مورد نظرتان را ویرایش کنید؟"
                                , "بزرگی تصویر");
            }
            else
            {
                NzWarranty.Image = Image.FromFile(b.FileName);
            }

        }
        private void NzDeleteWarranty_Click         (object sender, EventArgs e)
        {
            NzWarranty.Image = null;
        }

        private void NzTabInfo_SelectedTabChanged   (object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {
            if (NzTabInfo.SelectedTab == NzTab4 && _FirstLoad && _Item.ID > 0)
            {
                _FirstLoad = false;
                LoadImages();
            }
        }
        private void FormPeopleGroup_KeyUp          (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                ms_Save.PerformClick();
        }

        private void Form_People_Shown              (object sender, EventArgs e)
        {
            Init();
        }

    }
}
