using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Nz.Order.Winforms.Helpers
{
    /// <summary>
    /// خواندن گروه‌ها، کالاها و موجودی از دیتابیس نرم‌افزار حسابداری.
    /// <para>
    /// TODO(اسکیمای حسابداری): نام جدول‌ها و ستون‌های کوئری‌های زیر باید با اسکیمای واقعی
    /// نرم‌افزار حسابداری تطبیق داده شود. نام ستون‌هایی که با <c>AS</c> نام‌گذاری شده‌اند را
    /// عوض نکنید، چون کد بر اساس همین نام‌ها مقدار می‌خواند.
    /// </para>
    /// <para>
    /// کد گروه (<c>GroupCode</c>) در حسابداری از نوع <c>short</c> است و در سامانه به‌صورت رشته
    /// ذخیره می‌شود؛ مبدل <see cref="ShortAsStringConverter"/> این تبدیل را خودکار انجام می‌دهد.
    /// </para>
    /// </summary>
    public class AccountingReader
    {
        // ============================================================================================
        // TODO(اسکیمای حسابداری): سه کوئری زیر را با جدول‌ها و ستون‌های واقعی تطبیق دهید.
        //   فقط نام جدول/ستون سمت چپ را عوض کنید؛ نام‌های AS شده را دست نزنید.
        // ============================================================================================

        /// <summary>گروه‌های کالا</summary>
        private const string SqlCategories = @"
SELECT  g.GroupCode  AS Code,
        g.GroupTitle AS Title,
        g.IsActive   AS IsActive
FROM    dbo.GoodsGroups g
WHERE   g.IsActive = 1
ORDER BY g.GroupCode;";

        /// <summary>کالاها به‌همراه گروه و چهار نرخ</summary>
        private const string SqlProducts = @"
SELECT  g.GoodsCode        AS Code,
        g.GoodsName        AS Name,
        g.GroupCode        AS CategoryCode,
        g.UnitName         AS UnitOfMeasure,
        g.PartnershipPrice AS PartnershipPrice,
        g.RetailPrice      AS RetailPrice,
        g.WholesalePrice   AS WholesalePrice,
        g.DiscountPrice    AS DiscountPrice,
        g.Description      AS Description
FROM    dbo.Goods g
WHERE   g.IsActive = 1
ORDER BY g.GoodsCode;";

        /// <summary>موجودی و نرخ‌ها</summary>
        private const string SqlStock = @"
SELECT  g.GoodsCode        AS Code,
        g.StockQty         AS Quantity,
        g.PartnershipPrice AS PartnershipPrice,
        g.RetailPrice      AS RetailPrice,
        g.WholesalePrice   AS WholesalePrice,
        g.DiscountPrice    AS DiscountPrice
FROM    dbo.Goods g
WHERE   g.IsActive = 1
ORDER BY g.GoodsCode;";

        private readonly string _connectionString;

        public AccountingReader(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("رشته اتصال دیتابیس حسابداری تنظیم نشده است.", nameof(connectionString));
            }

            _connectionString = connectionString;
        }

        /// <summary>آزمایش اتصال به دیتابیس حسابداری.</summary>
        public bool TestConnection(out string error)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                }

                error = null;

                return true;
            }
            catch (Exception exception)
            {
                error = exception.Message;

                return false;
            }
        }

        /// <summary>خواندن گروه‌های کالا</summary>
        public List<SyncCategoryDto> ReadCategories()
        {
            return Query(SqlCategories, reader => new SyncCategoryDto
            {
                Code = reader["Code"] == DBNull.Value ? (short)0 : Convert.ToInt16(reader["Code"]),
                Title = reader["Title"] == DBNull.Value ? string.Empty : Convert.ToString(reader["Title"]),
                IsActive = reader["IsActive"] == DBNull.Value || Convert.ToBoolean(reader["IsActive"])
            });
        }

        /// <summary>خواندن کالاها به‌همراه گروه و نرخ‌ها</summary>
        public List<SyncProductDto> ReadProducts()
        {
            return Query(SqlProducts, reader => new SyncProductDto
            {
                Code = Convert.ToInt32(reader["Code"]),
                Name = reader["Name"] == DBNull.Value ? string.Empty : Convert.ToString(reader["Name"]),
                CategoryCode = reader["CategoryCode"] == DBNull.Value
                    ? (short?)null
                    : Convert.ToInt16(reader["CategoryCode"]),
                UnitOfMeasure = reader["UnitOfMeasure"] == DBNull.Value
                    ? "عدد"
                    : Convert.ToString(reader["UnitOfMeasure"]),
                PartnershipPrice = ToDecimal(reader["PartnershipPrice"]),
                RetailPrice = ToDecimal(reader["RetailPrice"]),
                WholesalePrice = ToDecimal(reader["WholesalePrice"]),
                DiscountPrice = ToDecimal(reader["DiscountPrice"]),
                Description = reader["Description"] == DBNull.Value
                    ? null
                    : Convert.ToString(reader["Description"])
            });
        }

        /// <summary>خواندن موجودی و نرخ‌ها</summary>
        public List<SyncStockItemDto> ReadStock()
        {
            return Query(SqlStock, reader => new SyncStockItemDto
            {
                Code = Convert.ToInt32(reader["Code"]),
                Quantity = ToDecimal(reader["Quantity"]),
                PartnershipPrice = ToDecimal(reader["PartnershipPrice"]),
                RetailPrice = ToDecimal(reader["RetailPrice"]),
                WholesalePrice = ToDecimal(reader["WholesalePrice"]),
                DiscountPrice = ToDecimal(reader["DiscountPrice"])
            });
        }

        private static decimal ToDecimal(object value)
        {
            return value == DBNull.Value ? 0m : Convert.ToDecimal(value);
        }

        private List<T> Query<T>(string sql, Func<IDataRecord, T> map)
        {
            var items = new List<T>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                command.CommandTimeout = 120;

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        items.Add(map(reader));
                    }
                }
            }

            return items;
        }
    }
}
