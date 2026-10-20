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
		private TextBox			_txtCountryCode;
		private TextBox			_txtDeviceNumber;
		private TextBox			_txtPartInterval;
		private TextBox			_txtModemRetry;
		private TextBox			_txtSmsCenter;
		private TextBox			_txtReadInterval;
		private TextBox			_txtMaxRetry;

		private ComboBox		_cmbValidity;

		private CheckBox		_chkIsModemHost;
		private CheckBox		_chkDeliveryReport;
		private CheckBox		_chkDeleteAfterRead;

		/// <summary>مدت اعتبارهای قابل انتخاب، هم‌ترتیب با <see cref="SmsValidityPeriod"/>.</summary>
		private static readonly string[] ValidityCaptions =
		{
			"۱ ساعت",
			"۳ ساعت",
			"۶ ساعت",
			"۱۲ ساعت",
			"۲۴ ساعت",
			"۱ هفته",
			"حداکثر"
		};

		public SmsBanOptions	Result			{ get; private set; }

		public FormSettings(SmsBanOptions options)
		{
			Result = options ?? new SmsBanOptions();

			BuildUi();
			LoadOptions();
		}

		private void BuildUi()
		{
			Text				= "تنظیمات ماژول ارسال پیامک";
			RightToLeft			= RightToLeft.Yes;
			RightToLeftLayout	= true;
			StartPosition		= FormStartPosition.CenterScreen;
			FormBorderStyle		= FormBorderStyle.FixedDialog;
			MaximizeBox			= false;
			MinimizeBox			= false;
			Font				= new Font("Tahoma", 9F);
			ClientSize			= new Size(580, 640);

			const int labelX	= 350;
			const int fieldX	= 30;
			const int fieldW	= 290;
			const int labelW	= 90;
			const int rowH		= 30;

			int y = 15;

			_txtConnection = AddConnectionField(y, labelX, fieldX, fieldW, labelW);
			y += 70;

			// ---- سهمیه ----
			_txtMaxPerDay		= AddField("حداکثر پیامک روزانه",		ref y, rowH, labelX, fieldX, fieldW, labelW, "500");
			_txtMaxPerMinute	= AddField("حداکثر پیامک در دقیقه",	ref y, rowH, labelX, fieldX, fieldW, labelW, "50");
			_txtCharsPerPage	= AddField("حروف در هر صفحه",		ref y, rowH, labelX, fieldX, fieldW, labelW, "70");

			// ---- شماره و مودم ----
			_txtCountryCode		= AddField("پیش‌شماره کشور",			ref y, rowH, labelX, fieldX, fieldW, labelW, "98");
			_txtDeviceNumber		= AddField("شماره دستگاه",				ref y, rowH, labelX, fieldX, fieldW, labelW, "1");

			// ---- پارامترهای ارسال ----
			_cmbValidity = AddCombo("مدت اعتبار پیامک", ref y, rowH, labelX, fieldX, fieldW, labelW, ValidityCaptions);

			_txtPartInterval	= AddField("تاخیر بین بخش‌ها (ms)",	ref y, rowH, labelX, fieldX, fieldW, labelW, "1000");
			_txtModemRetry		= AddField("تلاش مجدد مودم",			ref y, rowH, labelX, fieldX, fieldW, labelW, "2");
			_txtSmsCenter		= AddField("مرکز پیامک (اختیاری)",	ref y, rowH, labelX, fieldX, fieldW, labelW, "");

			// ---- صف و اجرا ----
			_txtReadInterval	= AddField("فاصله خواندن (دقیقه)",	ref y, rowH, labelX, fieldX, fieldW, labelW, "5");
			_txtMaxRetry		= AddField("بازگشت به صف پس از خطا",	ref y, rowH, labelX, fieldX, fieldW, labelW, "3");

			y += 5;

			_chkIsModemHost		= AddCheck("این کامپیوتر به مودم وصل است",	ref y, labelX, fieldX);
			_chkDeliveryReport	= AddCheck("درخواست گزارش تحویل",			ref y, labelX, fieldX);
			_chkDeleteAfterRead	= AddCheck("حذف پیامک از مودم پس از خواندن", ref y, labelX, fieldX);

			var btnOk = new Button
			{
				Text		= "تأیید",
				Location	= new Point(30, 570),
				Size		= new Size(100, 32)
			};

			btnOk.Click += OnOk;

			var btnCancel = new Button
			{
				Text		= "انصراف",
				Location	= new Point(140, 570),
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

		private ComboBox AddCombo(string caption, ref int y, int rowH, int labelX, int fieldX, int fieldW, int labelW, string[] items)
		{
			var label = new Label
			{
				Text		= caption,
				Location	= new Point(labelX, y + 3),
				Size		= new Size(labelW, 22),
				TextAlign	= ContentAlignment.MiddleRight
			};

			var combo = new ComboBox
			{
				Location		= new Point(fieldX, y),
				Width			= fieldW,
				DropDownStyle	= ComboBoxStyle.DropDownList,
				RightToLeft		= RightToLeft.Yes
			};

			combo.Items.AddRange(items);

			Controls.Add(label);
			Controls.Add(combo);

			y += rowH;

			return combo;
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
			_txtCountryCode.Text	= Result.CountryCode;
			_txtDeviceNumber.Text	= Result.DeviceNumber.ToString(CultureInfo.InvariantCulture);
			_txtPartInterval.Text	= Result.PartSendIntervalMs.ToString(CultureInfo.InvariantCulture);
			_txtModemRetry.Text		= Result.ModemRetryCount.ToString(CultureInfo.InvariantCulture);
			_txtSmsCenter.Text		= Result.SmsCenter;
			_txtReadInterval.Text	= Result.ReadIntervalMinutes.ToString(CultureInfo.InvariantCulture);
			_txtMaxRetry.Text		= Result.MaxRetryCount.ToString(CultureInfo.InvariantCulture);

			var validityIndex = Result.SmsValidity - 1;

			if (validityIndex < 0 || validityIndex >= ValidityCaptions.Length)
				validityIndex = 0;

			_cmbValidity.SelectedIndex = validityIndex;

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
				Result.DeviceNumber			= ParseInt(_txtDeviceNumber,		"شماره دستگاه");
				Result.PartSendIntervalMs	= ParseInt(_txtPartInterval,	"تاخیر بین بخش‌ها");
				Result.ModemRetryCount		= ParseInt(_txtModemRetry,		"تلاش مجدد مودم");
				Result.ReadIntervalMinutes	= ParseInt(_txtReadInterval,	"فاصله خواندن");
				Result.MaxRetryCount		= ParseInt(_txtMaxRetry,		"بازگشت به صف پس از خطا");

				// اندیس صفر یعنی «۱ ساعت» که مقدار ۱ را می‌دهد.
				Result.SmsValidity			= _cmbValidity.SelectedIndex + 1;

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
