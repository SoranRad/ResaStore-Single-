using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using SmsBan.Core;

namespace SmsBan.UI
{
	/// <summary>
	/// فرم تنظیمات ماژول ارسال پیامک.
	/// پس از تأیید، تنظیمات در خاصیت <see cref="Result"/> قابل دسترسی است.
	/// </summary>
	public class FormSettings : Form
	{
		private TextBox			_txtConnection;
		private TextBox			_txtMaxPerDay;
		private TextBox			_txtMaxPerMinute;
		private TextBox			_txtCharsPerPage;
		private TextBox			_txtReadInterval;
		private TextBox			_txtCountryCode;
		private TextBox			_txtMaxRetry;
		private TextBox			_txtSendInterval;
		private TextBox			_txtModemRetry;
		private TextBox			_txtValidity;
		private TextBox			_txtSmsCenter;

		private CheckBox		_chkIsModemHost;
		private CheckBox		_chkDeliveryReport;
		private CheckBox		_chkDeleteAfterRead;

		public SmsBanOptions	Result			{ get; private set; }

		public FormSettings(SmsBanOptions options)
		{
			Result = options ?? new SmsBanOptions();

			BuildUi();
			LoadOptions();
		}

		private void BuildUi()
		{
			Text			= "تنظیمات ماژول ارسال پیامک";
			RightToLeft		= RightToLeft.Yes;
			RightToLeftLayout = true;
			StartPosition	= FormStartPosition.CenterScreen;
			FormBorderStyle	= FormBorderStyle.FixedDialog;
			MaximizeBox		= false;
			MinimizeBox		= false;
			Font			= new Font("Tahoma", 9F);
			ClientSize		= new Size(560, 580);

			const int labelX	= 330;
			const int fieldX	= 30;
			const int fieldW	= 280;
			const int labelW	= 90;
			const int rowH		= 30;

			int y = 15;

			_txtConnection = AddConnectionField(y, labelX, fieldX, fieldW, labelW);
			y += 70;

			_txtMaxPerDay		= AddField("حداکثر پیامک روزانه",		ref y, rowH, labelX, fieldX, fieldW, labelW, "500");
			_txtMaxPerMinute	= AddField("حداکثر پیامک در دقیقه",	ref y, rowH, labelX, fieldX, fieldW, labelW, "50");
			_txtCharsPerPage	= AddField("حروف در هر صفحه",		ref y, rowH, labelX, fieldX, fieldW, labelW, "70");
			_txtReadInterval	= AddField("فاصله خواندن (دقیقه)",	ref y, rowH, labelX, fieldX, fieldW, labelW, "5");
			_txtCountryCode		= AddField("پیش‌شماره کشور",			ref y, rowH, labelX, fieldX, fieldW, labelW, "+98");
			_txtMaxRetry		= AddField("حداکثر بازگشت به صف",	ref y, rowH, labelX, fieldX, fieldW, labelW, "3");
			_txtSendInterval	= AddField("فاصله بخش‌های پیامک",	ref y, rowH, labelX, fieldX, fieldW, labelW, "0");
			_txtModemRetry		= AddField("تلاش مجدد مودم",			ref y, rowH, labelX, fieldX, fieldW, labelW, "0");
			_txtValidity		= AddField("مدت اعتبار پیامک",		ref y, rowH, labelX, fieldX, fieldW, labelW, "1");
			_txtSmsCenter		= AddField("مرکز پیامک (اختیاری)",	ref y, rowH, labelX, fieldX, fieldW, labelW, "");

			y += 5;

			_chkIsModemHost = AddCheck("این کامپیوتر به مودم وصل است", ref y, labelX, fieldX);
			_chkDeliveryReport = AddCheck("درخواست گزارش تحویل", ref y, labelX, fieldX);
			_chkDeleteAfterRead = AddCheck("حذف پیامک از مودم پس از خواندن", ref y, labelX, fieldX);

			var btnOk = new Button
			{
				Text		= "تأیید",
				Location	= new Point(30, 520),
				Size		= new Size(100, 32)
			};

			btnOk.Click += OnOk;

			var btnCancel = new Button
			{
				Text		= "انصراف",
				Location	= new Point(140, 520),
				Size		= new Size(100, 32),
				DialogResult = DialogResult.Cancel
			};

			Controls.Add(_txtConnection);
			Controls.Add(btnOk);
			Controls.Add(btnCancel);

			AcceptButton = btnOk;
			CancelButton = btnCancel;
		}

