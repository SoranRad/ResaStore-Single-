using System;
using System.Globalization;
using System.Windows.Forms;
using MS_Control;
using MS_Control.MainForms;
using SmsBan.Core;

namespace SmsBan.UI
{
	/// <summary>
	/// فرم تنظیمات ماژول ارسال پیامک.
	/// پس از تأیید، تنظیمات در خاصیت <see cref="Result"/> قابل دسترسی است.
	///
	/// این فرم به روش استاندارد ویژوال استودیو نوشته شده است:
	/// کد رابط کاربری در فایل <c>FormSettings.Designer.cs</c> قرار دارد
	/// و از طریق Designer قابل ویرایش است.
	/// </summary>
	public partial class FormSettings : Form_Mother_IRANSans
	{
		#region Logging

		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
				(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		#endregion

		#region Fields

		/// <summary>گزینه‌هایی که قرار است ویرایش شوند.</summary>
		public SmsBanOptions Result { get; private set; }
		#endregion

		#region Constructor

		public FormSettings(SmsBanOptions options)
		{
			Result = options ?? new SmsBanOptions();

			InitializeComponent();

			LoadOptions();
		}
		#endregion

		#region Methods

		/// <summary>نمایش مقادیر فعلی در کنترل‌ها.</summary>
		private void LoadOptions()
		{
			txtConnection.Text		= Result.ConnectionString;
			txtMaxPerDay.Text		= Result.MaxSmsPerDay.ToString(CultureInfo.InvariantCulture);
			txtMaxPerMinute.Text	= Result.MaxSmsPerMinute.ToString(CultureInfo.InvariantCulture);
			txtCharsPerPage.Text	= Result.CharsPerPage.ToString(CultureInfo.InvariantCulture);
			txtCountryCode.Text		= Result.CountryCode;
			txtDeviceNumber.Text	= Result.DeviceNumber.ToString(CultureInfo.InvariantCulture);
			txtPartInterval.Text	= Result.PartSendIntervalMs.ToString(CultureInfo.InvariantCulture);
			txtModemRetry.Text		= Result.ModemRetryCount.ToString(CultureInfo.InvariantCulture);
			txtSmsCenter.Text		= Result.SmsCenter;
			txtReadInterval.Text	= Result.ReadIntervalMinutes.ToString(CultureInfo.InvariantCulture);
			txtMaxRetry.Text		= Result.MaxRetryCount.ToString(CultureInfo.InvariantCulture);

			// مدت اعتبار: اندیس صفر یعنی «۱ ساعت» که مقدار عددی ۱ را دارد.
			var validityIndex = Result.SmsValidity - 1;

			if (validityIndex < 0 || validityIndex >= cmbValidity.Items.Count)
				validityIndex = cmbValidity.Items.Count - 1;

			cmbValidity.SelectedIndex = validityIndex;

			chkIsModemHost.Checked		= Result.IsModemHost;
			chkDeliveryReport.Checked	= Result.RequestDeliveryReport;
			chkDeleteAfterRead.Checked	= Result.DeleteAfterRead;
		}

		/// <summary>خواندن مقادیر از کنترل‌ها، اعتبارسنجی و بستن فرم.</summary>
		private void SaveOptions()
		{
			Result.ConnectionString		= txtConnection.Text.Trim();
			Result.MaxSmsPerDay			= ParseInt(txtMaxPerDay,		"حداکثر پیامک روزانه");
			Result.MaxSmsPerMinute		= ParseInt(txtMaxPerMinute,		"حداکثر پیامک در دقیقه");
			Result.CharsPerPage			= ParseInt(txtCharsPerPage,		"حروف در هر صفحه");
			Result.DeviceNumber			= ParseInt(txtDeviceNumber,		"شماره دستگاه");
			Result.PartSendIntervalMs	= ParseInt(txtPartInterval,		"تاخیر بین بخش‌ها");
			Result.ModemRetryCount		= ParseInt(txtModemRetry,		"تلاش مجدد مودم");
			Result.ReadIntervalMinutes	= ParseInt(txtReadInterval,		"فاصله خواندن");
			Result.MaxRetryCount		= ParseInt(txtMaxRetry,			"بازگشت به صف پس از خطا");

			Result.SmsValidity			= cmbValidity.SelectedIndex + 1;

			Result.CountryCode			= txtCountryCode.Text.Trim();
			Result.SmsCenter			= string.IsNullOrWhiteSpace(txtSmsCenter.Text)
											  ? null
											  : txtSmsCenter.Text.Trim();

			Result.IsModemHost			= chkIsModemHost.Checked;
			Result.RequestDeliveryReport = chkDeliveryReport.Checked;
			Result.DeleteAfterRead		= chkDeleteAfterRead.Checked;

			Result.Validate();
		}

		private static int ParseInt(MS_Control.Controls.MS_TextBox box, string caption)
		{
			int value;

			if (!int.TryParse(box.Text.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out value))
				throw new FormatException(string.Format("مقدار «{0}» عددی نیست.", caption));

			if (value < 0)
				throw new FormatException(string.Format("مقدار «{0}» نمی‌تواند منفی باشد.", caption));

			return value;
		}
		#endregion

		#region Event Handlers

		private void btnOk_Click(object sender, EventArgs e)
		{
			try
			{
				SaveOptions();

				DialogResult = DialogResult.OK;
				Close();
			}
			catch (Exception ex)
			{
				log.Error(ex);

				MS_Message.Show(this, "خطا در تنظیمات", "خطا در تنظیمات", ex.Message, MessageBoxButtons.OK);
			}
		}
		#endregion
	}
}
