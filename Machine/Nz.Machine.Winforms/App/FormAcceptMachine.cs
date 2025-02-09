using System;
using System.ComponentModel;
using System.Windows.Forms;
using MS_Control;
using MS_Control.MainForms;
using MS_Control.Tarikh;
using Nz.Machine.DataLayer.UnitOfWork;
using Nz.Machine.Model.Model;
using ShareLib;
using ShareLib.Models;
using ShareLib.Utils;

namespace Nz.Machine.Winforms.App
{
    public partial class FormAcceptMachine : Form_Mother_IRANSans
    {

        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        #region Fields

        private Guid? _ID;
        private AcceptMachine _acceptMachine;
        public event EventHandler MS_Do_Save;
        #endregion
        public FormAcceptMachine(Guid? ID)
        {
            InitializeComponent();
            _ID = ID;
            Init();
        }

        #region Methods

        private void    Init           ()
        {
            NzCustomer.Refresh_Grid(null,3);

            if(_ID!= null)
                LoadItem();
            else 
                Reset();
        }
        private void    Reset          ()
        {
            _ID                 = null;
            _acceptMachine      = new AcceptMachine();
            GetMaxSerial();
            NzDate.MS_Tarikh    = new MS_Structure_Shamsi(DateTime.Now);
            NzTime.Text         = new DateTime(DateTime.Now.Ticks).ToString("HH:mm");
            NzCustomer.MS_Set_Select(null);

            NzMobile.Text           = "0";
            NzHomeAddress.Text      = 
            NzWorkAddress.Text      = 
            NzJob.Text              = 
            NzPlak.Text             =
            NzKindMachine.Text      =
            NzKilometer.Text        =
            NzMachineColor.Text     =
            NzShomareShasi.Text     =
            NzShomareMotor.Text     =
            NzCustomerRequest.Text  = 
            NzDescipt.Text          = "";

            NzLastikYadak.Checked =
            NzAcharCharx .Checked =
            NzJak        .Checked =
            NzRadio      .Checked =
            NzPanel      .Checked =
            NzFandak     .Checked =
            NzDozdGir    .Checked =
            NzAnten      .Checked =
            NzGhalbagh   .Checked =
            NzGhoflRing  .Checked =
            NzMosalaXatar.Checked =
            NzGhoflFarman.Checked =
            NzGhoflPedal .Checked = false;
    
            NzGas.SetLevel(0);
            NzBenzin.Empty();
        }
        private void    GetMaxSerial   ()
        {
            var unitOfWork  = new UnitOfWork(ConnectionManager.Create());
            var repo        = unitOfWork.Repository<AcceptMachine>();
            var maxCode     = repo.GenCode<int>(0, new { Year = SystemConstant.ActiveYear.Salmali });
            NzSerial.MS_Decimal = maxCode+1;
        }
        private bool    IsOK           ()
        {
            if (SystemConstant.ActiveYear.is_close)
            {
                MS_Message.Show("سال مالی جاری بسته شده است " +
                                "\n نمی توانید ادامه دهید");
                return false;
            }

            if  (_acceptMachine.ID == Guid.Empty ||
                (_acceptMachine.ID != Guid.Empty && _acceptMachine.Shomare != NzSerial.MS_Decimal))
            {
                var unitOfWork  = new UnitOfWork(ConnectionManager.Create());
                var repo        = unitOfWork.Repository<AcceptMachine>();
                var result      = repo.IsCodeUnique( new
                {
                    Year    = SystemConstant.ActiveYear.Salmali, 
                    Shomare = NzSerial.MS_Decimal
                });

                if (!result)
                {
                    mS_Notify1.Show(NzSerial);
                    NzSerial.Focus();
                    new Form_Notify("تـوجـه تـوجـه", "شماره فرم تکراری است.",
                            Form_Notify.FarsiMessageBoxIcon.اخطار)
                        .Popup(Form_Notify.Direction_Show.Down_To_Up, 1500);
                    return false;
                }
            }

            if (!NzDate.MS_Tarikh.HasValue)
            {
                mS_Notify1.Show(NzDate);
                NzDate.Focus();
                new Form_Notify("تـوجـه تـوجـه", "تاریخ پذیرش را وارد کنید.",
                        Form_Notify.FarsiMessageBoxIcon.اخطار)
                    .Popup(Form_Notify.Direction_Show.Down_To_Up, 500);
                return false;
            }

            if (!TimeSpan.TryParse(NzTime.Text, out TimeSpan temp))
            {
                mS_Notify1.Show(NzTime);
                NzTime.Focus();
                new Form_Notify("تـوجـه تـوجـه", "زمان پذیرش را وارد کنید.",
                        Form_Notify.FarsiMessageBoxIcon.اخطار)
                    .Popup(Form_Notify.Direction_Show.Down_To_Up, 500);
                return false;
            }

            if (NzCustomer.MS_Get_Selected() == null)
            {
                mS_Notify1.Show(NzCustomer);
                NzCustomer.Focus();
                new Form_Notify("تـوجـه تـوجـه", "مشتری را انتخاب کنید.",
                        Form_Notify.FarsiMessageBoxIcon.اخطار)
                    .Popup(Form_Notify.Direction_Show.Down_To_Up, 500);
                return false;
            }

            return true;
        }
        private void    LoadItem       ()
        {
            var unitOfWork  = new UnitOfWork(ConnectionManager.Create());
            var repo        = unitOfWork.Repository<AcceptMachine>();

            _acceptMachine = repo.GetItem(new { ID = _ID });

            if (_acceptMachine == null)
            {
                MS_Message.Show("فرم مورد نظر یافت نشد");
                Reset();
                return;
            }

            NzSerial.MS_Decimal = _acceptMachine.Shomare;
            NzDate.MS_Tarikh    = new MS_Structure_Shamsi(_acceptMachine.TarixAccept);
            NzTime.Text         = new DateTime(_acceptMachine.TimeAccept.Ticks).ToString("HH:mm");
            NzCustomer.MS_Set_Select(_acceptMachine.FK_People);

            NzMobile.Text           = _acceptMachine.Mobile;
            NzHomeAddress.Text      = _acceptMachine.HomeAddress;
            NzWorkAddress.Text      = _acceptMachine.WorkAddress;
            NzJob.Text              = _acceptMachine.Job;
            NzPlak.Text             = _acceptMachine.Plak;
            NzKindMachine.Text      = _acceptMachine.KindMachine;
            NzKilometer.MS_Decimal  = _acceptMachine.Kilometer;
            NzMachineColor.Text     = _acceptMachine.MachineColor;
            NzShomareShasi.Text     = _acceptMachine.ShomareShasi;
            NzShomareMotor.Text     = _acceptMachine.ShomareMotor;
            NzCustomerRequest.Text  = _acceptMachine.CustomerRequest ;
            NzDescipt.Text          = _acceptMachine.Descipt;

            NzLastikYadak.Checked   = _acceptMachine.LastikYadak ;
            NzAcharCharx.Checked    = _acceptMachine.AcharCharx ;
            NzJak.Checked           = _acceptMachine.Jak ;
            NzRadio.Checked         = _acceptMachine.Radio ;
            NzPanel.Checked         = _acceptMachine.Panel ;
            NzFandak.Checked        = _acceptMachine.Fandak;
            NzDozdGir.Checked       = _acceptMachine.DozdGir ;
            NzAnten.Checked         = _acceptMachine.Anten ;
            NzGhalbagh.Checked      = _acceptMachine.Ghalbagh ;
            NzGhoflRing.Checked     = _acceptMachine.GhoflRing ;
            NzMosalaXatar.Checked   = _acceptMachine.MosalaXatar ;
            NzGhoflFarman.Checked   = _acceptMachine.GhoflFarman ;
            NzGhoflPedal.Checked    = _acceptMachine.GhoflPedal ;

            NzGas.SetLevel(_acceptMachine.Gas);
            NzBenzin.SetValue(_acceptMachine.Benzin);
        }
        private void    Save           ()
        {
            _acceptMachine.Shomare      = Convert.ToInt32( NzSerial.MS_Decimal);
            _acceptMachine.TarixAccept  = NzDate.MS_Tarikh.Value.ToDatetime().Date;
            _acceptMachine.TimeAccept   = TimeSpan.Parse(NzTime.Text);
            _acceptMachine.FK_People    =  ((People)NzCustomer.MS_Get_Selected()).ID;

            _acceptMachine.Mobile       =   NzMobile.Text           ;
            _acceptMachine.HomeAddress  =   NzHomeAddress.Text      ;
            _acceptMachine.WorkAddress  =   NzWorkAddress.Text      ;
            _acceptMachine.Job          =   NzJob.Text              ;
            _acceptMachine.Plak         =   NzPlak.Text             ;
            _acceptMachine.KindMachine  =   NzKindMachine.Text      ;
            _acceptMachine.Kilometer    =   NzKilometer.MS_Decimal  ;
            _acceptMachine.MachineColor =   NzMachineColor.Text     ;
            _acceptMachine.ShomareShasi =   NzShomareShasi.Text     ;
            _acceptMachine.ShomareMotor =   NzShomareMotor.Text     ;
            _acceptMachine.CustomerRequest= NzCustomerRequest.Text  ;
            _acceptMachine.Descipt      =   NzDescipt.Text          ;
                                                                    ;
            _acceptMachine.LastikYadak =    NzLastikYadak.Checked   ;
            _acceptMachine.AcharCharx =     NzAcharCharx.Checked    ;
            _acceptMachine.Jak =            NzJak.Checked           ;
            _acceptMachine.Radio =          NzRadio.Checked         ;
            _acceptMachine.Panel =          NzPanel.Checked         ;
            _acceptMachine.Fandak =         NzFandak.Checked        ;
            _acceptMachine.DozdGir =        NzDozdGir.Checked       ;
            _acceptMachine.Anten =          NzAnten.Checked         ;
            _acceptMachine.Ghalbagh =       NzGhalbagh.Checked      ;
            _acceptMachine.GhoflRing =      NzGhoflRing.Checked     ;
            _acceptMachine.MosalaXatar =    NzMosalaXatar.Checked   ;
            _acceptMachine.GhoflFarman =    NzGhoflFarman.Checked   ;
            _acceptMachine.GhoflPedal = NzGhoflPedal.Checked;

            _acceptMachine.Gas = NzGas.GetLevel();
            _acceptMachine.Benzin = NzBenzin.GetValue();
            _acceptMachine.BenzinPic = NzBenzin.GetImage();


            _acceptMachine.FK_Salmali = SystemConstant.ActiveYear.Salmali;

        }

