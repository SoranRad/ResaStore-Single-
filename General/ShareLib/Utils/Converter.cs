using System;
using System.Collections;
using System.Reflection;

namespace ShareLib.Utils
{
	[AttributeUsage(AttributeTargets.Property, AllowMultiple=false)]
	public class ValueFromPropertyAttribute : Attribute
	{
		private string _propertyName = string.Empty;
		private System.Type _fromType = null;
		private System.Type _toType = null;
        
		public ValueFromPropertyAttribute(string propertyName)
		{
			this._propertyName = propertyName;
		}

		public ValueFromPropertyAttribute(string propertyName, System.Type
			fromType)
		{
			this._propertyName = propertyName;
			this._fromType = fromType;
		}

		public ValueFromPropertyAttribute(string propertyName, System.Type fromType,
			System.Type toType)
		{
			this._propertyName = propertyName;
			this._fromType = fromType;
			this._toType = toType;
		}

		public string ValueFromProperty { get { return this._propertyName; } }

		public System.Type FromType { get { return this._fromType; } }
		public System.Type ToType { get { return this._toType; } }
	}  

	public static class Converter
    {
	    private static readonly string[] OrdinalNumbers = new string[]
	    {
		    "",           // 0 - خالی
		    "اول",        // 1
		    "دوم",        // 2
		    "سوم",        // 3
		    "چهارم",      // 4
		    "پنجم",       // 5
		    "ششم",       // 6
		    "هفتم",       // 7
		    "هشتم",       // 8
		    "نهم",        // 9
		    "دهم",        // 10
		    "یازدهم",     // 11
		    "دوازدهم",    // 12
		    "سیزدهم",     // 13
		    "چهاردهم",    // 14
		    "پانزدهم",    // 15
		    "شانزدهم",    // 16
		    "هفده‌م",     // 17
		    "هجده‌م",     // 18
		    "نوزدهم",     // 19
		    "بیستم",      // 20
		    "بیست‌و‌یکم",   // 21
		    "بیست‌و‌دوم",   // 22
		    "بیست‌و‌سوم",   // 23
		    "بیست‌و‌چهارم", // 24
		    "بیست‌و‌پنجم",  // 25
		    "بیست‌و‌ششم",  // 26
		    "بیست‌و‌هفتم",  // 27
		    "بیست‌و‌هشتم",  // 28
		    "بیست‌و‌نهم",   // 29
		    "سی‌ام",       // 30
		    "سی‌و‌یکم",     // 31
		    "سی‌و‌دوم",     // 32
		    "سی‌و‌سوم",     // 33
		    "سی‌و‌چهارم",   // 34
		    "سی‌و‌پنجم",    // 35
		    "سی‌و‌ششم",    // 36
		    "سی‌و‌هفتم",    // 37
		    "سی‌و‌هشتم",    // 38
		    "سی‌و‌نهم",     // 39
		    "چهلم",        // 40
		    "چهل‌و‌یکم",    // 41
		    "چهل‌و‌دوم",    // 42
		    "چهل‌و‌سوم",    // 43
		    "چهل‌و‌چهارم",  // 44
		    "چهل‌و‌پنجم",   // 45
		    "چهل‌و‌ششم",   // 46
		    "چهل‌و‌هفتم",   // 47
		    "چهل‌و‌هشتم",   // 48
		    "چهل‌و‌نهم",    // 49
		    "پنجاهم"       // 50
	    };
		public static object ConvertAll(object[] fromObjects, System.Type
          toType)
        {
            if (fromObjects != null)
            {
                ArrayList list = new ArrayList(fromObjects.Length);

                foreach (object obj in fromObjects)
                {
                    list.Add(Convert(obj, toType));
                }

                return list.ToArray(toType);
               
            }
            return null;
        }

        public static object Convert(object fromObject, System.Type toType)
        {
            if (fromObject == null) return null;
            object returnObject = Activator.CreateInstance(toType);

            PropertyInfo [] infos = returnObject.GetType().GetProperties();
            foreach (PropertyInfo property in infos)
            {
                 ValueFromPropertyAttribute [] attributes = (ValueFromPropertyAttribute[])property.GetCustomAttributes(typeof(ValueFromPropertyAttribute), false);

                if (attributes.Length > 0)
                {
                    PropertyInfo fromProperty = fromObject.GetType().GetProperty(attributes[0].ValueFromProperty);
                    if (attributes[0].FromType == null)
                    {
                        property.SetValue(returnObject, fromProperty.GetValue(fromObject, null), null);
                    }
                    else
                    {
                        if (fromProperty.PropertyType.IsArray)
                        {
                            property.SetValue(returnObject, ConvertAll((object []) fromProperty.GetValue(fromObject, null), attributes[0].ToType), null);
                        }
                        else
                        {
                            property.SetValue(returnObject, Convert(fromProperty.GetValue(fromObject, null), property.PropertyType), null);
                        }
                    }
                }
            }

            return returnObject;
        }

        public static T Convert<T>(object Item)
        {
	        var StrJson = Item.ToJsonString();
            return Extentions.FromJsonString<T>(StrJson);
        }

        public static string ConvertToPersian(int number)
        {
	        if (number < 1 || number > 50)
		        throw new ArgumentOutOfRangeException(nameof(number), "عدد باید بین 1 تا 50 باشد");

	        return OrdinalNumbers[number];
        }
	}



}
