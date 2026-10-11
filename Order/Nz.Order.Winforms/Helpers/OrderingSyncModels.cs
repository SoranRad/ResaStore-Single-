using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Nz.Order.Winforms.Helpers
{
    // ============================================================================================
    // مدل‌های انتقال اطلاعات به «سامانه ثبت سفارش رسا»
    //
    // نکته مهم: «کد گروه» در نرم‌افزار حسابداری از نوع short است، اما سامانه آن را به‌صورت
    // رشته (string) ذخیره می‌کند. به همین دلیل از مبدل ShortAsStringConverter استفاده شده تا
    // کد گروه در JSON به‌صورت "100" نوشته شود و در سامانه درست بنشیند.
    // ============================================================================================

    #region مبدل‌های کد گروه (short <-> string در JSON)

    /// <summary>کد گروه را در JSON به‌صورت رشته می‌نویسد و از رشته یا عدد می‌خواند.</summary>
    public class ShortAsStringConverter : JsonConverter<short>
    {
        public override short Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                var text = reader.GetString();

                return short.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture, out var value)
                    ? value
                    : (short)0;
            }

            return reader.GetInt16();
        }

        public override void Write(Utf8JsonWriter writer, short value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString(CultureInfo.InvariantCulture));
        }
    }

    /// <summary>نسخه nullable مبدل کد گروه (برای کالاهایی که گروه ندارند).</summary>
    public class NullableShortAsStringConverter : JsonConverter<short?>
    {
        public override short? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }

            if (reader.TokenType == JsonTokenType.String)
            {
                var text = reader.GetString();

                return short.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture, out var value)
                    ? value
                    : (short?)null;
            }

            return reader.GetInt16();
        }

        public override void Write(Utf8JsonWriter writer, short? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
            {
                writer.WriteStringValue(value.Value.ToString(CultureInfo.InvariantCulture));
            }
            else
            {
                writer.WriteNullValue();
            }
        }
    }

    #endregion

    #region درخواست‌ها

    public class ImportCategoriesRequest
    {
        public List<SyncCategoryDto> Categories { get; set; } = new List<SyncCategoryDto>();
    }

    public class ImportProductsRequest
    {
        public List<SyncProductDto> Products { get; set; } = new List<SyncProductDto>();
    }

    public class ApplyStockRequest
    {
        /// <summary>زمان خواندن موجودی از حسابداری (UTC). مبنای محاسبه موجودی در سامانه است.</summary>
        public string StockDate { get; set; }

        public List<SyncStockItemDto> Items { get; set; } = new List<SyncStockItemDto>();
    }

    #endregion

    #region آیتم‌های ارسالی

    /// <summary>گروه کالا. کد گروه در حسابداری از نوع short است.</summary>
    public class SyncCategoryDto
    {
        [JsonConverter(typeof(ShortAsStringConverter))]
        public short Code { get; set; }

        public string Title { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }

    /// <summary>کالا به‌همراه گروه و نرخ‌ها.</summary>
    public class SyncProductDto
    {
        /// <summary>کد کالا در سامانه عددی است.</summary>
        public int Code { get; set; }

        public string Name { get; set; } = string.Empty;

        /// <summary>کد گروه؛ در صورت نبود گروه، null بماند.</summary>
        [JsonConverter(typeof(NullableShortAsStringConverter))]
        public short? CategoryCode { get; set; }

        public string UnitOfMeasure { get; set; } = "عدد";

        public decimal PartnershipPrice { get; set; }

        public decimal RetailPrice { get; set; }

        public decimal WholesalePrice { get; set; }

        public decimal DiscountPrice { get; set; }

        public string Description { get; set; }
    }

    /// <summary>ردیف موجودی و نرخ‌های یک کالا.</summary>
    public class SyncStockItemDto
    {
        public int Code { get; set; }

        /// <summary>موجودی مبنا در نرم‌افزار حسابداری</summary>
        public decimal Quantity { get; set; }

        public decimal PartnershipPrice { get; set; }

        public decimal RetailPrice { get; set; }

        public decimal WholesalePrice { get; set; }

        public decimal DiscountPrice { get; set; }
    }

    #endregion

    #region پاسخ سامانه

    /// <summary>نتیجه عملیات سینک که سامانه برمی‌گرداند.</summary>
    public class SyncResultDto
    {
        public int Created { get; set; }

        public int Updated { get; set; }

        public int Unchanged { get; set; }

        /// <summary>کدهایی که در سامانه یافت نشدند (مثلاً کالایی که هنوز وارد نشده است)</summary>
        public List<string> NotFound { get; set; } = new List<string>();

        /// <summary>هشدارها؛ مثلاً گروهی که به‌صورت خودکار ساخته شد</summary>
        public List<string> Warnings { get; set; } = new List<string>();

        public string ToPersianSummary()
        {
            var text = string.Format(
                CultureInfo.InvariantCulture,
                "ایجاد: {0} | به‌روزرسانی: {1} | بدون تغییر: {2}",
                Created,
                Updated,
                Unchanged);

            if (NotFound != null && NotFound.Count > 0)
            {
                text += string.Format(
                    CultureInfo.InvariantCulture,
                    " | یافت‌نشده: {0} ({1})",
                    NotFound.Count,
                    string.Join(", ", NotFound.GetRange(0, Math.Min(10, NotFound.Count))));
            }

            return text;
        }
    }

    #endregion
}
