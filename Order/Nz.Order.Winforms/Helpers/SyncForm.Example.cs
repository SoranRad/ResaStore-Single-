using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nz.Order.Winforms.Helpers;
using TwentyDevs.ResultCore;

namespace ResaAccounting.Sync
{
    /// <summary>
    /// نمونه فرم آماده برای انتقال گروه‌ها، کالاها و موجودی به سامانه ثبت سفارش رسا.
    /// <para>
    /// این فرم کاملاً با کد ساخته شده است (بدون Designer) تا بتوانید مستقیم به پروژه WinForms
    /// خود اضافه کنید. در پروژه واقعی، سه مقدار آدرس سامانه، کلید API و رشته اتصال را از
    /// فرم تنظیمات برنامه خودتان بخوانید.
    /// </para>
    /// </summary>
    public class SyncForm : Form
    {
        private readonly TextBox _txtBaseUrl = new TextBox();
        private readonly TextBox _txtApiKey = new TextBox();
        private readonly TextBox _txtConnectionString = new TextBox();
        private readonly TextBox _txtLog = new TextBox();

        private readonly Button _btnTest = new Button();
        private readonly Button _btnCategories = new Button();
        private readonly Button _btnProducts = new Button();
        private readonly Button _btnStock = new Button();

        /// <summary>طبق توصیه RestSharp، کلاینت یک‌بار ساخته و در طول عمر فرم نگه داشته می‌شود.</summary>
        private OrderingSyncClient _client;

        public SyncForm()
        {
            BuildUi();

            Load += (sender, args) => ResetClient();
            FormClosing += (sender, args) => _client?.Dispose();
        }

        // ============================================================================================
        // ساخت رابط کاربری
        // ============================================================================================

        private void BuildUi()
        {
            Text = "انتقال اطلاعات به سامانه ثبت سفارش رسا";
            ClientSize = new Size(780, 620);
            StartPosition = FormStartPosition.CenterScreen;
            RightToLeft = RightToLeft.Yes;
            Font = new Font("Tahoma", 9F);

            var lblBaseUrl = MakeLabel("آدرس سامانه:", 20);
            _txtBaseUrl.SetBounds(20, 50, 740, 26);
            _txtBaseUrl.Text = "http://localhost:5088";

            var lblApiKey = MakeLabel("کلید API فروشگاه:", 90);
            _txtApiKey.SetBounds(20, 120, 740, 26);
            _txtApiKey.UseSystemPasswordChar = true;

            var lblCs = MakeLabel("رشته اتصال دیتابیس حسابداری:", 160);
            _txtConnectionString.SetBounds(20, 190, 740, 26);
            _txtConnectionString.Text = @"Server=.\SQLENTR;Database=Hesabdar;Integrated Security=True;";

            _btnTest.SetBounds(620, 235, 140, 32);
            _btnTest.Text = "آزمایش اتصال";
            _btnTest.Click += async (sender, args) => await TestAsync();

            _btnCategories.SetBounds(470, 235, 140, 32);
            _btnCategories.Text = "۱) ارسال گروه‌ها";
            _btnCategories.Click += async (sender, args) => await SendCategoriesAsync();

            _btnProducts.SetBounds(320, 235, 140, 32);
            _btnProducts.Text = "۲) ارسال کالاها";
            _btnProducts.Click += async (sender, args) => await SendProductsAsync();

            _btnStock.SetBounds(170, 235, 140, 32);
            _btnStock.Text = "۳) ارسال موجودی";
            _btnStock.Click += async (sender, args) => await SendStockAsync();

            _txtLog.SetBounds(20, 285, 740, 315);
            _txtLog.Multiline = true;
            _txtLog.ScrollBars = ScrollBars.Vertical;
            _txtLog.ReadOnly = true;
            _txtLog.BackColor = Color.White;
            _txtLog.Font = new Font("Consolas", 9F);

            Controls.AddRange(new Control[]
            {
                lblBaseUrl, _txtBaseUrl,
                lblApiKey, _txtApiKey,
                lblCs, _txtConnectionString,
                _btnTest, _btnCategories, _btnProducts, _btnStock,
                _txtLog
            });
        }

        private static Label MakeLabel(string text, int top)
        {
            var label = new Label
            {
                Text = text,
                TextAlign = ContentAlignment.MiddleRight
            };

            label.SetBounds(20, top, 740, 22);

            return label;
        }

        // ============================================================================================
        // عملیات
        // ============================================================================================

        private void ResetClient()
        {
            _client?.Dispose();
            _client = null;

            try
            {
                _client = new OrderingSyncClient(_txtBaseUrl.Text, _txtApiKey.Text);
            }
            catch (Exception exception)
            {
                Log("تنظیمات نامعتبر: " + exception.Message);
            }
        }

