using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using JsonFx.Json;
using JsonFx.Serialization;
using MS_Control.Controls;
using MS_Control.Tarikh;

namespace ShareLib.Utils
{
    public static class Extentions
    {
        public static void      ToXml<T>                (this T Item, string FileName)
        {
            XmlSerializer xmlWrite = new XmlSerializer(typeof(T));
            var xmlWriteFile = File.Exists(FileName)
                                                ? new FileStream(FileName, FileMode.Truncate, FileAccess.Write)
                                                : new FileStream(FileName, FileMode.CreateNew, FileAccess.Write);

            xmlWrite.Serialize(xmlWriteFile, Item);
            xmlWriteFile.Close();
        }
        public static string    ToXmlString             (this object obj)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, obj);
                return textWriter.ToString();
            }
        }

        public static void      ToJson<T>               (this T Item, string FileName)
        {
	        var JsonStr = ToJsonString(Item); 
            File.WriteAllText(FileName,JsonStr); 
        }
        public static string    ToJsonString            (this object Item)
        {
	        var writer = new JsonWriter();
	        return writer.Write(Item); 
        }

        public static           T FromXmlString<T>      (string XmlText)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (StringReader sr = new StringReader(XmlText))
            {
                return (T)ser.Deserialize(sr);
            }
        }
        public static T         FromXml<T>              (string FileName)
        {
            XmlSerializer   xmlRead     = new XmlSerializer(typeof(T));
            FileStream      xmlReadFile = new FileStream(FileName, FileMode.Open);
            object          xmlObject   = xmlRead.Deserialize(xmlReadFile);

            xmlReadFile.Close();
            return (T)xmlObject;
        }
        
        public static           T FromJsonString<T>     (string XmlText)
        {

	        var reader = new JsonReader();
	        return reader.Read<T>(XmlText);
        }
        public static T         FromJson<T>             (string FileName)
        {
	        return FromJsonString<T>(File.ReadAllText(FileName));
        }

        public static string    ToPersianDate           (this DateTime date)
        {
	        var pd = new PersianCalendar();
	        return pd.GetYear(date) + "/" + pd.GetMonth(date) + "/" + pd.GetDayOfMonth(date);
        }

        public static bool		IsPersianDate			(this string PersianStr)
        {
	        try
	        {
		        var StrNumbers = PersianStr
			        .Split(new string[] { "/", "\\", "|", ",", ".", "-", " " },
				        StringSplitOptions.RemoveEmptyEntries);

		        if (StrNumbers == null || !StrNumbers.Any() || StrNumbers.Length < 3)
			        return false;

		        var Numbers = StrNumbers.Select(x => Convert.ToInt32(x)).ToList();

		        if (Numbers == null || !Numbers.Any() || Numbers.Count < 3)
			        return false;

		        if (Numbers[1] < 1 || Numbers[1] > 12)
			        return false;

		        if (Numbers[2] < 1 || Numbers[2] > 31)
			        return false;

		        var p = new PersianCalendar();
		        var r = p.ToDateTime(Numbers[0], Numbers[1], Numbers[2], 0, 0, 0, 0);

		        return true;
	        }
	        catch
	        {
		        return false;
	        }
        }

		public static void      FillParametter          (this MS_GridX_Setting GridSetting ,string Title="")
        {
            GridSetting.MS_Company_Name = SystemConstant.ActiveCompany.title;
            GridSetting.MS_Molahezat    = SystemConstant.ActiveCompany.molahezat;
            GridSetting.MS_Report_Name  = string.IsNullOrEmpty(Title)? GridSetting.FindForm().Text:Title;
            GridSetting.MS_Tarix_Report = new MS_Structure_Shamsi(DateTime.Now).ToShamsi();
            GridSetting.MS_User_Name    = SystemConstant.ActiveUser.title;

        }
        public static void      SafeSetProperty         (this Control Control, string PropertyName, object value)
        {
            
           
                Control.Invoke((MethodInvoker)(() =>
                {
                    Type controlType    = Control.GetType();
                    var property        = controlType.GetProperty(PropertyName);

                    if (property != null)
                        property.SetValue(Control, value, null);
                }));

        }


		public static string	NzWebsiteStateOrderToPersian		(this string Kind)
		{

			switch (Kind)
			{
				case "pending":
					return "در انتظار پرداخت";
				case "processing":
					return "در حال انجام";
				case "on-hold":
					return "در انتظار بررسی";
				case "completed":
					return "تکمیل شده";
				case "cancelled":
					return "لغو شده";
				case "refunded":
					return "مسترد شده";
				case "failed":
					return "ناموفق";
				case "trash":
					return "حذف شده";
				default:
					return "";
			}
		}
		public static string	NzWebsiteStockStatusToPersian		(this string Kind)
		{

			switch (Kind)
			{
				case "instock":
					return "موجود";
				case "outofstock":
					return "ناموجود";
				case "onbackorder":
					return "در پیش‌خرید";
				default:
					return "";
			}
		}

		public static string	NzWebsiteProductTypeToPersian		(this string Kind)
		{

			switch (Kind)
			{
				case "simple":
					return "ساده";
				case "grouped":
					return "دسته بندی";
				case "external":
					return "خارجی";
				case "variable":
					return "متغیر";
				default:
					return "";
			}
		}
		public static string	NzWebsiteStateToPersian				(this string Kind)
		{
			if (string.IsNullOrWhiteSpace(Kind))
				return "";

			switch (Kind)
			{
				case "KHZ": return "خوزستان";
				case "THR": return "تهران";
				case "ILM": return "ایلام";
				case "BHR": return "بوشهر";
				case "ADL": return "اردبیل";
				case "ESF": return "اصفهان";
				case "YZD": return "یزد";
				case "KRH": return "کرمانشاه";
				case "KRN": return "کرمان";
				case "HDN": return "همدان";
				case "GZN": return "قزوین";
				case "ZJN": return "زنجان";
				case "LRS": return "لرستان";
				case "ABZ": return "البرز";
				case "EAZ": return "آذربایجان شرقی";
				case "WAZ": return "آذربایجان غربی";
				case "CHB": return "چهارمحال و بختیاری";
				case "SKH": return "خراسان جنوبی";
				case "RKH": return "خراسان رضوی";
				case "NKH": return "خراسان شمالی";
				case "SMN": return "سمنان";
				case "FRS": return "فارس";
				case "QHM": return "قم";
				case "KRD": return "کردستان";
				case "KBD": return "کهگیلویه و بویراحمد";
				case "GLS": return "گلستان";
				case "GIL": return "گیلان";
				case "MZN": return "مازندران";
				case "MKZ": return "مرکزی";
				case "HRZ": return "هرمزگان";
				case "SBN": return "سیستان و بلوچستان";

				default:
					return "";
			}
		}

		public static DateTime	ToPersianDate			(this string PersianStr)
		{
			var StrNumbers = PersianStr
				.Split(new string[] { "/", "\\", ",", "|", "." },
					StringSplitOptions.RemoveEmptyEntries);

			var IntNumbers = StrNumbers
				.Where(x => int.TryParse(x, out int tmp))
				.Select(x => int.Parse(x))
				.ToArray();

			var p = new PersianCalendar();

			return p.ToDateTime(IntNumbers[0], IntNumbers[1], IntNumbers[2], 0, 0, 0, 0);
		}


		public static string En2Fa(this string str)
		{
			if (string.IsNullOrWhiteSpace(str))
				return string.Empty;

			var sb = new StringBuilder();

			for (var i = 0; i < str.Length; i++)
			{
				switch (str[i])
				{
					case '0':
						sb.Append('۰')  ;
						break;
					case '1':
						sb.Append('۱');
						break;
					case '2':
						sb.Append( '۲');
						break;
					case '3':
						sb.Append( '۳');
						break;
					case '4':
						sb.Append( '۴');
						break;
					case '5':
						sb.Append( '۵');
						break;
					case '6':
						sb.Append( '۶');
						break;
					case '7':
						sb.Append( '۷');
						break;
					case '8':
						sb.Append( '۸');
						break;
					case '9':
						sb.Append( '۹');
						break;
					default:
						sb.Append(str[i]);
						break;
				}
			}

			return sb.ToString();
		}
	}
}
