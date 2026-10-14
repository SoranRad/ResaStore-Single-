# اتصال نرم‌افزار حسابداری به «سامانه ثبت سفارش رسا»

این پوشه شامل کدهای آماده برای **ارسال گروه‌های کالا، کالاها و موجودی** از نرم‌افزار حسابداری
(WinForms / .NET Framework 4.8 / RestSharp) به سامانه ثبت سفارش است.

---

## فایل‌ها

| فایل | کاربرد |
|---|---|
| `OrderingSyncModels.cs` | مدل‌های درخواست و پاسخ + مبدل کد گروه (`short` ← `string`) |
| `OrderingSyncClient.cs` | کلاینت RestSharp برای سه عملیات + آزمایش اتصال |
| `AccountingReader.cs` | خواندن گروه‌ها، کالاها و موجودی از دیتابیس حسابداری |
| `SyncForm.Example.cs` | نمونه فرم WinForms آماده (بدون Designer) |

---

## نصب پکیج‌ها

```
Install-Package RestSharp              -Version 113.0.0
Install-Package TwentyDevs.ResultCore  -Version 1.0.21
Install-Package System.Text.Json       -Version 10.0.0
```

> ⚠️ **نکته مهم:** `RestSharp 113` خودش به `System.Text.Json >= 10.0.0` نیاز دارد.
> اگر نسخه کمتری بگذارید خطای `NU1605` (package downgrade) می‌گیرید.
> این پکیج روی `net48` کار می‌کند و `TwentyDevs.ResultCore` هم روی `netstandard2.0` است.

> اگر خطای نسخه اسمبلی گرفتید، در فایل پروژه این دو گزینه را فعال کنید:
> ```xml
> <AutoGenerateBindingRedirects>true</AutoGenerateBindingRedirects>
> <GenerateBindingRedirectsOutputType>true</GenerateBindingRedirectsOutputType>
> ```

---

## سرویس‌های سامانه

همه با هدر **`X-Api-Key: <کلید API فروشگاه>`** و بدون ورود کاربر.

| عملیات | متد و مسیر | بدنه |
|---|---|---|
| گروه‌های کالا | `POST /api/sync/categories/import` | `{ "categories": [ { "code": "100", "title": "نوشیدنی‌ها", "isActive": true } ] }` |
| کالاها | `POST /api/sync/products/import` | `{ "products": [ { "code": 5001, "name": "…", "categoryCode": "400", "unitOfMeasure": "عدد", "partnershipPrice": 1000, "retailPrice": 1500, "wholesalePrice": 1200, "discountPrice": 1400 } ] }` |
| موجودی و نرخ | `POST /api/sync/stock` | `{ "stockDate": "2026-10-05T18:04:57.000Z", "items": [ { "code": 1002, "quantity": 800, …نرخ‌ها } ] }` |
| آزمایش اتصال | `GET /api/sync/orders?take=1` | — |

پاسخ همه سرویس‌ها با ساختار یکسان زیر برمی‌گردد که کتابخانه `ResultCore` آن را مستقیم
در `Result<T>` می‌نشاند:

```json
{ "data": { "created": 1, "updated": 2, "unchanged": 0, "notFound": [], "warnings": [] },
  "message": null, "redirect": null, "isSuccess": true, "errors": {} }
```

---

## کلید API فروشگاه

از پنل **مدیر کل** → فروشگاه‌ها → دکمه تولید کلید API.
معادل سرویسی: `POST /api/stores/{id}/api-key`

---

## روش استفاده

```csharp
// یک‌بار بسازید و در طول عمر برنامه نگه دارید (توصیه خود RestSharp)
using (var client = new OrderingSyncClient("http://localhost:5088", apiKey))
{
    var reader = new AccountingReader(connectionString);

    // ۱) گروه‌ها
    var categories = reader.ReadCategories();
    var r1 = await client.ImportCategoriesAsync(categories);

    // ۲) کالاها
    var products = reader.ReadProducts();
    var r2 = await client.ImportProductsAsync(products);

    // ۳) موجودی و نرخ‌ها
    var readAt = DateTimeOffset.UtcNow;      // لحظه خواندن از حسابداری
    var stock  = reader.ReadStock();
    var r3 = await client.PushStockAsync(stock, readAt);
}
```

