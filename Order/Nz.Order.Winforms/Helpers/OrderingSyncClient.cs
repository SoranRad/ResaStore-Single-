using RestSharp;
using ShareLib.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Nz.Order.Winforms.Settings;
using RestSharp.Authenticators;
using RestSharp.Serializers.Json;
using TwentyDevs.ResultCore;

namespace Nz.Order.Winforms.Helpers
{
    /// <summary>
    /// کلاینت انتقال اطلاعات به «سامانه ثبت سفارش رسا».
    /// <para>
    /// احراز هویت با «کلید API فروشگاه» در هدر <c>X-Api-Key</c> انجام می‌شود؛ نیازی به ورود کاربر نیست.
    /// طبق توصیه خود RestSharp، این کلاس را یک‌بار بسازید و در طول عمر برنامه نگه دارید
    /// (نه برای هر فراخوانی). کلید API را از پنل مدیر کل سامانه بسازید.
    /// </para>
    /// </summary>
    public class OrderingSyncClient : IDisposable
    {
        /// <summary>تنظیمات JSON هم‌خوان با سامانه: camelCase و بی‌تفاوت به بزرگی/کوچکی حروف</summary>
        public static readonly JsonSerializerOptions JsonOptions =
            new JsonSerializerOptions(JsonSerializerDefaults.Web);

        private readonly RestClient _client;
        private readonly string _apiKey;
        private readonly int _batchSize;

        /// <param name="baseUrl">مثلاً http://localhost:5088</param>
        /// <param name="apiKey">کلید API فروشگاه</param>
        /// <param name="batchSize">تعداد ردیف در هر درخواست (پیش‌فرض ۵۰۰)</param>
        public OrderingSyncClient(string baseUrl, string apiKey, int batchSize = 500)
        {
            if (string.IsNullOrWhiteSpace(baseUrl))
            {
                throw new ArgumentException("آدرس سامانه ثبت سفارش تنظیم نشده است.", nameof(baseUrl));
            }

            if (string.IsNullOrWhiteSpace(apiKey))
            {
                throw new ArgumentException("کلید API فروشگاه تنظیم نشده است.", nameof(apiKey));
            }

            _apiKey = apiKey.Trim();
            _batchSize = batchSize < 1 ? 1 : batchSize;

            

            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = (msg, cert, chain, errors) => { return true; }; // Ignore SSL errors for local development
            var httpClient = new HttpClient(httpClientHandler);
            httpClient.BaseAddress = new Uri(baseUrl.Trim().TrimEnd('/'));
            //var authenticator = new JwtAuthenticator(Token);
            //var options = new RestClientOptions() { Authenticator = authenticator };
            var configSerialize = new ConfigureSerialization(config => config.UseSystemTextJson(new JsonSerializerOptions() { PropertyNameCaseInsensitive = true, PropertyNamingPolicy = null }));
            var options = new RestClientOptions(baseUrl.Trim().TrimEnd('/'))
            {
	            Timeout = TimeSpan.FromSeconds(250),
	            ThrowOnAnyError = false,

            };


            _client = new RestClient
            (
	            httpClient: httpClient
	            , options: options
	            , configureSerialization: configSerialize
            );

            //return client;

			//_client = new RestClient(options);
        }

        #region ۱) گروه‌های کالا

        /// <summary>ارسال گروه‌های کالا از حسابداری به سامانه (ایجاد یا به‌روزرسانی).</summary>
        public Task<Result<SyncResultDto>> ImportCategoriesAsync(
            IReadOnlyCollection<SyncCategoryDto> categories,
            CancellationToken cancellationToken = default)
        {
            return SendInBatchesAsync(
                "api/sync/categories/import",
                categories,
                batch => new ImportCategoriesRequest { Categories = batch },
                cancellationToken);
        }

        #endregion

        #region ۲) کالاها و نرخ‌ها

        /// <summary>ارسال کالاها به‌همراه گروه و چهار نرخ.</summary>
        public Task<Result<SyncResultDto>> ImportProductsAsync(
            IReadOnlyCollection<SyncProductDto> products,
            CancellationToken cancellationToken = default)
        {
            return SendInBatchesAsync(
                "api/sync/products/import",
                products,
                batch => new ImportProductsRequest { Products = batch },
                cancellationToken);
        }

        #endregion

        #region ۳) موجودی و نرخ‌ها

