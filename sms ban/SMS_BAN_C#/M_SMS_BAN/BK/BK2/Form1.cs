using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M_SMS_BAN
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumberOfDevicesEdit.Text = (MS_I1.SMS_Device_Count()).ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {

            SelectDeviceEdit.Text = MS_I1.SMS_Select_Device(Int16.Parse(DeviceNumberEdit1.Text));
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string Res_MSG = " ";
            if (MS_I1.GSM_Dial_NO(Dial_Code_Edit.Text, DialEdit.Text, ref Res_MSG))
                StatusBar1.Text = "با موفقیت انجام شد" + "-" + Res_MSG;
            else
                StatusBar1.Text = "انجام نشد";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MS_I1.Disconnect_Voice_Call();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Boolean b;
            b = MS_I1.Active_New_SMS_Event(ChecknewsmsCheckBox.Checked);
            if (b)
                MessageBox.Show("Set Successful");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            MS_I1.SMS_Battery_Calib(CalibLabeledEdit.Text);
        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void groupBox21_Enter(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox67_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {

        }

        private void label65_Click(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {
            int Response_Len;
            string Ret_Str;
            ATResponseEdit.Clear();
            ResLenEdit.Text = "";
            Response_Len = 0;
            Ret_Str = MS_I1.GSM_Send_AT(ATEdit.Text, ref Response_Len);
            ATResponseEdit.AppendText(Ret_Str);
            ResLenEdit.Text = Convert.ToString(Response_Len);

        }

        private void button42_Click(object sender, EventArgs e)
        {
            MS_I1.Res_AT_Delay(int.Parse(mmEdit.Text));
        }

        private void label64_Click(object sender, EventArgs e)
        {

        }

        private void textBox65_TextChanged(object sender, EventArgs e)
        {

        }

        private void label63_Click(object sender, EventArgs e)
        {

        }

        private void textBox64_TextChanged(object sender, EventArgs e)
        {

        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            SigQualityEdit.Text = MS_I1.GSM_Signal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MS_I1.Visible := False;
            SCMD_DataEdit.Text = MS_I1.SMS_Dev_INFO();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoftVerEdit1.Text = MS_I1.SMS_Soft_Ver();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MS_I1.GSM_Answer_Call();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (MS_I1.Set_GSM_Date_Time(Convert.ToInt16(yearedit.Text), Convert.ToInt16(monthedit.Text),
               Convert.ToInt16(dayedit.Text), Convert.ToInt16(houredit.Text), Convert.ToInt16(minedit.Text),
               Convert.ToInt16(secedit.Text)))
                StatusBar1.Text = "با موفقیت انجام شد";
            else
                StatusBar1.Text = "انجام نشد";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            PowerOnCheckBox.Checked = MS_I1.R_GSM_POW();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            MS_I1.GSM_ON();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            MS_I1.GSM_OFF();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (MS_I1.SMS_PDU_Mode(PDURadioButton.Checked))
                StatusBar1.Text = "با موفقيت انجام شد";
            else
                StatusBar1.Text = "انجام نشد";

        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (MS_I1.SMS_Delete(Convert.ToInt16(DelSMSEdit.Text), DelType_ComboBox.SelectedIndex))
                StatusBar1.Text = "با موفقیت انجام شد";
            else
                StatusBar1.Text = "انجام نشد";

        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            Boolean PDU;
            int Indx;
            string SMS_Center, SMS_Type, Tel_Number, Time_stamp, S_Discharge, SMS_Text, TP_PID, TP_DCS, TP_VP, TP_ST, S_Reference;
            SMS_Center = "";
            SMS_Type = "";
            Tel_Number = "";
            Time_stamp = "";
            S_Discharge = "";
            SMS_Text = "";
            TP_PID = "";
            TP_DCS = "";
            TP_VP = "";
            TP_ST = "";
            S_Reference = "";

            int iTP_ST, TP_Indx;
            string Res;
            Res = "";
            PDU = true;
            Indx = Convert.ToInt32(smsindxedit.Text);
            Res = MS_I1.R_SMS3(PDU, Indx, ref SMS_Center, ref SMS_Type, ref Tel_Number, ref Time_stamp,
                                          ref S_Discharge, ref SMS_Text, ref TP_PID, ref TP_DCS, ref TP_VP, ref TP_ST,
                                          ref S_Reference);
            iTP_ST = Convert.ToInt32(TP_ST);
            TP_Indx = -1;
            switch (iTP_ST)
            {
                case 0:
                    TP_Indx = 0;
                    break;
                case 0x01:
                    TP_Indx = 1;
                    break;
                case 0x02:
                    TP_Indx = 2;
                    break;
                case 0x20:
                    TP_Indx = 3;
                    break;
                case 0x21:
                    TP_Indx = 4;
                    break;
                case 0x22:
                    TP_Indx = 5;
                    break;
                case 0x23:
                    TP_Indx = 6;
                    break;
                case 0x24:
                    TP_Indx = 7;
                    break;
                case 0x25:
                    TP_Indx = 8;
                    break;
                case 0x40:
                    TP_Indx = 9;
                    break;

                case 0x41:
                    TP_Indx = 10;
                    break;
                case 0x42:
                    TP_Indx = 11;
                    break;
                case 0x43:
                    TP_Indx = 12;
                    break;
                case 0x44:
                    TP_Indx = 13;
                    break;
                case 0x45:
                    TP_Indx = 14;
                    break;
                case 0x46:
                    TP_Indx = 15;
                    break;
                case 0x47:
                    TP_Indx = 16;
                    break;
                case 0x48:
                    TP_Indx = 17;
                    break;
                case 0x49:
                    TP_Indx = 18;
                    break;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            ReadNOSMSEdit.Text = (MS_I1.Get_SMS_NO().ToString());
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            string s, s2;
            int i, j, k, l;
            {
                Edit2.Text = "0";
                Edit3.Text = "0";
                k = 0;
                l = 0;
                i = int.Parse(Edit1.Text);
                for (j = 0; j<i;j++)
                {

                    if (CheckBox1.Checked == false)
                        break;
                    StatusBar1.Text = "";
                    //RichEdit1.Lines.Add('D_C:'+IntToStr(MS_I1.GSM_Get_Device_NO()));
                    s = "";
                    for (i = 0; i<SMS_Text_Edit.Lines.Count() ;i++ )
                    {
                        s = s + SMS_Text_Edit.Lines[i];
                        if (i < (SMS_Text_Edit.Lines.Count() - 1))
                            s = s + "\n";
                    }
                    s2= MS_I1.Send_SMS_PDU2(S_Code_SMS_Edit.Text, S_Mob_Edit.Text, s);
                    Send_ReferenceEdit.Text = s2;
                    if (s2 != null)
                    {
                        StatusBar1.Text = "با موفقيت انجام شد";
                        l++;
                        Edit2.Text = (l.ToString());
                    }
                    else
                    {
                        StatusBar1.Text = "انجام نشد";
                        k++;
                        Edit3.Text = (k.ToString());
                    }
                }

            }

        }

        private void button28_Click(object sender, EventArgs e)
        {
            GDateTimeTextBox.Text = MS_I1.R_GSM_Date_Time();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            LastBufEdit.Text = Convert.ToString(MS_I1.Last_Buf_Index());
        }

        private void button34_Click(object sender, EventArgs e)
        {
            GSMSMSEdit.Clear();
            MS_I1.Clear_Buf();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            int CMD, Len;
            CMD = BufComboBox.SelectedIndex + 1;
            Len = 0;
            GSMSMSEdit.Text = MS_I1.GSM_MSG(ref CMD, ref Len);
            LenLabeledEdit.Text = Len.ToString();

        }

        private void button40_Click(object sender, EventArgs e)
        {
            short Status = 0;

            if (MS_I1.SMS_Bat_charging(ref Status))
            {
                StatusBar1.Text = "با موفقیت انجام شد";
                if (Status == 1)
                    RadioButton5.Checked = true;
                if (Status == 0)
                    RadioButton6.Checked = true;
            }
            else
                StatusBar1.Text = "انجام نشد";
        }

        private void button41_Click(object sender, EventArgs e)
        {
            bool res;
            int Percent = 0, Voltage = 0;
            res = MS_I1.SMS_Battery(ref Percent, ref Voltage);
            if (res == true)
                StatusBar1.Text = "با موفقیت انجام شد";
            else
                StatusBar1.Text = "انجام نشد";
            LabeledEdit3.Text = Convert.ToString(Percent);
            LabeledEdit2.Text = Convert.ToString(Voltage);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Timer1.Enabled = ChecknewsmsCheckBox.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int Indx_from=0;
            int Indx_To=0;
            ReceiveCheckBox.Checked = MS_I1.Recieved_New_SMS(ref Indx_from, ref Indx_To);
            if(ReceiveCheckBox.Checked)
            { 
                Sms_FromEdit.Text = Indx_from.ToString();
                Sms_ToEdit.Text = Indx_To.ToString();
             }
         }


        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MS_I1.Ad_Pass(AdminLabeledEdit.Text);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Charge_ON_CheckBox.Checked)
       MS_I1.Set_Chage(1);
      else
                MS_I1.Set_Chage(0);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (MS_I1.SMS_Set_Baud(BaudComboBox.SelectedIndex))
             StatusBar1.Text = "با موفقيت انجام شد";
            else
                StatusBar1.Text = "انجام نشد";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (MS_I1.GSM_Set_Baud(BaudComboBox.SelectedIndex))
                StatusBar1.Text = "با موفقيت انجام شد";
            else
                StatusBar1.Text = "انجام نشد";
        }

        private void MS_I1_Enter(object sender, EventArgs e)
        {

        }

        private void SCMD_DataEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChecknewsmsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Timer1.Enabled = ChecknewsmsCheckBox.Checked;
        }

        private void Sms_FromEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void S_Code_SMS_Edit_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DialEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            ModemConnectCheckBox.Checked = MS_I1.GSM_Test_Connect();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            ModemReadyCheckBox.Checked = MS_I1.GSM_Ready();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            IMEIEdit.Text = MS_I1.R_IMEI();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            CIMIEdit.Text = MS_I1.R_Natttional_Mobile_ID();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            SimComboBox.SelectedIndex = int.Parse(MS_I1.R_SIM_PIN()) - 1;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            SimComboBox.SelectedIndex = int.Parse(MS_I1.R_SIM_PIN()) - 1;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            MS_I1.Insert_PIN(PINEdit.Text);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            SIM_IDEdit.Text = MS_I1.R_SIM_ID();
        }

        private void LabeledEdit2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label53_Click_1(object sender, EventArgs e)
        {

        }

        private void ModemConnectCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ValidityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LabeledEdit3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label61_Click(object sender, EventArgs e)
        {

        }

        private void label55_Click(object sender, EventArgs e)
        {

        }


        private void SmscenterEdit_TextChanged(object sender, EventArgs e)
        {
            timer2.Enabled = checkBox2.Checked;
        }

        private void label71_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label69_Click(object sender, EventArgs e)
        {

        }

        private void label73_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click_1(object sender, EventArgs e)
        {

        }

        private void GSMOFFButton_Click(object sender, EventArgs e)
        {
            MS_I1.GSM_OFF();
        }

        private void BitBtn8_Click(object sender, EventArgs e)
        {
            
        }

        private void GSMONButton_Click(object sender, EventArgs e)
        {
            MS_I1.GSM_ON();
        }

 

        private void BitBtn_Send_SMS_Type_Click(object sender, EventArgs e)
        {
            StatusBar1.Text = "";
            if (MS_I1.SMS_PDU_Mode(PDURadioButton.Checked))
                StatusBar1.Items[0].Text = "با موفقيت انجام شد";
            else
                StatusBar1.Items[0].Text = "انجام نشد";
        }

        private void SendCMDButton_Click(object sender, EventArgs e)
        {
            string st;
            SCMD_DataEdit.Text = "";
            st = MS_I1.SMS_Dev_INFO();
            SCMD_DataEdit.Text = st; 
        }

        private void SoftVerutton1_Click(object sender, EventArgs e)
        {
            SoftVerEdit1.Text = "";
            SoftVerEdit1.Text = MS_I1.SMS_Soft_Ver();
        }

        private void SearchDevicesButton_Click(object sender, EventArgs e)
        {
            NumberOfDevicesEdit.Text = Convert.ToString(MS_I1.SMS_Device_Count());
        }

        private void SelectDeviceButton_Click(object sender, EventArgs e)
        {
            SelectDeviceEdit.Text = MS_I1.SMS_Select_Device(Convert.ToInt16(DeviceNumberEdit1.Text));
        }

        private void WaitBitBtn_Click(object sender, EventArgs e)
        {
            MS_I1.Res_AT_Delay(Convert.ToInt32(mmEdit.Text));
        }

        private void SendATBitBtn_Click(object sender, EventArgs e)
        {
            int Response_Len;
            string Ret_Str;
            ATResponseEdit.Clear();
            ResLenEdit.Text = "";
            Response_Len = 0;
            Ret_Str = MS_I1.GSM_Send_AT(ATEdit.Text, ref Response_Len);
            ATResponseEdit.AppendText(Ret_Str);
            ResLenEdit.Text = Convert.ToString(Response_Len);
        }

        private void LastBufBitBtn_Click(object sender, EventArgs e)
        {
            LastBufEdit.Text = Convert.ToString(MS_I1.Last_Buf_Index());
        }

        private void BufClearBitBtn_Click(object sender, EventArgs e)
        {
            GSMSMSEdit.Clear();
            MS_I1.Clear_Buf();
        }

        private void GSMSMSEdit_DoubleClick(object sender, EventArgs e)
        {
            GSMSMSEdit.Clear();
        }

        private void GSMSMSBitBtn_Click(object sender, EventArgs e)
        {
            int CMD, Len;
            CMD = BufComboBox.SelectedIndex + 1;
            Len = 0;
            GSMSMSEdit.Text = MS_I1.GSM_MSG(ref CMD, ref Len);
            LenLabeledEdit.Text = Len.ToString();
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int cMD, len;
           cMD = MS_I1.Last_Buf_Index();
            if (cMD > 0)
            {
                len = 0;
                GSMSMSEdit.AppendText(MS_I1.GSM_MSG(ref cMD, ref len));
                MS_I1.Clear_Buf();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            NumberOfDevicesEdit.Text = Convert.ToString(MS_I1.SMS_Device_Count()); 
            SelectDeviceEdit.Text = MS_I1.SMS_Select_Device(Convert.ToInt16(DeviceNumberEdit1.Text));
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {


        }

        private void button_SendSMS_Click(object sender, EventArgs e)
        {
            string Phone_NO, SMS_Center, s, s2;
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
            for (j = 1; j < int.Parse(Edit1.Text); j++)
            {

                if (CheckBox1.Checked == false)
                    break;
                StatusBar1.Text = "";
                //RichEdit1.Lines.Add('D_C:'+IntToStr(MS_I1.GSM_Get_Device_NO()));
                s = "";
                for (i = 0; i < SMS_Text_Edit.Lines.Count() - 1; i++)
                {
                    s = s + SMS_Text_Edit.Lines[i];
                    if (i < (SMS_Text_Edit.Lines.Count() - 1))
                        s = s + "/r";
                }
                s2 = MS_I1.S_SMS3(Phone_NO, s, Request_Delivery_Report, Convert.ToInt16(Send_Interval),
                                  Convert.ToInt16(Retry_Times), Convert.ToInt16(SMS_Validity),
                                  Convert.ToInt16(SMS_Reference), SMS_Center);
                Send_ReferenceEdit.Text = s2;
                if ((s2.Length) > 0)
                {
                    StatusBar1.Text = "با موفقيت انجام شد";
                    i++;
                    Edit2.Text = (l.ToString());
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
            StatusBar1.Text =  MS_I1.Send_SMS_Error_Code();
        }

        private void BitBtn_SendText_Click(object sender, EventArgs e)
        {
            S_RefEdit.Text = "";
            if (MS_I1.Send_Text_SMS(false, phonenoedit1.Text, phonenoedit1.Text, smstextedit.Text))
            {
                StatusBar1.Text = "با موفقیت انجام شد";
                S_RefEdit.Text = MS_I1.R_SMS_Ref();
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
          MS_I1.Group_SMS_Setting(Request_Delivery_Report, SMS_Validity,SMS_NO_Change_Sim, Retry_Times, Send_Interval, SMS_Center);
        }

        private void BitBtn_Add_Group_SMS_Click(object sender, EventArgs e)
        {
            string s;
            int i;
            string Phone_NO;
            s = "";
            for (i = 0; i < SMS_Text_Edit.Lines.Count() - 1; i++)
            {
                s = s + SMS_Text_Edit.Lines[i];
                if (i < (SMS_Text_Edit.Lines.Count() - 1))
                    s = s + "/r";
            }
            Phone_NO = S_Code_SMS_Edit.Text + S_Mob_Edit.Text;
            MS_I1.Add_Group_SMS_Buffer(Phone_NO, s);
        }

        private void BitBtn_Delete_All_Click(object sender, EventArgs e)
        {
            MS_I1.SMS_Buf_Clear(true);
        }

        private void BitBtn_Start_Group_Click(object sender, EventArgs e)
        {
            MS_I1.SMS_Buf_Start(true);
        }

        private void BitBtnAll_SMS_Buf_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(MS_I1.Get_SMS_Buf_Indx()));
        }

        private void BitBtn_Stop_Group_Click(object sender, EventArgs e)
        {
            MS_I1.SMS_Buf_Start(false);
        }

        private void BitBtn_S_SMS_NO_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(MS_I1.Get_SMS_Buf_Sended()));
        }

        private void BitBtn_Pause_Group_Click(object sender, EventArgs e)
        {
            MS_I1.SMS_Buf_Pause();
        }

        private void BitBtn_Show_GSStatus_Click(object sender, EventArgs e)
        {
            bool Send_Done, SMS_Deliverd;

            Send_Done = false;
            SMS_Deliverd = MS_I1.Get_SMS_Buf_Status(Convert.ToInt32(LabeledEdit_SGSSN.Text),ref Send_Done);
            CheckBox_Send_Done.Checked = Send_Done;
            CheckBox_SMS_Deliverd.Checked = SMS_Deliverd;
        }

        private void SMSActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MS_I1.Active_New_SMS_Event(SMSActiveCheckBox.Checked))
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
            int Free_Space, Total_Size;
            Free_Space = 0;
            Total_Size = 0;
            if (MS_I1.Get_SMS_Space(ref Free_Space, ref Total_Size))
            {
                FreeMemEdit.Text = Convert.ToString(Free_Space);
                AllMemEdit.Text = Convert.ToString(Total_Size);
                MessageBox.Show("با موفقیت انجام شد");
            }
            else
                MessageBox.Show("خطا درانجام");
        }

        private void RedSMSNOBitBtn_Click(object sender, EventArgs e)
        {
            ReadNOSMSEdit.Text = Convert.ToString(MS_I1.Get_SMS_NO());
        }

        private void DelSMSBitBtn_Click(object sender, EventArgs e)
        {
            if (MS_I1.SMS_Delete(Convert.ToInt16(DelSMSEdit.Text), DelType_ComboBox.SelectedIndex))
                StatusBar1.Items[0].Text = "با موفقیت انجام شد";
            else
                StatusBar1.Items[0].Text = "انجام نشد";
        }

        private void SMSBtn3BitBtn_Click(object sender, EventArgs e)
        {
            Boolean PDU;
            int Indx;
            string SMS_Center, SMS_Type, Tel_Number, Time_stamp, S_Discharge, SMS_Text, TP_PID, TP_DCS, TP_VP, TP_ST, S_Reference;
            int iTP_ST, TP_Indx;
            string Res;
            string all_Part, part_NO;
            all_Part = "";              part_NO = "";            SMS_Center = "";            SMS_Type = "";
            Tel_Number = "";            Time_stamp = "";         S_Discharge = "";           SMS_Text = "";
            TP_PID = "";                TP_DCS = "";             TP_VP = "";                 TP_ST = "";
            S_Reference = "";           Res = "";                PDU = true;
            Indx = Convert.ToInt32(smsindxedit.Text);
            Res = MS_I1.R_SMS4(PDU, Indx, ref SMS_Center, ref SMS_Type, ref Tel_Number, ref Time_stamp,
                                          ref S_Discharge, ref SMS_Text, ref TP_PID, ref TP_DCS, ref TP_VP, ref TP_ST,
                                          ref S_Reference, ref all_Part, ref part_NO);
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
            MessageBox.Show(Convert.ToString(MS_I1.Total_Oflline_SMS_NO()));
        }

        private void Button_R_All_SMS_Click(object sender, EventArgs e)
        {
            int SMS_CNT,I,j;
            string SMS_Center,SMS_Type,Tel_Number,Time_stamp,S_Discharge,TP_PID,TP_DCS,TP_VP,TP_ST,S_Reference;
            int All_Part,Part_NO;
            string SMS_Text;
            int SROW;
            SMS_CNT = MS_I1.Total_Oflline_SMS_NO();
            SROW = 1;
            dataGridView1.RowCount = 1;
            SMS_Center  = "";            SMS_Type    = "";           Tel_Number  = "";            Time_stamp  = "";            
            S_Discharge = "";           TP_PID       = "";           TP_DCS      = "";            TP_VP       = "";                 
            TP_ST       = "";           S_Reference  = "";           All_Part    = 0;             Part_NO     = 0;
            SMS_Text    = "";
            for (I = 1; I <= SMS_CNT; I++)
            {
                if (MS_I1.Show_Oflline_SMS(I, ref SMS_Center, ref SMS_Type, ref Tel_Number, ref Time_stamp,
                                           ref S_Discharge, ref TP_PID, ref TP_DCS, ref TP_VP, ref TP_ST,
                                           ref S_Reference, ref All_Part, ref Part_NO, ref SMS_Text))
                {
                    j = 0;
                    string[] row = new string[] { Convert.ToString(I), SMS_Center, SMS_Type, Tel_Number, Time_stamp,
                                           S_Discharge, TP_PID, TP_DCS, TP_VP, TP_ST,S_Reference, 
                                           Convert.ToString(All_Part), Convert.ToString(Part_NO), SMS_Text };
                    //dataGridView1.RowCount = SROW + 1;
                    dataGridView1.Rows.Add(row);
                    richTextBox1.Text += ("SMS NO" + Convert.ToString(SROW) + "=" + SMS_Text);
                    SROW++;

                }
            }
        }

        private void Button_ClearAllSMS_Click(object sender, EventArgs e)
        {
            if (MS_I1.Clear_Oflline_SMS_NO())
                MessageBox.Show("با موفقیت انجام شد");
            else
                MessageBox.Show("خطا در انجام");
        }

        private void Button_ASMSS_Click(object sender, EventArgs e)
        {
            CheckBox_ASMSC.Checked = MS_I1.G_Offline_SMS_Active();
        }


        private void SMS_CenterBitBtn_Click(object sender, EventArgs e)
        {
            string str;
            SMS_CenterEdit.Text = "";
            str = MS_I1.R_SMS_Center();
            SMS_CenterEdit.Text = str;
        }

        private void CSMS_CenterBitBtn_Click(object sender, EventArgs e)
        {
            MS_I1.Change_SMS_Center(CSMS_CenterEdit.Text);
        }

        private void D_NO_BitBtn_Click(object sender, EventArgs e)
        {
            StatusBar1.Text = "";
            if (MS_I1.GSM_Set_Device_NO(Convert.ToInt16(D_NO_Edit.Text)))
                StatusBar1.Text = "با موفقيت انجام شد";
            else
                StatusBar1.Text = "انجام نشد";
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            short i = MS_I1.GSM_Get_Device_NO();
            D_NO_Edit.Text = "";
            D_NO_Edit.Text = Convert.ToString(i);
        }

        private void SetCharTypeButton_Click(object sender, EventArgs e)
        {
            StatusBar1.Text = "";
            if (MS_I1.SMS_Char_Mode(Convert.ToByte(Set_CharType_ComboBox.SelectedIndex + 1)))
                StatusBar1.Text = "با موفقیت انجام شد";
            else
                StatusBar1.Text = "انجام نشد";
        }

        private void BitBtn_ActiveCID_Click(object sender, EventArgs e)
        {
            if (MS_I1.CallerID_Enable(true))
                MessageBox.Show("با موفقیت انجام شد");
            else
                MessageBox.Show("خطا درانجام");
        }

        private void BitBtn_DeactiveCID_Click(object sender, EventArgs e)
        {
            if (MS_I1.CallerID_Enable(false))
                MessageBox.Show("با موفقیت انجام شد");
            else
                MessageBox.Show("خطا درانجام");
        }

        private void DiBitBtnal_Click(object sender, EventArgs e)
        {
           string Res_MSG;
            Res_MSG = "";
            if (MS_I1.GSM_Dial_NO(Dial_Code_Edit.Text, DialEdit.Text, ref Res_MSG))
                StatusBar1.Text = "با موفقيت انجام شد";
            else
                StatusBar1.Text = "انجام نشد";
            StatusBar1.Text += "  -  " + Res_MSG;
        }

        private void BitBtnAnswer_Click(object sender, EventArgs e)
        {
            if (MS_I1.GSM_Answer_Call())
                MessageBox.Show("با موفقیت انجام شد");
            else
                MessageBox.Show("خطا درانجام");
        }

        private void BitBtnDisconnect_Click(object sender, EventArgs e)
        {
            if (MS_I1.Disconnect_Voice_Call())
                MessageBox.Show("با موفقیت انجام شد");
            else
                MessageBox.Show("خطا درانجام");
        }

        private void Modem_ConnectBitBtn_Click(object sender, EventArgs e)
        {
            ModemConnectCheckBox.Checked = false;
            ModemConnectCheckBox.Checked = MS_I1.GSM_Test_Connect();

        }

        private void Modem_ReadyBitBtn_Click(object sender, EventArgs e)
        {
            ModemReadyCheckBox.Checked = false;
            ModemReadyCheckBox.Checked = MS_I1.GSM_Ready();
        }

        private void IMEIBitBtn_Click(object sender, EventArgs e)
        {
            IMEIEdit.Text = "";
            IMEIEdit.Text = MS_I1.R_IMEI();

        }

        private void CIMIBitBtn_Click(object sender, EventArgs e)
        {
            CIMIEdit.Text = "";
            CIMIEdit.Text = MS_I1.R_Natttional_Mobile_ID();
        }

        private void BitBtn_SetDateTime_Click(object sender, EventArgs e)
        {
            if (MS_I1.Set_GSM_Date_Time(Convert.ToInt16(yearedit.Text), Convert.ToInt16(monthedit.Text),
                                        Convert.ToInt16(dayedit.Text), Convert.ToInt16(houredit.Text),
                                        Convert.ToInt16(minedit.Text), Convert.ToInt16(secedit.Text)))
                StatusBar1.Text = "با موفقيت انجام شد";
            else
                StatusBar1.Text = "انجام نشد";
        }

        private void BitBtn_GetDate_Click(object sender, EventArgs e)
        {
            GDateTimeTextBox.Text = "";
            GDateTimeTextBox.Text = MS_I1.R_GSM_Date_Time();
        }

        private void BitBtn_Getstatus_Click(object sender, EventArgs e)
        {
            PowerOnCheckBox.Checked = MS_I1.R_GSM_POW();
        }

        private void BitBtn_ReadGSMstatus_Click(object sender, EventArgs e)
        {
         string Message_Text;
         int ErrCod;
            Message_Text = "";
             ErrCod = MS_I1.Get_GSM_Message(ref Message_Text);
            MessageBox.Show("Error code is :" + ErrCod.ToString() + " - " + Message_Text);
        }

        private void SimComboBoxBitBtn_Click(object sender, EventArgs e)
        {
            CIMIEdit.Text = "";
            SimComboBox.SelectedIndex = Convert.ToInt32(MS_I1.R_SIM_PIN()) - 1;
        }

        private void SelectedNetBitBtn_Click(object sender, EventArgs e)
        {
            NetSelectEdit.Text = "";
            NetSelectEdit.Text = MS_I1.Selected_Network();
        }

        private void SIM_IDBitBtn_Click(object sender, EventArgs e)
        {
            SIM_IDEdit.Text = "";
            SIM_IDEdit.Text = MS_I1.R_SIM_ID();
        }

        private void SignalBitBtn_Click(object sender, EventArgs e)
        {
            SigQualityEdit.Text = "";
            SigQualityEdit.Text = MS_I1.GSM_Signal() + "%";

        }

        private void BitBtn_SelNetwork_Click(object sender, EventArgs e)
        {
            if (MS_I1.Select_SIM_Network())
              MessageBox.Show("با موفقیت انجام شد");
            else
               MessageBox.Show("خطا درانجام");
        }

        private void PINBitBtn_Click(object sender, EventArgs e)
        {
            if (MS_I1.Insert_PIN(PINEdit.Text))
                MessageBox.Show("با موفقیت انجام شد");
            else
                MessageBox.Show("خطا درانجام");
        }
    }
}