### ترتیب الزامی
**گروه‌ها → کالاها → موجودی.** اگر کالایی به گروهی اشاره کند که در سامانه نیست، سامانه آن گروه را
خودکار می‌سازد و در `warnings` گزارش می‌دهد.

---

## نکات مهم

### ۱) کد گروه از نوع `short` است
در سامانه، کد گروه به‌صورت **رشته** ذخیره می‌شود. مبدل‌های `ShortAsStringConverter` و
`NullableShortAsStringConverter` این تبدیل را خودکار انجام می‌دهند؛ بنابراین در JSON
به‌صورت `"code": "100"` نوشته می‌شود. کد کالا در سامانه **عددی** است و بدون تغییر می‌رود.

### ۲) تاریخ موجودی (`stockDate`)
سامانه موجودی قابل استفاده را این‌گونه محاسبه می‌کند:

```
موجودی قابل استفاده = موجودی مبنا (عدد حسابداری)
                     − سفارش‌های منصرف‌نشده‌ای که در مبنا لحاظ نشده‌اند
```

پس `stockDate` باید **لحظه خواندن از دیتابیس حسابداری** باشد. توصیه: این زمان را **پیش از**
خواندن دیتابیس بگیرید و همان را بفرستید (در کد نمونه همین کار انجام شده است).

- نرخ‌ها برای **همه** کالاها به‌روز می‌شود.
- تعداد موجودی فقط برای کالاهایی که در سامانه **تیک کنترل موجودی** دارند اعمال می‌شود.

### ۳) ارسال دسته‌ای
کلاینت به‌صورت خودکار هر ۵۰۰ ردیف را در یک درخواست می‌فرستد (`batchSize` در سازنده قابل تغییر است).

### ۴) نسخه RestSharp
کد برای **RestSharp 107 به بعد (شامل ۱۱۳)** نوشته شده است:
- `new RestClient(RestClientOptions)`
- `AddStringBody(json, ContentType.Json)` برای بدنه JSON رشته‌ای
- `ExecuteAsync(request, cancellationToken)` که `RestResponse` برمی‌گرداند

> `MaxTimeout` در نسخه ۱۱۳ حذف شده؛ فقط از `Timeout` استفاده شده است.

### ۵) تطبیق با اسکیمای حسابداری
فقط **یک فایل** نیاز به تغییر دارد: `AccountingReader.cs`
سه کوئری بالای فایل با بنر `TODO(اسکیمای حسابداری)` علامت‌گذاری شده‌اند. نام ستون‌هایی که با
`AS` نام‌گذاری شده‌اند را عوض نکنید، چون کد با همان نام‌ها مقدار می‌خواند.

---

## قدم بعدی
ارسال سفارش‌های سامانه به‌صورت **فاکتور فروش** در نرم‌افزار حسابداری
(سرویس `GET /api/sync/orders` و ثبت نتیجه با `/ack` و `/fail`).

---

## وضعیت تأیید (تست‌شده)

این کد با **.NET Framework 4.8 + RestSharp 113.0.0 + TwentyDevs.ResultCore 1.0.21 + System.Text.Json 10.0.0**
کامپایل شد (۰ خطا / ۰ هشدار) و روی سامانه واقعی اجرا و تأیید شد:

| عملیات | نتیجه واقعی |
|---|---|
| آزمایش اتصال | ✅ «ارتباط با سامانه برقرار است و کلید API معتبر است.» |
| ارسال گروه‌ها (کد `short`) | ✅ ایجاد ۲ گروه / بدون تغییر |
| ارسال کالاها با کد گروه `short` | ✅ ایجاد و به‌روزرسانی کالاها |
| ارسال موجودی و نرخ‌ها | ✅ به‌روزرسانی + گزارش کد یافت‌نشده |
| کلید API نامعتبر | ✅ رد شد با پیام «کلید API نامعتبر است یا سرویس این فروشگاه غیرفعال/منقضی شده است.» |