        /// <summary>
        /// ارسال موجودی مبنا و نرخ‌ها به سامانه.
        /// <para>
        /// تاریخ موجودی باید «لحظه خواندن از حسابداری» باشد. سامانه موجودی قابل استفاده را
        /// به‌صورت «مبنا منهای سفارش‌های منصرف‌نشده پس از این تاریخ» محاسبه می‌کند،
        /// بنابراین توصیه می‌شود این زمان را <b>پیش از</b> خواندن دیتابیس بگیرید و همان را بفرستید.
        /// اگر <paramref name="stockDate"/> داده نشود، زمان جاری (UTC) استفاده می‌شود.
        /// </para>
        /// </summary>
        public Task<Result<SyncResultDto>> PushStockAsync(
            IReadOnlyCollection<SyncStockItemDto> items,
            DateTimeOffset? stockDate = null,
            CancellationToken cancellationToken = default)
        {
            var readAt = (stockDate ?? DateTimeOffset.UtcNow).ToUniversalTime();

            var isoDate = readAt.ToString("yyyy-MM-dd'T'HH:mm:ss.fff'Z'", CultureInfo.InvariantCulture);

            return SendInBatchesAsync(
                "api/sync/stock",
                items,
                batch => new ApplyStockRequest { StockDate = isoDate, Items = batch },
                cancellationToken);
        }

        #endregion

        #region ۴) خواندن فهرست‌ها از سامانه

        /// <summary>دریافت فهرست گروه‌های کالای موجود در سامانه.</summary>
        /// <remarks>تعداد کالاهای هر گروه در فیلد <c>ProductCount</c> برمی‌گردد؛ گروهی که کالا دارد قابل حذف نیست.</remarks>
        public async Task<Result<List<ServerCategoryDto>>> GetCategoriesAsync(
            CancellationToken cancellationToken = default)
        {
            var result = await GetAsync<List<ServerCategoryDto>>("api/sync/categories", null, cancellationToken)
                .ConfigureAwait(false);

            if (!result.IsSuccess)
            {
                return Result.Fail<List<ServerCategoryDto>>(result.ToErrorMessage());
            }

            return Result.Success(result.Data ?? new List<ServerCategoryDto>());
        }

        /// <summary>
        /// دریافت فهرست کامل کالاهای سامانه با همه مشخصات (نرخ‌ها، موجودی، بسته بندی و …).
        /// </summary>
        /// <param name="includeInactive">در صورت true بودن، کالاهای غیرفعال هم برگردانده می‌شوند.</param>
        public async Task<Result<List<SyncProductDto>>> GetProductsAsync(
            bool includeInactive = true,
            CancellationToken cancellationToken = default)
        {
            var query = "api/sync/products?includeInactive=" + (includeInactive ? "true" : "false");

            var result = await GetAsync<List<SyncProductDto>>(query, null, cancellationToken).ConfigureAwait(false);

            if (!result.IsSuccess)
            {
                return Result.Fail<List<SyncProductDto>>(result.ToErrorMessage());
            }

            return Result.Success(result.Data ?? new List<SyncProductDto>());
        }

        #endregion

        #region ۵) حذف با کنترل وابستگی