        private async Task TestAsync()
        {
            if (!TryGetClient(out var client))
            {
                return;
            }

            SetBusy(true);
            Log("=== آزمایش اتصال ===");

            try
            {
                var result = await client.TestConnectionAsync();

                if (result.IsSuccess)
                {
                    Log("موفق — " + result.Message);

                    MessageBox.Show(result.Message, "آزمایش اتصال", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    var message = result.ToErrorMessage();

                    Log("ناموفق: " + message);

                    MessageBox.Show(message, "آزمایش اتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exception)
            {
                Log("خطا: " + exception.Message);

                MessageBox.Show(exception.Message, "آزمایش اتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetBusy(false);
            }
        }

        private async Task SendCategoriesAsync()
        {
            if (!TryGetClient(out var client) || !TryGetReader(out var reader))
            {
                return;
            }

            await RunAsync("ارسال گروه‌های کالا", async token =>
            {
                var categories = reader.ReadCategories();

                if (categories.Count == 0)
                {
                    return Result.Fail<SyncResultDto>("گروه کالایی برای ارسال یافت نشد.");
                }

                return await client.ImportCategoriesAsync(categories, token);
            });
        }

        private async Task SendProductsAsync()
        {
            if (!TryGetClient(out var client) || !TryGetReader(out var reader))
            {
                return;
            }

            await RunAsync("ارسال کالاها", async token =>
            {
                var products = reader.ReadProducts();

                if (products.Count == 0)
                {
                    return Result.Fail<SyncResultDto>("کالایی برای ارسال یافت نشد.");
                }

                return await client.ImportProductsAsync(products, token);
            });
        }

        private async Task SendStockAsync()
        {
            if (!TryGetClient(out var client) || !TryGetReader(out var reader))
            {
                return;
            }

            await RunAsync("ارسال موجودی و نرخ‌ها", async token =>
            {
                // تاریخ موجودی = لحظه خواندن از حسابداری (پیش از خواندن گرفته می‌شود)
                var readAt = DateTimeOffset.UtcNow;

                var stock = reader.ReadStock();

                if (stock.Count == 0)
                {
                    return Result.Fail<SyncResultDto>("موجودی‌ای برای ارسال یافت نشد.");
                }

                return await client.PushStockAsync(stock, readAt, token);
            });
        }

        // ============================================================================================
        // اجرای یکنواخت عملیات سینک
        // ============================================================================================

        private async Task RunAsync(
            string title,
            Func<CancellationToken, Task<Result<SyncResultDto>>> operation)
        {
            SetBusy(true);
            Log("=== " + title + " ===");

            try
            {
                var result = await operation(CancellationToken.None);

                if (!result.IsSuccess)
                {
                    var message = result.ToErrorMessage();

                    Log("ناموفق: " + message);

                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                var summary = result.Data != null ? result.Data.ToPersianSummary() : "انجام شد.";

                Log("موفق — " + summary);

                if (result.Data != null && result.Data.Warnings != null && result.Data.Warnings.Count > 0)
                {
                    foreach (var warning in result.Data.Warnings)
                    {
                        Log("هشدار: " + warning);
                    }
                }

                MessageBox.Show(summary, title + " — موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                Log("خطا: " + exception.Message);

                MessageBox.Show(exception.Message, title + " — خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetBusy(false);
            }
        }

        private void SetBusy(bool busy)
        {
            UseWaitCursor = busy;
            _btnTest.Enabled = !busy;
            _btnCategories.Enabled = !busy;
            _btnProducts.Enabled = !busy;
            _btnStock.Enabled = !busy;
        }

        private bool TryGetClient(out OrderingSyncClient client)
        {
            if (_client == null)
            {
                ResetClient();
            }

            client = _client;

            if (client == null)
            {
                MessageBox.Show("آدرس سامانه و کلید API فروشگاه را وارد کنید.", "تنظیمات",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return client != null;
        }

        private bool TryGetReader(out AccountingReader reader)
        {
            reader = null;

            try
            {
                reader = new AccountingReader(_txtConnectionString.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "رشته اتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            if (!reader.TestConnection(out var error))
            {
                MessageBox.Show("اتصال به دیتابیس حسابداری برقرار نشد: " + error, "دیتابیس",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                reader = null;

                return false;
            }

            return true;
        }

        private void Log(string message)
        {
            _txtLog.AppendText(DateTime.Now.ToString("HH:mm:ss") + "  " + message + Environment.NewLine);
        }
    }
}
