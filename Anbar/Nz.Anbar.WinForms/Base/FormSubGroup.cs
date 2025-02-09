using System; 
using System.ComponentModel; 
using System.Windows.Forms; 
using MS_Control;
using MS_Control.MainForms;
using Nz.Anbar.Model.Model;
using NZ.Anbar.Business; 
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Base
{
    public partial class FormSubGroup : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public const byte CODELENGTH = 2;
        #endregion
        #region Fields
        private Manager             _Manager;
        private SubGroup            _Item;
        private bool                _Is_Edit = false;
        public event EventHandler   MS_Do_Save;
        #endregion
        #region Constructor
        public FormSubGroup        (Manager Manager, SubGroup Row = null)
        {
            InitializeComponent();

            _Manager    = Manager;
            _Item       = Row;
        }
        #endregion
        #region Methods
        private void    LoadItem       ()
        {
            try
            {
                _Is_Edit = true;
                NzCode.Enabled =
                    !_Manager
                        .HaveCircular<SubGroup>
                            (new
                            {
                                Year = SystemConstant.ActiveYear.Salmali,
                                _Item.Code
                            });

                NzTitle.Text    = _Item.title;
               
                NzMainGroup.MS_Set_Select(_Item.FK_GroupKala_1th);
                if (_Item.FK_GroupKala_1th.HasValue)
                {
                    var Strcode         = _Item.Code.ToString();
                    var MCode           = _Item.FK_GroupKala_1th?.ToString()??"";
                    NzCode.Text         = Strcode.Substring(MCode.Length);
                    NzCode.ButtonText   = MCode;
                }
                else
                {
                    NzCode.Text         = _Item.Code.ToString();
                    NzCode.ButtonText   = "";
                }

            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void    Save       ()
        {
            _Item.title                 = NzTitle.Text;
            _Item.Code                  = Convert.ToInt16(NzCode.ButtonText + NzCode.Text);
            _Item.FK_GroupKala_1th      = (NzMainGroup.MS_Get_Selected() as MainGroup).Code;
        }
        private void    Reset      ()
        {
            try
            {
                _Item               = new SubGroup();
                _Is_Edit            = false;
                NzTitle.Text        = "";
                
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
                MS_Message.Show("سال مالی بسته شده است \n " +
                                "نمی توانید ادامه دهید ");
                return false;
            }
            if (NzMainGroup.MS_Get_Selected() == null)
            {
                mS_Notify1.Show(NzMainGroup);
                return false;
            }
            var code = Convert.ToInt16(NzCode.ButtonText + NzCode.Text);

            if(_Item.ID==0 || (_Item.ID>0 && _Item.Code!=code))
                if (!_Manager.IsCodeUnique<SubGroup>
                                (new
                                {
                                    Year = SystemConstant.ActiveYear.Salmali,
                                    Code = code
                                })
                )
                {
                    MS_Message.Show("کد وارد شده تکراری است");
                    mS_Notify1.Show(NzCode);
                    return false;
                }
            if (string.IsNullOrWhiteSpace(NzTitle.Text))
            {
                mS_Notify1.Show(NzTitle);
                NzTitle.Focus();
                return false;
            }


            return true;
        }
        private void    Init       ()
        {
            NzMainGroup.Refresh_Grid( (object)_Manager);
            NzCode.MaxLength = CODELENGTH;

            if (_Item != null && _Item.ID > 0)
                LoadItem();
            else
                Reset();

            NzMainGroup.Focus();
        }

        private void    MaxCode    ()
        {
            var MainGr = NzMainGroup.MS_Get_Selected() as MainGroup;
            if (MainGr != null)
            {
                var Code = _Manager
                    .GenerateCode<SubGroup, short>
                    (0, new
                    {
                        Year = SystemConstant.ActiveYear.Salmali,
                        MainGr.Code
                    });

                NzCode.ButtonText = MainGr.Code.ToString();
                if (Code == 0)
                {
                    NzCode.Text = @"".PadLeft(CODELENGTH - 1, '0') + @"1";
                }
                else
                {
                    var SubCode = Code.ToString().Substring(NzCode.ButtonText.Length);
                    NzCode.Text = (Convert.ToInt16(SubCode)+1).ToString("D" + CODELENGTH);
                }

            }
        }
        #endregion

        private void    ms_Save_Click          (object sender, EventArgs e)
        {
            try
            {
                if (!IsOK())
                    return;
                Save();
                _Manager.Save(_Item);
                MS_Do_Save?.Invoke(_Is_Edit, new AddingNewEventArgs(_Item.ID));

                new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.اضافه)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 1000);

                this.Tag = _Item.ID;
                DialogResult = DialogResult.OK;
                if (_Is_Edit)
                    Close();
                else
                    Reset();
                
            }
            catch (Exception ex)
            {
                MS_Message.Show("سیستم قادر به ثبت اطلاعات نیست",
                    "خطا در ثبت", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void    ms_Exit_Click          (object sender, EventArgs e)
        {
            Close();
        }
        private void    FormStorage_Shown      (object sender, EventArgs e)
        {
            Init();
        }
        private void    FormStorage_KeyUp      (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                ms_Save.PerformClick();

        }
        private void    NzMainGroup_Selected   (object sender, MS_Control.TSDD.On_Selected e)
        {
            MaxCode();
        }
    }
}