        /// <summary>
        /// حذف گروه‌های کالا.
        /// گروهی که کالای مرتبط داشته باشد حذف نمی‌شود و در فهرست <c>Blocked</c> با دلیل برمی‌گردد.
        /// </summary>
        /// <param name="codes">کد گروه‌ها در سامانه (رشته‌ای)</param>
        public async Task<Result<SyncDeleteResultDto>> DeleteCategoriesAsync(
            IReadOnlyCollection<string> codes,
            CancellationToken cancellationToken = default)
        {
            var list = codes == null
                ? new List<string>()
                : codes.Where(code => !string.IsNullOrWhiteSpace(code)).Select(code => code.Trim()).ToList();

            if (list.Count == 0)
            {
                return Result.Success(new SyncDeleteResultDto());
            }

            return await PostAsync<DeleteCategoriesRequest, SyncDeleteResultDto>(
                "api/sync/categories/delete",
                new DeleteCategoriesRequest { Codes = list },
                cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// حذف کالاها.
        /// کالایی که در سفارش‌ها استفاده شده باشد حذف نمی‌شود و در فهرست <c>Blocked</c> با دلیل برمی‌گردد.
        /// </summary>
        /// <param name="codes">کد کالاها</param>
        public async Task<Result<SyncDeleteResultDto>> DeleteProductsAsync(
            IReadOnlyCollection<int> codes,
            CancellationToken cancellationToken = default)
        {
            var list = codes == null ? new List<int>() : codes.Where(code => code > 0).Distinct().ToList();

            if (list.Count == 0)
            {
                return Result.Success(new SyncDeleteResultDto());
            }

            return await PostAsync<DeleteProductsRequest, SyncDeleteResultDto>(
                "api/sync/products/delete",
                new DeleteProductsRequest { Codes = list },
                cancellationToken).ConfigureAwait(false);
        }

        #endregion

        #region آزمایش اتصال و کلید API

        /// <summary>بررسی درست بودن آدرس سامانه و کلید API فروشگاه.</summary>
        public async Task<Result> TestConnectionAsync(CancellationToken cancellationToken = default)
        {
            var request = new RestRequest("api/sync/orders", Method.Get);
            request.AddHeader("X-Api-Key", _apiKey);
            request.AddQueryParameter("take", "1");

            try
            {
                var response = await _client.ExecuteAsync(request, cancellationToken).ConfigureAwait(false);

                if (response.StatusCode == HttpStatusCode.Unauthorized ||
                    response.StatusCode == HttpStatusCode.Forbidden)
                {
                    return Result.Fail("کلید API نامعتبر است یا سرویس این فروشگاه غیرفعال/منقضی شده است.");
                }

                if (response.StatusCode == 0)
                {
                    return Result.Fail(
                        "ارتباط با سامانه برقرار نشد. آدرس سامانه، اجرا بودن آن و دسترسی شبکه را بررسی کنید.");
                }

                if ((int)response.StatusCode >= 500)
                {
                    return Result.Fail($"سامانه با خطای داخلی پاسخ داد (کد {(int)response.StatusCode}){Describe(response.ErrorMessage)}.");
                }

                return Result.Success("ارتباط با سامانه برقرار است و کلید API معتبر است.");
            }
            catch (Exception exception)
            {
                return Result.Fail($"ارتباط با سامانه برقرار نشد: {exception.Message}");
            }
        }

        #endregion

        #region پیاده‌سازی داخلی

        private async Task<Result<SyncResultDto>> SendInBatchesAsync<TItem, TBody>(
            string resource,
            IReadOnlyCollection<TItem> items,
            Func<List<TItem>, TBody> buildBody,
            CancellationToken cancellationToken)
            where TBody : class
        {
            var list = items == null ? new List<TItem>() : items.ToList();

            if (list.Count == 0)
            {
                return Result.Success(new SyncResultDto());
            }

            var total = new SyncResultDto();

            for (var offset = 0; offset < list.Count; offset += _batchSize)
            {
                cancellationToken.ThrowIfCancellationRequested();

                var batch = list.GetRange(offset, Math.Min(_batchSize, list.Count - offset));
                var result = await PostAsync(resource, buildBody(batch), cancellationToken).ConfigureAwait(false);

                if (!result.IsSuccess)
                {
                    return result;
                }

                Merge(total, result.Data);
            }

            return Result.Success(total);
        }

        /// <summary>فراخوانی GET و خواندن پاسخ یکسان سامانه.</summary>
        private async Task<Result<TData>> GetAsync<TData>(
            string resource,
            IEnumerable<KeyValuePair<string, string>> query,
            CancellationToken cancellationToken)
        {
            var request = new RestRequest(resource, Method.Get);
            request.AddHeader("X-Api-Key", _apiKey);

            if (query != null)
            {
                foreach (var pair in query)
                {
                    request.AddQueryParameter(pair.Key, pair.Value);
                }
            }

            try
            {
                var response = await _client.ExecuteAsync(request, cancellationToken).ConfigureAwait(false);

                return ReadEnvelope<TData>(response.Content, response.StatusCode, response.ErrorMessage);
            }
            catch (OperationCanceledException)
            {
                throw;
            }
            catch (Exception exception)
            {
                return Result.Fail<TData>($"ارتباط با سامانه برقرار نشد: {exception.Message}");
            }
        }

        /// <summary>فراخوانی POST با نوع دلخواه پاسخ.</summary>
        private async Task<Result<TData>> PostAsync<TBody, TData>(
            string resource,
            TBody body,
            CancellationToken cancellationToken)
            where TBody : class
        {
            var request = new RestRequest(resource, Method.Post);
            request.AddHeader("X-Api-Key", _apiKey);

            var json = JsonSerializer.Serialize(body, JsonOptions);

            request.AddStringBody(json, ContentType.Json);

            try
            {
                var response = await _client.ExecuteAsync(request, cancellationToken).ConfigureAwait(false);

                return ReadEnvelope<TData>(response.Content, response.StatusCode, response.ErrorMessage);
            }
            catch (OperationCanceledException)
            {
                throw;
            }
            catch (Exception exception)
            {
                return Result.Fail<TData>($"ارتباط با سامانه برقرار نشد: {exception.Message}");
            }
        }

        private async Task<Result<SyncResultDto>> PostAsync<TBody>(
            string resource,
            TBody body,
            CancellationToken cancellationToken)
            where TBody : class
        {
            // مسیر نباید با «/» شروع شود، چون RestClient خودش BaseUrl را اضافه می‌کند
            var request = new RestRequest(resource, Method.Post);
            request.AddHeader("X-Api-Key", _apiKey);

            var json = JsonSerializer.Serialize(body, JsonOptions);

            // در RestSharp نسخه ۱۰۷ به بعد برای بدنه JSON رشته‌ای باید از AddStringBody استفاده کرد
            request.AddStringBody(json, ContentType.Json);

            try
            {
                var response = await _client.ExecuteAsync(request, cancellationToken).ConfigureAwait(false);

                return ReadEnvelope<SyncResultDto>(response.Content, response.StatusCode, response.ErrorMessage);
            }
            catch (OperationCanceledException)
            {
                throw;
            }
            catch (Exception exception)
            {
                return Result.Fail<SyncResultDto>($"ارتباط با سامانه برقرار نشد: {exception.Message}");
            }
        }

        /// <summary>تبدیل پاسخ یکسان سامانه به Result با استفاده از کتابخانه ResultCore</summary>
        private static Result<TData> ReadEnvelope<TData>(string content, HttpStatusCode statusCode, string errorMessage)
        {
            if (statusCode == HttpStatusCode.Unauthorized || statusCode == HttpStatusCode.Forbidden)
            {
                return Result.Fail<TData>("کلید API نامعتبر است یا سرویس این فروشگاه غیرفعال/منقضی شده است.");
            }

            if (statusCode == 0)
            {
                return Result.Fail<TData>(
                    "ارتباط با سامانه برقرار نشد. آدرس سامانه، اجرا بودن آن و دسترسی شبکه را بررسی کنید.");
            }

            if (!string.IsNullOrWhiteSpace(content))
            {
                try
                {
                    var envelope = JsonSerializer.Deserialize<Result<TData>>(content, JsonOptions);

                    if (envelope != null)
                    {
                        return envelope;
                    }
                }
                catch (JsonException)
                {
                    // پاسخ، JSON معتبر نبود؛ پیام خطای شبکه برگردانده می‌شود
                }
            }

            return Result.Fail<TData>(
                $"ارتباط با سامانه ناموفق بود (کد {(int)statusCode}){Describe(errorMessage)}");
        }

        private static string Describe(string errorMessage)
        {
            return string.IsNullOrWhiteSpace(errorMessage) ? string.Empty : $" — {errorMessage}";
        }

        private static void Merge(SyncResultDto total, SyncResultDto part)
        {
            if (part == null)
            {
                return;
            }

            total.Created += part.Created;
            total.Updated += part.Updated;
            total.Unchanged += part.Unchanged;

            if (part.NotFound != null)
            {
                total.NotFound.AddRange(part.NotFound);
            }

            if (part.Warnings != null)
            {
                total.Warnings.AddRange(part.Warnings);
            }
        }

        public void Dispose()
        {
            _client?.Dispose();
        }

        #endregion

        public static OrderingSyncClient GetInstance()
        {
            var _setting = Form_Factory._Form_Factory_Order.GetSettings() as SettingItems;
#if DEBUG
	        return new OrderingSyncClient("http://localhost:5173/", _setting.ApiKey);
#else
			return new OrderingSyncClient("https://order.nikshaho.com/", _setting.ApiKey);
#endif
		}
	}

    /// <summary>کمکی برای خوانا کردن خطاهای پاسخ سامانه</summary>
    public static class ResultExtensions
    {
        /// <summary>
        /// تبدیل خطاهای Result سامانه به یک متن فارسی.
        /// سامانه خطاها را در دیکشنری Errors برمی‌گرداند که کلید آن ممکن است رشته خالی باشد.
        /// </summary>
        public static string ToErrorMessage(this Result result)
        {
            if (result == null)
            {
                return "پاسخ نامعتبر از سامانه دریافت شد.";
            }

            if (!string.IsNullOrWhiteSpace(result.Message))
            {
                return result.Message;
            }

            var messages = result.Errors == null
                ? null
                : result.Errors
                    .SelectMany(pair => pair.Value ?? new List<string>())
                    .Where(text => !string.IsNullOrWhiteSpace(text))
                    .ToList();

            return messages != null && messages.Count > 0
                ? string.Join(" | ", messages)
                : "عملیات در سامانه ناموفق بود.";
        }
    }
}