### قالب JSON که کلاینت می‌فرستد (نمونه واقعی)
```json
{
  "categories": [ { "code": "700", "title": "گروه آزمایشی ۷۰۰", "isActive": true } ]
}
```
```json
{
  "products": [ { "code": 9001, "name": "کالای آزمایشی ۹۰۰۱", "categoryCode": "700",
                  "unitOfMeasure": "عدد", "partnershipPrice": 1111, "retailPrice": 2222,
                  "wholesalePrice": 1500, "discountPrice": 2000, "description": null } ]
}
```
```json
{
  "stockDate": "2026-10-06T06:34:00.000Z",
  "items": [ { "code": 9001, "quantity": 120, "partnershipPrice": 1200,
               "retailPrice": 2400, "wholesalePrice": 1600, "discountPrice": 2100 } ]
}
```

### پاسخ سامانه
پاسخ‌ها با نام‌های **PascalCase** (`Data`، `IsSuccess`، `Errors`، `Message`) برمی‌گردند،
اما کلاینت با تنظیم `JsonSerializerDefaults.Web` **بی‌تفاوت به بزرگی/کوچکی حروف** است،
پس هر دو حالت camelCase و PascalCase درست خوانده می‌شود.

---

## قواعد ایجاد، ویرایش و حذف

### گروه‌های کالا
| عملیات | رفتار سامانه |
|---|---|
| **ایجاد/ویرایش** (`categories/import`) | اگر گروه با همان **کد** موجود باشد **ویرایش** می‌شود، وگرنه **ایجاد** می‌شود |
| **خواندن** (`GET categories`) | فهرست گروه‌ها با `productCount` (تعداد کالاهای هر گروه) |
| **حذف** (`categories/delete`) | اگر گروه **کالای مرتبط** داشته باشد حذف **نمی‌شود** و دلیل آن در `blocked` برمی‌گردد |

```csharp
// خواندن گروه‌های سامانه
var categories = await client.GetCategoriesAsync();

foreach (var category in categories.Data)
{
    Console.WriteLine($"{category.Code} | {category.Title} | {category.ProductCount} کالا");
}

// حذف گروه‌هایی که در حسابداری حذف شده‌اند
var result = await client.DeleteCategoriesAsync(new[] { "880", "881" });

foreach (var blocked in result.Data.Blocked)
{
    Console.WriteLine($"گروه {blocked.Code} حذف نشد: {blocked.Reason}");
}
```

### کالاها
| عملیات | رفتار سامانه |
|---|---|
| **ایجاد/ویرایش** (`products/import`) | اگر کالا با همان **کد** موجود باشد **ویرایش** می‌شود، وگرنه **ایجاد** می‌شود |
| **خواندن** (`GET products`) | فهرست کامل کالاها با همه مشخصات: نرخ‌های چهارگانه، موجودی مبنا و قابل استفاده، بسته بندی، تصاویر و `orderCount` |
| **حذف** (`products/delete`) | اگر کالا **در سفارش‌ها استفاده شده** باشد حذف **نمی‌شود** و دلیل آن در `blocked` برمی‌گردد |

```csharp
// خواندن همه کالاهای سامانه
var products = await client.GetProductsAsync();

foreach (var product in products.Data)
{
    Console.WriteLine($"{product.Code} | {product.Name} | موجودی: {product.AvailableStock} | سفارش‌ها: {product.OrderCount}");
}

// حذف کالاهایی که در حسابداری حذف شده‌اند
var result = await client.DeleteProductsAsync(new[] { 9001, 9002 });

foreach (var blocked in result.Data.Blocked)
{
    Console.WriteLine($"کالا {blocked.Code} حذف نشد: {blocked.Reason}");
}
```

> **نکته بسته بندی:** اگر در `SyncProductDto` مقدار `PackagingUnit` و `ConversionFactor` را `null` بگذارید،
> تنظیمات بسته بندی داخل سامانه **دست‌نخورده** می‌ماند. فقط وقتی مقداری بفرستید تغییر می‌کند.

### نتیجه حذف گروهی
```json
{ "deleted": 2,
  "notFound": ["999"],
  "blocked": [ { "code": "100", "reason": "این گروه 3 کالای مرتبط دارد و قابل حذف نیست." } ] }
```
