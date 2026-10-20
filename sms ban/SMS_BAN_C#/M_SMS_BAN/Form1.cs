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



namespace M_SMS_BAN
{
    public partial class MainForm : Form
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct Send_AT
        {
            public int Response_Len;
            [MarshalAs(UnmanagedType.BStr)] public string Result;
        };

        [StructLayout(LayoutKind.Sequential)]
        public struct SMS_Space_Struct
        {
            public int Free_Space;
            public int Total_Size;
            public bool Result;
        };

        [StructLayout(LayoutKind.Sequential)]
        public struct OffLine_SMS_Struct
        {
            [MarshalAs(UnmanagedType.BStr)] public string SMS_Center;
            [MarshalAs(UnmanagedType.BStr)] public string SMS_Type;
            [MarshalAs(UnmanagedType.BStr)] public string Tel_Number;
            [MarshalAs(UnmanagedType.BStr)] public string Time_stamp;
            [MarshalAs(UnmanagedType.BStr)] public string S_Discharge;
            [MarshalAs(UnmanagedType.BStr)] public string TP_PID;
            [MarshalAs(UnmanagedType.BStr)] public string TP_DCS;
            [MarshalAs(UnmanagedType.BStr)] public string TP_VP;
            [MarshalAs(UnmanagedType.BStr)] public string TP_ST;
            [MarshalAs(UnmanagedType.BStr)] public string S_Reference;
            public int All_Part;
            public int Part_NO;
            [MarshalAs(UnmanagedType.BStr)] public string SMS_Text;
            public bool Result;
        };

        [StructLayout(LayoutKind.Sequential)]
        public struct GSM_Dial_Struct
        {            
            [MarshalAs(UnmanagedType.BStr)] public string Res_MSG;
            public bool Result;
        };

        [StructLayout(LayoutKind.Sequential)]
        public struct GSM_Message_Struct
        {
            [MarshalAs(UnmanagedType.BStr)] public string Message_Text;
            public int Result;
        };