		private TextBox AddConnectionField(int y, int labelX, int fieldX, int fieldW, int labelW)
		{
			var label = new Label
			{
				Text		= "رشته اتصال",
				Location	= new Point(labelX, y),
				Size		= new Size(labelW, 22),
				TextAlign	= ContentAlignment.MiddleRight
			};

			var box = new TextBox
			{
				Location	= new Point(fieldX, y),
				Size		= new Size(fieldW, 60),
				Multiline	= true,
				ScrollBars	= ScrollBars.Vertical
			};

			Controls.Add(label);
			Controls.Add(box);

			return box;
		}

		private TextBox AddField(string caption, ref int y, int rowH, int labelX, int fieldX, int fieldW, int labelW, string defaultValue)
		{
			var label = new Label
			{
				Text		= caption,
				Location	= new Point(labelX, y + 3),
				Size		= new Size(labelW, 22),
				TextAlign	= ContentAlignment.MiddleRight
			};

			var box = new TextBox
			{
				Location	= new Point(fieldX, y),
				Size		= new Size(fieldW, 24),
				Text		= defaultValue
			};

			Controls.Add(label);
			Controls.Add(box);

			y += rowH;

			return box;
		}

		private CheckBox AddCheck(string caption, ref int y, int labelX, int fieldX)
		{
			var check = new CheckBox
			{
				Text		= caption,
				Location	= new Point(fieldX, y),
				Size		= new Size(400, 24),
				Checked		= true
			};

			Controls.Add(check);

			y += 28;

			return check;
		}

		private void LoadOptions()
		{
			_txtConnection.Text		= Result.ConnectionString;
			_txtMaxPerDay.Text		= Result.MaxSmsPerDay.ToString(CultureInfo.InvariantCulture);
			_txtMaxPerMinute.Text	= Result.MaxSmsPerMinute.ToString(CultureInfo.InvariantCulture);
			_txtCharsPerPage.Text	= Result.CharsPerPage.ToString(CultureInfo.InvariantCulture);
			_txtReadInterval.Text	= Result.ReadIntervalMinutes.ToString(CultureInfo.InvariantCulture);
			_txtCountryCode.Text	= Result.CountryCode;
			_txtMaxRetry.Text		= Result.MaxRetryCount.ToString(CultureInfo.InvariantCulture);
			_txtSendInterval.Text	= Result.SendInterval.ToString(CultureInfo.InvariantCulture);
			_txtModemRetry.Text		= Result.ModemRetryTimes.ToString(CultureInfo.InvariantCulture);
			_txtValidity.Text		= Result.SmsValidity.ToString(CultureInfo.InvariantCulture);
			_txtSmsCenter.Text		= Result.SmsCenter;

			_chkIsModemHost.Checked		= Result.IsModemHost;
			_chkDeliveryReport.Checked	= Result.RequestDeliveryReport;
			_chkDeleteAfterRead.Checked	= Result.DeleteAfterRead;
		}

		private void OnOk(object sender, EventArgs e)
		{
			try
			{
				Result.ConnectionString		= _txtConnection.Text.Trim();
				Result.MaxSmsPerDay			= ParseInt(_txtMaxPerDay,		"حداکثر پیامک روزانه");
				Result.MaxSmsPerMinute		= ParseInt(_txtMaxPerMinute,	"حداکثر پیامک در دقیقه");
				Result.CharsPerPage			= ParseInt(_txtCharsPerPage,	"حروف در هر صفحه");
				Result.ReadIntervalMinutes	= ParseInt(_txtReadInterval,	"فاصله خواندن");
				Result.MaxRetryCount		= ParseInt(_txtMaxRetry,		"حداکثر بازگشت به صف");
				Result.SendInterval			= ParseInt(_txtSendInterval,	"فاصله بخش‌های پیامک");
				Result.ModemRetryTimes		= ParseInt(_txtModemRetry,		"تلاش مجدد مودم");
				Result.SmsValidity			= ParseInt(_txtValidity,		"مدت اعتبار پیامک");

				Result.CountryCode			= _txtCountryCode.Text.Trim();
				Result.SmsCenter			= string.IsNullOrWhiteSpace(_txtSmsCenter.Text)
												  ? null
												  : _txtSmsCenter.Text.Trim();

				Result.IsModemHost			= _chkIsModemHost.Checked;
				Result.RequestDeliveryReport = _chkDeliveryReport.Checked;
				Result.DeleteAfterRead		= _chkDeleteAfterRead.Checked;

				Result.Validate();

				DialogResult = DialogResult.OK;
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, "خطا در تنظیمات",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private static int ParseInt(TextBox box, string caption)
		{
			int value;

			if (!int.TryParse(box.Text.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out value))
				throw new FormatException(string.Format("مقدار «{0}» عددی نیست.", caption));

			if (value < 0)
				throw new FormatException(string.Format("مقدار «{0}» نمی‌تواند منفی باشد.", caption));

			return value;
		}
	}
}
