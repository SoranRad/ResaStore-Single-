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
        public static void      ToXml<T>            (this T Item, string FileName)
        {
            XmlSerializer xmlWrite = new XmlSerializer(typeof(T));
            var xmlWriteFile = File.Exists(FileName)
                                                ? new FileStream(FileName, FileMode.Truncate, FileAccess.Write)
                                                : new FileStream(FileName, FileMode.CreateNew, FileAccess.Write);

            xmlWrite.Serialize(xmlWriteFile, Item);
            xmlWriteFile.Close();
        }
        public static string    ToXmlString         (this object obj)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, obj);
                return textWriter.ToString();
            }
        }

        public static void      ToJson<T>            (this T Item, string FileName)
        {
	        var JsonStr = ToJsonString(Item); 
            File.WriteAllText(FileName,JsonStr); 
        }
        public static string    ToJsonString         (this object Item)
        {
	        var writer = new JsonWriter();
	        return writer.Write(Item); 
        }

        public static       T FromXmlString<T>      (string XmlText)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (StringReader sr = new StringReader(XmlText))
            {
                return (T)ser.Deserialize(sr);
            }
        }
        public static T     FromXml<T>              (string FileName)
        {
            XmlSerializer   xmlRead     = new XmlSerializer(typeof(T));
            FileStream      xmlReadFile = new FileStream(FileName, FileMode.Open);
            object          xmlObject   = xmlRead.Deserialize(xmlReadFile);

            xmlReadFile.Close();
            return (T)xmlObject;
        }
        
        public static       T FromJsonString<T>      (string XmlText)
        {

	        var reader = new JsonReader();
	        return reader.Read<T>(XmlText);
        }
        public static T     FromJson<T>              (string FileName)
        {
	        return FromJsonString<T>(File.ReadAllText(FileName));
        }

        public static string ToPersianDate(this DateTime date)
        {
	        var pd = new PersianCalendar();
	        return pd.GetYear(date) + "/" + pd.GetMonth(date) + "/" + pd.GetDayOfMonth(date);
        }
        
        public static void  FillParametter          (this MS_GridX_Setting GridSetting ,string Title="")
        {
            GridSetting.MS_Company_Name = SystemConstant.ActiveCompany.title;
            GridSetting.MS_Molahezat    = SystemConstant.ActiveCompany.molahezat;
            GridSetting.MS_Report_Name  = string.IsNullOrEmpty(Title)? GridSetting.FindForm().Text:Title;
            GridSetting.MS_Tarix_Report = new MS_Structure_Shamsi(DateTime.Now).ToShamsi();
            GridSetting.MS_User_Name    = SystemConstant.ActiveUser.title;

        }

        public static void SafeSetProperty          (this Control Control, string PropertyName, object value)
        {
            
           
                Control.Invoke((MethodInvoker)(() =>
                {
                    Type controlType    = Control.GetType();
                    var property        = controlType.GetProperty(PropertyName);

                    if (property != null)
                        property.SetValue(Control, value, null);
                }));

        }
    }
}
