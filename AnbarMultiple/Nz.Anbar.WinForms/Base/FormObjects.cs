using System; 
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using MS_Control;
using MS_Control.MainForms;
using Nz.Anbar.Model.Model; 
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using Nz.Anbar.Model.Report;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Base
{
    public partial class FormObjects : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private Manager             _Manager;
        private NzObject            _Item;
        private bool                _Is_Edit = false;
        public event EventHandler   MS_Do_Save;
        private bool _IsFirstLoad   = false;
        #endregion
        public          FormObjects         (Manager Manager, NzObject Row = null)
        {
            InitializeComponent();
            
            _Manager    = Manager??new Manager();
            _Item       = Row;
        }
        #region Methods
        private void    LoadItem   ()
        {
            try
            {
                _Is_Edit = true;
                NzCode.Enabled =
                    !_Manager
                        .HaveCircular<NzObject>
                            (new
                            {
                                Year = SystemConstant.ActiveYear.Salmali,
                                _Item.Code
                            });

                NzSubGroups.MS_Set_Select(_Item.FK_GroupKala_2th);
                NzCode.Text             = _Item.Code.ToString().Substring(_Item.FK_GroupKala_2th.ToString().Length);
                NzCode.ButtonText       = _Item.FK_GroupKala_2th.ToString();
                NzTitle.Text            = _Item.title;
                NzUnits.MS_Set_Select(_Item.FK_Vahed);
                NzKind.SelectedIndex    = _Item.kind - 1;
                NzBarCode.Text          = _Item.barcode;
                NzState.SelectedIndex   = _Item.is_disabled ? 1 : 0;
                NzTechNumber.Text       = _Item.codeFani;
                NzTechName.Text         = _Item.nameFani;
                NzContryMade.Text       = _Item.keshvarSazande;
                NzOrderPoint.Text       = _Item.point_bohrani?.ToString("0,0.##");

                NzPrice.MS_Decimal      = _Item.nerkh_frosh;
                NzSize.Text             = _Item.Size;
                NzBrand.MS_Set_Select   (_Item.FK_Brand);

                NzLength.MS_Decimal     = _Item.Length??0;
                NzWidth.MS_Decimal      = _Item.Width??0;
                NzHeight.MS_Decimal     = _Item.Height ?? 0;
                NzGender.Text           = _Item.Gender;

                NzSeason.SelectedIndex  = _Item.Season ?? 0;
                NzBasteBandi.MS_Set_Select(_Item.FK_BasteBandi);

                NzColor.Text            = _Item.Color?.ToString();
                if (_Item.Color != null && _Item.Color != 0)
                    NzColor.ControlStyle.ControlColor = Color.FromArgb(_Item.Color ?? 0);
                else
                    NzColor.ControlStyle.ControlColor = Color.White;

                nzUnit_2.MS_Set_Select(_Item.FK_Vahed_Fari);
                Nz_Zarib.Text     = _Item.Zarib.ToString("0,0.##;0,0.##; ");


            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void    Save       ()
        {
            _Item.title             = NzTitle.Text;
            _Item.Code              = Convert.ToInt32(NzCode.ButtonText + NzCode.Text);
            _Item.FK_GroupKala_2th  = (NzSubGroups.MS_Get_Selected() as SubGroup).Code;
            _Item.FK_Vahed          = (NzUnits.MS_Get_Selected() as Unit).ID;
            _Item.kind              = Convert.ToByte(NzKind.SelectedIndex + 1);
            _Item.is_disabled       = NzState.SelectedIndex == 1;
            _Item.barcode           = NzBarCode.Text;
            _Item.codeFani          = NzTechNumber.Text;
            _Item.nameFani          = NzTechName.Text;
            _Item.keshvarSazande    = NzContryMade.Text;
            _Item.point_bohrani     = NzOrderPoint.MS_Decimal;

            _Item.nerkh_frosh      = NzPrice.MS_Decimal;
            _Item.Size             = NzSize.Text;
            _Item.FK_Brand         = (NzBrand.MS_Get_Selected()as Brand)?.ID;
            _Item.FK_BasteBandi    = (NzBasteBandi.MS_Get_Selected() as BasteBandi)?.ID;

            _Item.Length            = NzLength.MS_Decimal;
            _Item.Width             = NzWidth.MS_Decimal ;
            _Item.Height            = NzHeight.MS_Decimal ;
            _Item.Gender            = NzGender.Text;

            if(NzSeason.SelectedIndex >= 0)
                _Item.Season        = Convert.ToByte(NzSeason.SelectedIndex);

            _Item.Color             = string.IsNullOrWhiteSpace(NzColor.Text)?null: (int?)Convert.ToInt32(NzColor.Text);

            if (string.IsNullOrWhiteSpace(nzUnit_2.Text))
            {
                _Item.FK_Vahed_Fari = null;
                _Item.Zarib         = 0;
            }
            else
            {
                if (nzUnit_2.MS_Get_Selected() is Unit Unit2)
                {
                    _Item.FK_Vahed_Fari = Unit2.ID;
                    _Item.Zarib = Nz_Zarib.MS_Decimal;
                }
                else
                {
                    _Item.FK_Vahed_Fari = null;
                    _Item.Zarib = 0;
                }
            }

            if (NzPic.Image != null)
            {
                var img = _Item.tbl_Images ?? new ObjectImages();
                if (_Item.tbl_Images == null)
                {
                    _Item.tbl_Images = img;
                    //img.Objects.Add(_Item);
                }

                MemoryStream ms = new MemoryStream();
                using (Bitmap bitmap = (Bitmap)NzPic.Image)
                {
                    using (Bitmap newBitmap = new Bitmap(bitmap, new Size(300, 300)))
                    {
                        newBitmap.SetResolution(80, 80);
                        newBitmap.Save(ms, ImageFormat.Jpeg);
                    }
                }
                
                img.Image = ms.GetBuffer();
            }
            else
            {
                if (_Item.tbl_Images != null && _Item.tbl_Images.ID>0)
                {
                    var id              = _Item.FK_Image??0;
                    _Item.FK_Image      = null;
                    _Item.tbl_Images    = null;
                    _Manager.Delete(new ObjectImages(){ID = id});
                }
            }
        }
        private void    Reset      ()
        {
            try
            {
                _Item               = new NzObject();
                _Is_Edit            = false;

                NzTitle.Text        = 
                NzBarCode.Text      = 
                NzTechName.Text     = 
                NzTechNumber.Text   = 
                NzContryMade.Text   = "";

                NzPrice.Text    = 
                NzSize.Text     = 
                NzLength.Text   = 
                NzWidth.Text    = 
                NzHeight.Text   = 
                NzGender.Text   = 
                NzColor.Text    = "";

                //NzBasteBandi.MS_Set_Select(null);
                NzSeason.SelectedIndex = -1;
                NzPic.Image = null;

                MaxCode();
                NzTitle.Focus();
            }
            catch (Exception ex)
            {
                MS_Message.Show("سیستم قادر به اتصال به بانک اطلاعاتی نیست",
                    "خطا در تولید کد", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private bool    IsOK       ()
        {
            if (SystemConstant.ActiveYear.is_close)
            {
                MS_Message.Show("سال مالی بسته شده است \n " + "نمی توانید ادامه دهید ");
                return false;
            }
            if (NzSubGroups.MS_Get_Selected() == null)
            {
                mS_Notify1.Show(NzSubGroups);
                return false;
            }

            var Code = Convert.ToInt32(NzCode.ButtonText + NzCode.Text);
            if(_Item.ID==0 || (_Item.ID>0 && _Item.Code!=Code))
                if (!_Manager.IsCodeUnique<NzObject>
                                (new
                                {
                                    Year = SystemConstant.ActiveYear.Salmali,
                                    Code = Code
                                })
                )
                {
                    MS_Message.Show("کد وارد شده تکراری است");
                    mS_Notify1.Show(NzCode);
                    return false;
                }

            if (!string.IsNullOrWhiteSpace(NzBarCode.Text))
            {
                if (_Item.ID == 0 || (_Item.ID > 0 && _Item.barcode != NzBarCode.Text.Trim()))
                {
                    if (!_Manager.IsCodeUnique<BarcodeUnique>
                        (new
                        { 
                            BarCode = NzBarCode.Text.Trim()
                        })
                       )
                    {
                        var result = MS_Message.Show("بارکد کالای وارد شده تکراری است"+
                                        "\n\n آیا مایلید با این بارکد  تکراری کالا را ثبت کنید؟",
                            "بارکد تکراری",
                            MessageBoxButtons.YesNo,MSMessage.FarsiMessageBoxIcon.سوال);
                        if (result != DialogResult.Yes)
                        {

                            mS_Notify1.Show(NzBarCode);
                            NzBarCode.Focus();
                            return false;
                        }
                        
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(NzTitle.Text))
            {
                mS_Notify1.Show(NzTitle);
                NzTitle.Focus();
                return false;
            }
            if(NzUnits.MS_Get_Selected() ==null)
            {
                mS_Notify1.Show(NzUnits);
                NzUnits.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(nzUnit_2.Text) )
            {
                var asli = NzUnits.MS_Get_Selected() as Unit;
                var fari = nzUnit_2.MS_Get_Selected() as Unit;

                if (asli.ID == fari.ID)
                {
                    uiTab1.SelectedIndex = 1;
                    mS_Notify1.Show(nzUnit_2);
                    nzUnit_2.Focus();
                    MS_Message.Show("واحد اصلی و فرعی نباید یکی باشند");
                    return false;
                }

                if (Nz_Zarib.MS_Decimal <= 0)
                {
                    uiTab1.SelectedIndex = 1;
                    mS_Notify1.Show(Nz_Zarib);
                    Nz_Zarib.Focus();
                    MS_Message.Show("در صورتیکه واحد فرعی را مشخص کردید باید ضریب تبدیل آن را نیز وارد کنید");
                    return false;
                }
                
            }

            return true;
        }
        private void    Init       ()
        {
            NzSubGroups     .Refresh_Grid((object)_Manager);
            NzUnits         .Refresh_Grid((object)_Manager);
            nzUnit_2        .Refresh_Grid((object)_Manager);
            NzBrand         .Refresh_Grid();
            NzBasteBandi    .Refresh_Grid();

            NzState.SelectedIndex   = 0;
            NzKind.SelectedIndex    = 0;

            NzCode.MaxLength        = SystemConstant
                                        .NzSubGroupCodeLen - 
                                            SystemConstant.NzSubGroupCodeLen;

            if (_Item != null && _Item.ID > 0)
                LoadItem();
            else
                Reset();

            NzSubGroups.Focus();

            nzUnit_2.Visible = Nz_Zarib.Visible = SystemConstant.HasVahedFari;
        }
        private void    MaxCode    ()
        {
            var SubGr = NzSubGroups.MS_Get_Selected() as SubGroup;
            if (SubGr != null)
            {
                var Code = _Manager
                    .GenerateCode<NzObject, int>
                    (0, new
                    {
                        Year = SystemConstant.ActiveYear.Salmali,
                        SubGr.Code
                    });

                NzCode.ButtonText = SubGr.Code.ToString();
                if (Code == 0)
                {
                    NzCode.Text     = @"".PadLeft(
                                        SystemConstant.NzObjectCodeLen-1 , '0') + @"1";
                }
                else
                {
                    var SubCode     = Code.ToString().Substring(NzCode.ButtonText.Length);
                    NzCode.Text     = (Convert.ToInt32(SubCode) + 1).ToString("D" + SystemConstant.NzObjectCodeLen.ToString());
                }

            }
    }

        private void TranslateUnits()
        {
            Nz_Translate.Text =" هر " + NzUnits.Text + " شامل " + Nz_Zarib.MS_Decimal + " " + nzUnit_2.Text + " می باشد";
        }
        #endregion

        private void ms_Save_Click              (object sender, EventArgs e)
        {
            try
            {
                if (!IsOK())
                    return;
                Save();
                if (_Item.tbl_Images != null)
                {
                    _Manager.Save(_Item.tbl_Images);
                    _Item.FK_Image = _Item.tbl_Images.ID;
                }

                _Manager.Save(_Item);


                MS_Do_Save?.Invoke(_Is_Edit, new AddingNewEventArgs(_Item.ID));

                new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.اضافه)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 1000);
                Tag = _Item.ID;

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
        private void ms_Exit_Click              (object sender, EventArgs e)
        {
            Close();
        }
        private void FormStorage_Shown          (object sender, EventArgs e)
        {
            Init();
        }
        private void FormStorage_KeyUp          (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                ms_Save.PerformClick();

        }
        private void NzMainGroup_Selected       (object sender, MS_Control.TSDD.On_Selected e)
        {
            MaxCode();
        }

        private void ms_Open_Pic_Click          (object sender, EventArgs e)
        {
            var b = new OpenFileDialog
            {
                Filter  = MS_Util.GetImageFilter(true),
                Title   = "انتخاب تصویر  برای کالا"
            }; 

            if (b.ShowDialog() == DialogResult.Cancel)
                return;
            
            NzPic.Image = Image.FromFile(b.FileName); 
        }
        private void ms_Delete_Pic_Click        (object sender, EventArgs e)
        {
            NzPic.Image = null;
        }

        private void NzColor_ButtonClick        (object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NzColor.Text))
                colorDialog1.Color = Color.FromArgb(Convert.ToInt32(NzColor.Text));

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                NzColor.Text = colorDialog1.Color.ToArgb().ToString();
                NzColor.ControlStyle.ControlColor = colorDialog1.Color;
            }
        }

        private void uiTab1_SelectedTabChanged  (object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {
            if (uiTab1.SelectedTab == uiTabPage2 && !_IsFirstLoad && _Item.FK_Image > 0)
            {
                try
                {
                    var Images          = _Manager.GetItem<ObjectImages>(new { ID = _Item.FK_Image });
                    _Item.tbl_Images    = Images;

                    if (Images?.Image != null && Images.Image.LongLength > 0)
                    {
                        MemoryStream ms = new MemoryStream(Images.Image);
                        NzPic.Image = Image.FromStream(ms);
                    }
                    _IsFirstLoad = true;
                }
                catch (Exception ex)
                {
                    MS_Message.Show("برنامه قادر به خواندن تصویر نیست");
                    log.Error(ex);
                }

            }

             
        }


        private void NzUnits_MS_On_Row_Selected (object sender, MS_Control.TSDD.On_Selected e)
        {
            TranslateUnits();
        }
        private void nzUnit_2_MS_On_Row_Selected(object sender, MS_Control.TSDD.On_Selected e)
        {
            TranslateUnits();

        }
        private void Nz_Zarib_TextChanged       (object sender, EventArgs e)
        {
            TranslateUnits();

        }
    }
}