        [DllImport("DllManshoorGSM.dll", EntryPoint = "Recieved_New_SMS", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern bool Recieved_New_SMS(ref int Index_From, ref int Index_To);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "GSM_OFF", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern bool GSM_OFF();


        [DllImport("DllManshoorGSM.dll", EntryPoint = "GSM_ON", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern bool GSM_ON();


        [DllImport("DllManshoorGSM.dll", EntryPoint = "SMS_PDU_Mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern bool SMS_PDU_Mode(bool PDU);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "SMS_Dev_INFO", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        static extern void SMS_Dev_INFO([MarshalAs(UnmanagedType.BStr)] out string DevInfo);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "SMS_Soft_Ver", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        static extern void SMS_Soft_Ver([MarshalAs(UnmanagedType.BStr)] out string SoftVer);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "SMS_Device_Count", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern short SMS_Device_Count();


        [DllImport("DllManshoorGSM.dll", EntryPoint = "SMS_Select_Device", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern void SMS_Select_Device(short Index);

        [DllImport("DllManshoorGSM.dll", EntryPoint = "SMS_SelectDeicve_ByIndex", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern void SMS_SelectDeicve_ByIndex(short Index);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "Res_AT_Delay", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern void Res_AT_Delay(int Delay);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "GSM_Send_AT", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        static extern void GSM_Send_AT([MarshalAs(UnmanagedType.BStr)] string AT_Input, ref int AtOutput_Length, [MarshalAs(UnmanagedType.BStr)] out string AT_OutPut);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "Last_Buf_Index", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern Int16 Last_Buf_Index();


        [DllImport("DllManshoorGSM.dll", EntryPoint = "Clear_Buf", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern void Clear_Buf();


        [DllImport("DllManshoorGSM.dll", EntryPoint = "GSM_MSG", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        static extern void GSM_MSG([MarshalAs(UnmanagedType.BStr)] out string Result, ref int GSM_CMD, ref int GSM_Len);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "S_SMS3", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        static extern void S_SMS3([MarshalAs(UnmanagedType.BStr)] out string Result, [MarshalAs(UnmanagedType.BStr)] string Phone_NO,
                                  [MarshalAs(UnmanagedType.BStr)] string SMS_Text, bool Request_Delivery_Report, int Send_Interval, int Retry_Times,
                                  int SMS_Validity, int SMS_Reference, [MarshalAs(UnmanagedType.BStr)] string SMS_Center);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "Send_SMS_Error_Code", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        static extern void Send_SMS_Error_Code([MarshalAs(UnmanagedType.BStr)] out string Result);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "Send_Text_SMS", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        static extern bool Send_Text_SMS(bool PDU, [MarshalAs(UnmanagedType.BStr)] string Country_Code, [MarshalAs(UnmanagedType.BStr)] string Phone_NO,
                                         [MarshalAs(UnmanagedType.BStr)] string SMS_TXT);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "R_SMS_Ref", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        static extern void R_SMS_Ref([MarshalAs(UnmanagedType.BStr)] out string Result);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "Group_SMS_Setting", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        static extern void Group_SMS_Setting(bool SMS_Delivery, int SMS_Validity, int SMS_NO_Change_Sim, int Repeat_NO,
                                                      int Send_Interval, [MarshalAs(UnmanagedType.BStr)] string SMS_Center);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "Add_Group_SMS_Buffer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        static extern void Add_Group_SMS_Buffer([MarshalAs(UnmanagedType.BStr)] string Phone_NO, [MarshalAs(UnmanagedType.BStr)] string SMS_Context);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "SMS_Buf_Clear", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern void SMS_Buf_Clear(bool Stop);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "SMS_Buf_Start", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern void SMS_Buf_Start(bool Start);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "Get_SMS_Buf_Indx", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern int Get_SMS_Buf_Indx();


        [DllImport("DllManshoorGSM.dll", EntryPoint = "Get_SMS_Buf_Sended", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern int Get_SMS_Buf_Sended();


        [DllImport("DllManshoorGSM.dll", EntryPoint = "SMS_Buf_Pause", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern void SMS_Buf_Pause();


        [DllImport("DllManshoorGSM.dll", EntryPoint = "Get_SMS_Buf_Status", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern bool Get_SMS_Buf_Status(int index, ref bool Send_Done);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "Active_New_SMS_Event", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern bool Active_New_SMS_Event(bool NS_Active);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "Get_SMS_Space", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern void  Get_SMS_Space(out SMS_Space_Struct SMS_Space);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "Get_SMS_NO", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern int Get_SMS_NO();


        [DllImport("DllManshoorGSM.dll", EntryPoint = "SMS_Delete", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern bool SMS_Delete(int Index, int Delete_type);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "R_SMS4", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        static extern bool R_SMS4([MarshalAs(UnmanagedType.BStr)] out string Result, bool PDU, int Index, [MarshalAs(UnmanagedType.BStr)] out string SMS_Center,
                                  [MarshalAs(UnmanagedType.BStr)] out string SMS_Type, [MarshalAs(UnmanagedType.BStr)] out string Tel_Number,
                                  [MarshalAs(UnmanagedType.BStr)] out string Time_stamp, [MarshalAs(UnmanagedType.BStr)] out string S_Discharge,
                                  [MarshalAs(UnmanagedType.BStr)] out string SMS_Text, [MarshalAs(UnmanagedType.BStr)] out string TP_PID,
                                  [MarshalAs(UnmanagedType.BStr)] out string TP_DCS, [MarshalAs(UnmanagedType.BStr)] out string TP_VP,
                                  [MarshalAs(UnmanagedType.BStr)] out string TP_ST, [MarshalAs(UnmanagedType.BStr)] out string S_Reference,
                                  [MarshalAs(UnmanagedType.BStr)] out string All_Part, [MarshalAs(UnmanagedType.BStr)] out string Part_NO);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "Total_Oflline_SMS_NO", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern int Total_Oflline_SMS_NO();


        [DllImport("DllManshoorGSM.dll", EntryPoint = "Total_Oflline_SMS_NO", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        static extern void Show_Oflline_SMS(out OffLine_SMS_Struct OffLine_SMS, int Index);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "Clear_Oflline_SMS_NO", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern bool Clear_Oflline_SMS_NO();


        [DllImport("DllManshoorGSM.dll", EntryPoint = "G_Offline_SMS_Active", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern bool G_Offline_SMS_Active();


        [DllImport("DllManshoorGSM.dll", EntryPoint = "R_SMS_Center", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern void R_SMS_Center([MarshalAs(UnmanagedType.BStr)] out string Result);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "Change_SMS_Center", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        static extern bool Change_SMS_Center([MarshalAs(UnmanagedType.BStr)] string SMS_Center);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "GSM_Set_Device_NO", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern bool GSM_Set_Device_NO(int Device_No);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "GSM_Get_Device_NO", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        static extern int GSM_Get_Device_NO();


        [DllImport("DllManshoorGSM.dll", EntryPoint = "SMS_Char_Mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern bool SMS_Char_Mode(int CharMode);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "CallerID_Enable", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern bool CallerID_Enable(bool Active);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "GSM_Dial_NO", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        static extern bool GSM_Dial_NO(out GSM_Dial_Struct Gsm_Dial, [MarshalAs(UnmanagedType.BStr)] string CountryCode, [MarshalAs(UnmanagedType.BStr)] string Phone_NO);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "GSM_Answer_Call", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern bool GSM_Answer_Call();


        [DllImport("DllManshoorGSM.dll", EntryPoint = "Disconnect_Voice_Call", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern bool Disconnect_Voice_Call();


        [DllImport("DllManshoorGSM.dll", EntryPoint = "GSM_Test_Connect", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern bool GSM_Test_Connect();


        [DllImport("DllManshoorGSM.dll", EntryPoint = "GSM_Ready", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern bool GSM_Ready();


        [DllImport("DllManshoorGSM.dll", EntryPoint = "R_IMEI", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        static extern void R_IMEI([MarshalAs(UnmanagedType.BStr)] out string IMEI);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "R_Natttional_Mobile_ID", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        static extern void R_Natttional_Mobile_ID([MarshalAs(UnmanagedType.BStr)] out string NMobileID);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "Set_GSM_Date_Time", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern bool Set_GSM_Date_Time(int GSM_Year, int GSM_Month, int GSM_Day, int GSM_Hour, int GSM_Minute, int GSM_Second);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "R_GSM_Date_Time", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        static extern void R_GSM_Date_Time([MarshalAs(UnmanagedType.BStr)] out string DateTime);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "R_GSM_POW", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern bool R_GSM_POW();


        [DllImport("DllManshoorGSM.dll", EntryPoint = "Get_GSM_Message", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern void Get_GSM_Message(out GSM_Message_Struct Gsm_Msg);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "R_SIM_PIN", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        static extern void R_SIM_PIN([MarshalAs(UnmanagedType.BStr)] out string SimPin);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "Selected_Network", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        static extern void Selected_Network([MarshalAs(UnmanagedType.BStr)] out string Network);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "R_SIM_ID", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        static extern void R_SIM_ID([MarshalAs(UnmanagedType.BStr)] out string SimID);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "GSM_Signal", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        static extern void GSM_Signal([MarshalAs(UnmanagedType.BStr)] out string Signal);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "Select_SIM_Network", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern bool Select_SIM_Network();


        [DllImport("DllManshoorGSM.dll", EntryPoint = "Insert_PIN", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        static extern bool Insert_PIN([MarshalAs(UnmanagedType.BStr)] string Pin);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "CallIn_Number", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        static extern void CallIn_Number([MarshalAs(UnmanagedType.BStr)] out string CallNumber);


        [DllImport("DllManshoorGSM.dll", EntryPoint = "Offline_SMS_Active", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static extern void Offline_SMS_Active(bool Active);


        public MainForm()
        {
            InitializeComponent();
        }
        
        public string Message_Text;
        public int M_C = -1;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }
      

        private void timer1_Tick(object sender, EventArgs e)
        {            
            int Index_From = 0;
            int Index_To = 0;                       
            ReceiveCheckBox.Checked = Recieved_New_SMS(ref Index_From, ref Index_To);
            if (ReceiveCheckBox.Checked)
            { 
                Sms_FromEdit.Text = Index_From.ToString();
                Sms_ToEdit.Text = Index_To.ToString();
	        }
	    }


        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {

        }


        private void GSMOFFButton_Click(object sender, EventArgs e)
        {
            GSM_OFF();
        }


        private void GSMONButton_Click(object sender, EventArgs e)
        {
            GSM_ON();
        }

 
        private void BitBtn_Send_SMS_Type_Click(object sender, EventArgs e)
        {
            StatusBar1.Text = "";
            if (SMS_PDU_Mode(PDURadioButton.Checked))
                StatusBar1.Items[0].Text = "با موفقيت انجام شد";
            else
                StatusBar1.Items[0].Text = "انجام نشد";
        }


        private void SendCMDButton_Click(object sender, EventArgs e)
        {
            string st = "";
            SCMD_DataEdit.Text = "";
            SMS_Dev_INFO(out st);
            SCMD_DataEdit.Text = st; 
        }

        private void SoftVerutton1_Click(object sender, EventArgs e)
        {
            string st = "";
            SoftVerEdit1.Text = "";
            SMS_Soft_Ver(out st);
            SoftVerEdit1.Text = st;
        }

        private void SearchDevicesButton_Click(object sender, EventArgs e)
        {
            NumberOfDevicesEdit.Text = SMS_Device_Count().ToString();
        }

        private void SelectDeviceButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(DeviceNumberEdit1.Text) > 127)
            {
                MessageBox.Show("لطفا مقداری کمتر از 128 انتخاب کنید");
                return;
            }
            SMS_Select_Device(Convert.ToInt16(DeviceNumberEdit1.Text));
        }

        private void WaitBitBtn_Click(object sender, EventArgs e)
        {
            Res_AT_Delay(Convert.ToInt32(mmEdit.Text));
        }

        private void SendATBitBtn_Click(object sender, EventArgs e)
        {                     
            ATResponseEdit.Clear();
            ResLenEdit.Text = "";
            int AT_Length = 0;
            string AT_Input = "";
            string Result = "";
            AT_Input = ATEdit.Text;
            GSM_Send_AT(AT_Input, ref AT_Length, out Result);
            ATResponseEdit.AppendText(Result);
            ResLenEdit.Text = AT_Length.ToString();
        }

        private void LastBufBitBtn_Click(object sender, EventArgs e)
        {
            LastBufEdit.Text = Last_Buf_Index().ToString();
        }

        private void BufClearBitBtn_Click(object sender, EventArgs e)
        {
            GSMSMSEdit.Clear();
            Clear_Buf();
        }

        private void GSMSMSEdit_DoubleClick(object sender, EventArgs e)
        {
            GSMSMSEdit.Clear();
        }

        private void GSMSMSBitBtn_Click(object sender, EventArgs e)
        {
            int GSM_CMD = 0, GSM_Len = 0;
            string GSM_Output;
            GSM_CMD = BufComboBox.SelectedIndex + 1;
            GSM_Len = 0;
            GSM_MSG(out GSM_Output,ref GSM_CMD, ref GSM_Len);
            LenLabeledEdit.Text = GSM_Len.ToString();
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            int GSM_CMD;
            GSM_CMD = Last_Buf_Index();
            if (GSM_CMD > 0)
            {
                string GSM_Output;
                int GSM_len = 0;
                GSM_MSG(out GSM_Output, ref GSM_CMD, ref GSM_len);
                if (GSM_Output.Length > 0) 
                 GSMSMSEdit.AppendText(GSM_Output);
                Clear_Buf();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            NumberOfDevicesEdit.Text = SMS_Device_Count().ToString(); 
            SMS_Select_Device(Convert.ToInt16(DeviceNumberEdit1.Text));
            timer4.Enabled = true;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {


        }

        private void button_SendSMS_Click(object sender, EventArgs e)
        {
            if (SMS_Text_Edit.Text.Trim().Length == 0)
            {
                MessageBox.Show("لطفا متن پیاک را وارد کنید");
                SMS_Text_Edit.Focus();
                return;
            }

            if (ValidityComboBox.SelectedItem == null)
            {
                MessageBox.Show("لطفا مدت اعتبار پیام را مشخص کنید");
                ValidityComboBox.Focus();
                return ;
            }

            string Phone_NO, SMS_Center, Result;
            bool Request_Delivery_Report;
            int Send_Interval, Retry_Times, SMS_Validity, SMS_Reference, i, j, k, l;

            Phone_NO = S_Code_SMS_Edit.Text + S_Mob_Edit.Text;
            //SMS_Text := smstextedit.Text;
            Request_Delivery_Report = DelRepCheckBox.Checked;
            Send_Interval = int.Parse(Delay2PartEdit.Text);
            Retry_Times = int.Parse(RetryEdit.Text);
            SMS_Validity = ValidityComboBox.SelectedIndex + 1;
            SMS_Reference = 0;
            SMS_Center = SmscenterEdit.Text;//'+9891100500';
            Edit2.Text = "0";
            Edit3.Text = "0";
            k = 0;
            l = 0;
            for (j = 1; j <= int.Parse(Edit1.Text); j++)
            {
                if (Chbox_StopSend.Checked == true)
                    break;
                StatusBar1.Text = "";

                S_SMS3(out Result, Phone_NO, SMS_Text_Edit.Text, Request_Delivery_Report, Convert.ToInt16(Send_Interval),
                       Convert.ToInt16(Retry_Times), Convert.ToInt16(SMS_Validity), Convert.ToInt16(SMS_Reference), SMS_Center);
                Send_ReferenceEdit.Text = Result;
                if (!string.IsNullOrEmpty(Result))
                {
                    if ((Result.Length) > 0)
                    {
                        StatusBar1.Text = "با موفقيت انجام شد";
                        l++;
                        Edit2.Text = (l.ToString());
                    }
                }
                else
                {
                    StatusBar1.Text = "انجام نشد";
                    k++;
                    Edit3.Text = (k.ToString());
                }
            }
        }

        private void BitBtn_R_SMS_Error_Code_Click(object sender, EventArgs e)
        {
            string Error_Code;
            Send_SMS_Error_Code(out Error_Code);
            StatusBar1.Text = Error_Code;
        }

        private void BitBtn_SendText_Click(object sender, EventArgs e)
        {
            S_RefEdit.Text = "";
            if (Send_Text_SMS(false, phonenoedit1.Text, phonenoedit1.Text, smstextedit.Text))
            {
                StatusBar1.Text = "با موفقیت انجام شد";
                string Result;
                R_SMS_Ref(out Result);
                S_RefEdit.Text = Result;
            }
            else
                StatusBar1.Text = "انجام نشد";
        }

        private void BitBtn_SMSGS_Click(object sender, EventArgs e)
        {
          bool Request_Delivery_Report;
          int  Send_Interval, Retry_Times, SMS_Validity;
          string SMS_Center;
          int SMS_NO_Change_Sim;
          Request_Delivery_Report = CheckBox_DSGR.Checked;
          Send_Interval = Convert.ToInt32(LabeledEditSMSGDP.Text);
          Retry_Times = Convert.ToInt32(LabeledEdit_SMSGTry.Text);
          SMS_Validity = ComboBox_validtime.SelectedIndex + 1;
          SMS_Center = LabeledEdit_SMSC.Text; // '+9891100500';
          SMS_NO_Change_Sim = Convert.ToInt32(LabeledEdit_CSim.Text);
          Group_SMS_Setting(Request_Delivery_Report, SMS_Validity,SMS_NO_Change_Sim, Retry_Times, Send_Interval, SMS_Center);
        }

        private void BitBtn_Add_Group_SMS_Click(object sender, EventArgs e)
        {
            string SMS_Context = "";
            int i;
            string Phone_NO;
            for (i = 0; i < SMS_Text_Edit.Lines.Count(); i++)
            {
                SMS_Context += SMS_Text_Edit.Lines[i];
                if (i < (SMS_Text_Edit.Lines.Count() - 1))
                    SMS_Context += "/r";
            }
            Phone_NO = S_Code_SMS_Edit.Text + S_Mob_Edit.Text;
            Add_Group_SMS_Buffer(Phone_NO, SMS_Context);
        }

        private void BitBtn_Delete_All_Click(object sender, EventArgs e)
        {
            SMS_Buf_Clear(true);
        }

        private void BitBtn_Start_Group_Click(object sender, EventArgs e)
        {
            SMS_Buf_Start(true);
        }

        private void BitBtnAll_SMS_Buf_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(Get_SMS_Buf_Indx()));
        }

        private void BitBtn_Stop_Group_Click(object sender, EventArgs e)
        {
            SMS_Buf_Start(false);
        }

        private void BitBtn_S_SMS_NO_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(Get_SMS_Buf_Sended()));
        }

        private void BitBtn_Pause_Group_Click(object sender, EventArgs e)
        {
            SMS_Buf_Pause();
        }

        private void BitBtn_Show_GSStatus_Click(object sender, EventArgs e)
        {
            bool Send_Done, SMS_Deliverd;

            Send_Done = false;
            SMS_Deliverd = Get_SMS_Buf_Status(Convert.ToInt32(LabeledEdit_SGSSN.Text),ref Send_Done);
            CheckBox_Send_Done.Checked = Send_Done;
            CheckBox_SMS_Deliverd.Checked = SMS_Deliverd;
        }

        private void SMSActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Active_New_SMS_Event(SMSActiveCheckBox.Checked))
                MessageBox.Show("Set Successful");
        }

        private void ChecknewsmsCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            Timer1.Enabled = ChecknewsmsCheckBox.Checked;
        }

        private void ReceiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void R_MemoryBitBtn_Click(object sender, EventArgs e)
        {
            SMS_Space_Struct SMS_Space;
            Get_SMS_Space(out SMS_Space);
            if (SMS_Space.Result)
            {
                FreeMemEdit.Text = Convert.ToString(SMS_Space.Free_Space);
                AllMemEdit.Text = Convert.ToString(SMS_Space.Total_Size);
                MessageBox.Show("با موفقیت انجام شد");
            }
            else
                MessageBox.Show("خطا درانجام");
        }

        private void RedSMSNOBitBtn_Click(object sender, EventArgs e)
        {
            ReadNOSMSEdit.Text = Get_SMS_NO().ToString();
        }

        private void DelSMSBitBtn_Click(object sender, EventArgs e)
        {
            if (SMS_Delete(Convert.ToInt16(DelSMSEdit.Text), DelType_ComboBox.SelectedIndex))
                StatusBar1.Items[0].Text = "با موفقیت انجام شد";
            else
                StatusBar1.Items[0].Text = "انجام نشد";
        }

        private void SMSBtn3BitBtn_Click(object sender, EventArgs e)
        {
            Boolean PDU;
            int Indx;
            
            string Result, SMS_Center, SMS_Type, Tel_Number, Time_stamp, S_Discharge, SMS_Text, TP_PID, TP_DCS, TP_VP, TP_ST, S_Reference;
            int iTP_ST, TP_Indx;
            string all_Part, part_NO;

            PDU = true;
            Indx = Convert.ToInt32(smsindxedit.Text);
            R_SMS4(out Result, PDU, Indx, out SMS_Center, out SMS_Type, out Tel_Number, out Time_stamp,
                                          out S_Discharge, out SMS_Text, out TP_PID, out TP_DCS, out TP_VP, out TP_ST,
                                          out S_Reference, out all_Part, out part_NO);

            iTP_ST = Convert.ToInt32(TP_ST);
            TP_Indx = -1;
            switch (iTP_ST)
            {
                case 0x00:                    TP_Indx = 0;                    break;
                case 0x01:                    TP_Indx = 1;                    break;
                case 0x02:                    TP_Indx = 2;                    break;
                case 0x20:                    TP_Indx = 3;                    break;
                case 0x21:                    TP_Indx = 4;                    break;
                case 0x22:                    TP_Indx = 5;                    break;
                case 0x23:                    TP_Indx = 6;                    break;
                case 0x24:                    TP_Indx = 7;                    break;
                case 0x25:                    TP_Indx = 8;                    break;
                case 0x40:                    TP_Indx = 9;                    break;
                case 0x41:                    TP_Indx = 10;                   break;
                case 0x42:                    TP_Indx = 11;                   break;
                case 0x43:                    TP_Indx = 12;                   break;
                case 0x44:                    TP_Indx = 13;                   break;
                case 0x45:                    TP_Indx = 14;                   break;
                case 0x46:                    TP_Indx = 15;                   break;
                case 0x47:                    TP_Indx = 16;                   break;
                case 0x48:                    TP_Indx = 17;                   break;
                case 0x49:                    TP_Indx = 18;                   break;
            }
            TP_STComboBox.SelectedIndex = TP_Indx;
            TP_PIDEdit.Text = TP_PID;
            TP_DCSEdit.Text = TP_DCS;
            TP_VPEdit.Text = TP_VP;
            S_ReferenceEdit.Text = S_Reference;
            smstypeedit.Text = SMS_Type;
            mobedit.Text = Tel_Number;
            smscenter.Text = SMS_Center;
            Time_stampEdit.Text = Time_stamp;
            S_DischargeEdit.Text = S_Discharge;
            All_PartEdit.Text = all_Part;
            Part_NOEdit.Text = part_NO;
            if (SMS_Text != null)
            {
                readsmstextedit.AppendText(SMS_Text);
                readsmstextedit.ScrollToCaret();
            }
        }

        private void Button_AllSMSCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Total_Oflline_SMS_NO().ToString());
        }

        private void Button_R_All_SMS_Click(object sender, EventArgs e)
        {
            int SMS_CNT,I,j;
            int All_Part,Part_NO;
            string SMS_Text;
            int SROW;
            SMS_CNT = Total_Oflline_SMS_NO();
            SROW = 1;
            dataGridView1.RowCount = 1;
            Part_NO = 0;
            All_Part    = 0;             
            SMS_Text    = "";
            OffLine_SMS_Struct OffLine_SMS;
            for (I = 1; I <= SMS_CNT; I++)
            {
                Show_Oflline_SMS(out OffLine_SMS, I);

                if (OffLine_SMS.Result)              
                {
                    j = 0;
                    string[] row = new string[] { I.ToString(), OffLine_SMS.SMS_Center, OffLine_SMS.SMS_Type, OffLine_SMS.Tel_Number, OffLine_SMS.Time_stamp,
                                           OffLine_SMS.S_Discharge, OffLine_SMS.TP_PID, OffLine_SMS.TP_DCS, OffLine_SMS.TP_VP, OffLine_SMS.TP_ST, OffLine_SMS.S_Reference, 
                                           All_Part.ToString(), Part_NO.ToString(), SMS_Text };
                    //dataGridView1.RowCount = SROW + 1;
                    dataGridView1.Rows.Add(row);
                    richTextBox1.Text += ("SMS NO" + SROW.ToString() + "=" + SMS_Text);
                    SROW++;
                }
            }
        }

        private void Button_ClearAllSMS_Click(object sender, EventArgs e)
        {
            if (Clear_Oflline_SMS_NO())
                MessageBox.Show("با موفقیت انجام شد");
            else
                MessageBox.Show("خطا در انجام");
        }

        private void Button_ASMSS_Click(object sender, EventArgs e)
        {
            CheckBox_ASMSC.Checked = G_Offline_SMS_Active();
        }


        private void SMS_CenterBitBtn_Click(object sender, EventArgs e)
        {
            string SMS_Center;
            R_SMS_Center(out SMS_Center);
            SMS_CenterEdit.Text = SMS_Center;
        }

        private void CSMS_CenterBitBtn_Click(object sender, EventArgs e)
        {
            Change_SMS_Center(CSMS_CenterEdit.Text);
        }

        private void D_NO_BitBtn_Click(object sender, EventArgs e)
        {
            StatusBar1.Text = "";
            if ((Convert.ToInt16(D_NO_Edit.Text) < 0) || (Convert.ToInt16(D_NO_Edit.Text) > 127))
            {
                MessageBox.Show("لطفا مقداری بین 0 تا 127 را انتخاب کنید");
                return;
            }
                if (GSM_Set_Device_NO(Convert.ToInt16(D_NO_Edit.Text)))
                StatusBar1.Text = "با موفقيت انجام شد";
            else
                StatusBar1.Text = "انجام نشد";
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            D_NO_Edit.Text = GSM_Get_Device_NO().ToString();
        }

        private void SetCharTypeButton_Click(object sender, EventArgs e)
        {
            StatusBar1.Text = "";
            if (SMS_Char_Mode(Convert.ToByte(Set_CharType_ComboBox.SelectedIndex + 1)))
                StatusBar1.Text = "با موفقیت انجام شد";
            else
                StatusBar1.Text = "انجام نشد";
        }

        private void BitBtn_ActiveCID_Click(object sender, EventArgs e)
        {
            if (CallerID_Enable(true))
                MessageBox.Show("با موفقیت انجام شد");
            else
                MessageBox.Show("خطا درانجام");
        }

        private void BitBtn_DeactiveCID_Click(object sender, EventArgs e)
        {
            if (CallerID_Enable(false))
                MessageBox.Show("با موفقیت انجام شد");
            else
                MessageBox.Show("خطا درانجام");
        }

        private void DiBitBtnal_Click(object sender, EventArgs e)
        {           
            GSM_Dial_Struct GsmDial;
            GSM_Dial_NO(out GsmDial, Dial_Code_Edit.Text, DialEdit.Text);
            if (GsmDial.Result)
                StatusBar1.Text = "با موفقيت انجام شد";
            else
                StatusBar1.Text = "انجام نشد";

            StatusBar1.Text += "  -  " + GsmDial.Res_MSG;
        }

        private void BitBtnAnswer_Click(object sender, EventArgs e)
        {
            if (GSM_Answer_Call())
                MessageBox.Show("با موفقیت انجام شد");
            else
                MessageBox.Show("خطا درانجام");
        }

        private void BitBtnDisconnect_Click(object sender, EventArgs e)
        {
            if (Disconnect_Voice_Call())
                MessageBox.Show("با موفقیت انجام شد");
            else
                MessageBox.Show("خطا درانجام");
        }

        private void Modem_ConnectBitBtn_Click(object sender, EventArgs e)
        {
            ModemConnectCheckBox.Checked = GSM_Test_Connect();
        }

        private void Modem_ReadyBitBtn_Click(object sender, EventArgs e)
        {            
            ModemReadyCheckBox.Checked = GSM_Ready();
        }

        private void IMEIBitBtn_Click(object sender, EventArgs e)
        {
            string IMEI;
            R_IMEI(out IMEI);
            IMEIEdit.Text = IMEI;
        }

        private void CIMIBitBtn_Click(object sender, EventArgs e)
        {
            string NMobileID;
            R_Natttional_Mobile_ID(out NMobileID);
            CIMIEdit.Text = NMobileID;
        }

        private void BitBtn_SetDateTime_Click(object sender, EventArgs e)
        {
            if (Set_GSM_Date_Time(Convert.ToInt16(yearedit.Text), Convert.ToInt16(monthedit.Text),
                                        Convert.ToInt16(dayedit.Text), Convert.ToInt16(houredit.Text),
                                        Convert.ToInt16(minedit.Text), Convert.ToInt16(secedit.Text)))
                StatusBar1.Text = "با موفقيت انجام شد";
            else
                StatusBar1.Text = "انجام نشد";
        }

        private void BitBtn_GetDate_Click(object sender, EventArgs e)
        {
            string DateTime;
            R_GSM_Date_Time(out DateTime);
            GDateTimeTextBox.Text = DateTime;
        }

        private void BitBtn_Getstatus_Click(object sender, EventArgs e)
        {
            PowerOnCheckBox.Checked = R_GSM_POW();
        }

        private void BitBtn_ReadGSMstatus_Click(object sender, EventArgs e)
        {
            GSM_Message_Struct Gms_Msg;
            Get_GSM_Message(out Gms_Msg);
            MessageBox.Show("Error code is :" + Gms_Msg.Result.ToString() + " - " + Gms_Msg.Message_Text);
        }

        private void SimComboBoxBitBtn_Click(object sender, EventArgs e)
        {
            string SimPin;
            CIMIEdit.Text = "";
            R_SIM_PIN(out SimPin);
            int i = Convert.ToInt32(SimPin);
            if (i > 0)
              SimComboBox.SelectedIndex = i - 1;
        }

        private void SelectedNetBitBtn_Click(object sender, EventArgs e)
        {
            string NetWorkName;
            Selected_Network(out NetWorkName);
            NetSelectEdit.Text = NetWorkName;
        }

        private void SIM_IDBitBtn_Click(object sender, EventArgs e)
        {
            string SimID;
            R_SIM_ID(out SimID);
            SIM_IDEdit.Text = SimID;
        }

        private void SignalBitBtn_Click(object sender, EventArgs e)
        {
            string Signal;
            GSM_Signal(out Signal);
            SigQualityEdit.Text = Signal + "%";
        }

        private void BitBtn_SelNetwork_Click(object sender, EventArgs e)
        {
            if (Select_SIM_Network())
              MessageBox.Show("با موفقیت انجام شد");
            else
               MessageBox.Show("خطا درانجام");
        }

        private void PINBitBtn_Click(object sender, EventArgs e)
        {
            if (Insert_PIN(PINEdit.Text))
                MessageBox.Show("با موفقیت انجام شد");
            else
                MessageBox.Show("خطا درانجام");
        }

        private void BitBtn_Shargeonoff_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox_ActiveAutoSMS_CheckedChanged(object sender, EventArgs e)
        {
            Offline_SMS_Active(CheckBox_ActiveAutoSMS.Checked);
        }

        private void CheckBox_R_Buffer_CheckedChanged(object sender, EventArgs e)
        {
            timer2.Enabled = Chbox_StopSend.Checked;
        }

        private void MS_I1_OnGSMEvent(object sender, EventArgs e)
        {
            GSM_Message_Struct Gms_Msg;
            Get_GSM_Message(out Gms_Msg);
            M_C = Gms_Msg.Result;          
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            //timer4.Enabled = false;
            string CallNumber;
            if (M_C >= 0)
            {
                GSMSMSEdit.Text += Message_Text + "  M_Code:" + Convert.ToString(M_C)+ " \r\n";
                CallIn_Number(out CallNumber);
                if (M_C == 0)
                    GSMSMSEdit.Text += "Modem Ready Now \r\n";
                else if (M_C == 1)
                    GSMSMSEdit.Text += "Modem Power Off Now \r\n ";
                else if (M_C == 2)
                    GSMSMSEdit.Text += "Modem Startup Now \r\n ";
                else if (M_C == 3)
                    GSMSMSEdit.Text += "OK Dial Number \r\n ";
                else if (M_C == 4)
                    GSMSMSEdit.Text += "NO DIAL TONE \r\n ";
                else if (M_C == 5)
                    GSMSMSEdit.Text += "Number is Busy Now \r\n ";
                else if (M_C == 6)
                    GSMSMSEdit.Text += "Number NO CARRIER \r\n ";
                else if (M_C == 7)
                    GSMSMSEdit.Text += "Number NO ANSWER \r\n ";
                else if (M_C == 8)
                    GSMSMSEdit.Text += "New SMS Recieve:" + Message_Text + "\r\n ";
                else if (M_C == 9)  // Ring
                    GSMSMSEdit.Text += Message_Text + "\r\n ";
                else if (M_C == 10) // Device Connect
                    GSMSMSEdit.Text += "SMS_BAN is Connect:" + Message_Text + "\r\n ";
                else if (M_C == 11) // C_ID
                 GSMSMSEdit.Text += "TelNumber:" + CallNumber + " Date:" +
                    Convert.ToString(DateTime.Now) + "\r\n ";
                else if (M_C == 12)
                    GSMSMSEdit.Text += "Modem Power ON Now \r\n ";
                else if (M_C == 13)
                {
                    GSMSMSEdit.Text += "New SMS Saved. Total Saved SMS is " + Message_Text + "\r\n ";
                    timer3.Enabled = true;
                }
                else if (M_C == 14)
                    GSMSMSEdit.Text += "Sent 1 Part SMS Reference:" + Message_Text + "\r\n ";
                else if (M_C == 15) // 'No Response was received from the GSM side'
                    GSMSMSEdit.Text += "Failed to send sms(" + Message_Text + ")\r\n ";
                else if (M_C == 16) // 'No Reference was received from the BTS \r\n ";
                    GSMSMSEdit.Text += "Failed to send sms(" + Message_Text + ") \r\n ";
                else if (M_C == 17) // 'No Reference was received from the BTS \r\n ";
                    GSMSMSEdit.Text += "Send 1 Part SMS Successful(" + Message_Text + " \r\n ";
                else if (M_C == 18) // 'No Reference was received from the BTS'
                    GSMSMSEdit.Text += "Send All Part SMS Successful(" + Message_Text + ") \r\n ";

                else
                {
                    GSMSMSEdit.Text += "Message Code:" + Convert.ToString(M_C) + " Message:" + Message_Text + "\r\n ";
                }
                M_C = -1;
            }
        }

        private void Chbox_SelectByNum_CheckedChanged(object sender, EventArgs e)
        {
            if (Chbox_SelectByNum.Checked == true)
            {
                Btn_SelectByNum.Enabled = true;
                DeviceNumberEdit1.Enabled = true;

                Btn_SelectByIndex.Enabled = false;
                Combo_DeviceIndex.Enabled = false;

                DeviceNumberEdit1.Focus();
            }
            else
            {
                Btn_SelectByNum.Enabled = false;
                DeviceNumberEdit1.Enabled = false;

                Btn_SelectByIndex.Enabled = true;
                Combo_DeviceIndex.Enabled = true;

                Combo_DeviceIndex.Focus();
            }
        }

        private void Lbl_DeviceNum_Click(object sender, EventArgs e)
        {
            Chbox_SelectByNum.Checked = true;
        }

        private void Lbl_DeviceIndex_Click(object sender, EventArgs e)
        {
            Chbox_SelectByIndex.Checked = true;
        }

        private void Btn_SelectByIndex_Click(object sender, EventArgs e)
        {
            if (Combo_DeviceIndex.SelectedItem == null)
            {
                MessageBox.Show("لطفا یک مقدار را انتخاب کنید");
                return;
            }

            SMS_SelectDeicve_ByIndex(Convert.ToInt16(Combo_DeviceIndex.SelectedItem.ToString()));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

		private void S_Mob_Edit_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