        #endregion

        private void NzSave_Click       (object sender, EventArgs e)
        {
            try
            {
                if (!IsOK())
                    return;

                Save();

                var unitOfWork  = new UnitOfWork(ConnectionManager.Create());
                var repo        = unitOfWork.Repository<AcceptMachine>();

                repo.Save(_acceptMachine);

                this.Tag = _acceptMachine.ID;

                MS_Do_Save?.Invoke(_ID.HasValue, new AddingNewEventArgs(_acceptMachine.ID));

                new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 1500);

                if (_ID.HasValue)
                    Close();
                else
                    Reset();

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MS_Message.Show(
                        "سیستم قادر به ثبت اطلاعات نیست",
                        "خطا در ثبت", 
                        ex.Message, 
                        MessageBoxButtons.OK
                    );
                log.Error(ex);
            }
        }
        private void NzNew_Click        (object sender, EventArgs e)
        {
            _ID = null;
            Reset();
        }
        private void NzPrintA4_Click    (object sender, EventArgs e)
        {
            if (_acceptMachine != null)
            { 
                var prn = new Print(_acceptMachine.ID, Enums.NzKindPrint.PaperA4);
                prn.Show(this);

            }
           
        }
        private void NzPrintA5_Click    (object sender, EventArgs e)
        {
            if (_acceptMachine != null)
            {
                var prn = new Print(_acceptMachine.ID, Enums.NzKindPrint.PaperA5);
                prn.Show(this);
            }
          
        }
        private void NzCustomer_MS_On_Row_Selected(object sender, MS_Control.TSDD.On_Selected e)
        {
            if (NzCustomer.MS_Get_Selected() is People custoemr)
            {
                NzMobile.Text       = custoemr.mobile;
                NzHomeAddress.Text  = custoemr.addressHome;
                NzWorkAddress.Text  = custoemr.addresswork;
                NzPlak.Text         = custoemr.Plak;
            }
        }
    }
}
