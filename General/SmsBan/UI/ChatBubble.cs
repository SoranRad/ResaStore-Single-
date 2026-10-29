using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SmsBan.UI
{
	/// <summary>
	/// یک حباب (بالن) پیام به سبک پیام‌رسان‌های اندرویدی.
	///
	/// متن پیام و ریز اطلاعات (تاریخ، وضعیت تحویل و تعداد پارت) داخل حباب
	/// رسم می‌شوند. رنگ حباب برای پیام‌های ارسالی و دریافتی متفاوت است.
	/// </summary>
	public class ChatBubble : Control
	{
		#region Constants

		private const int PadX			= 12;
		private const int PadY			= 8;
		private const int Gap			= 4;
		private const int MinWidth		= 150;
		private const int MaxTextWidth	= 430;
		private const int Radius		= 10;
		#endregion

		#region Fields

		private Font	_metaFont;
		private int		_textHeight;

		private static readonly Color OutgoingBack		= Color.FromArgb(220, 248, 198);
		private static readonly Color OutgoingBorder	= Color.FromArgb(175, 220, 145);
		private static readonly Color IncomingBack		= Color.White;
		private static readonly Color IncomingBorder	= Color.FromArgb(215, 215, 215);
		private static readonly Color SelectedBorder	= Color.FromArgb(255, 140, 0);
		private static readonly Color TextColor			= Color.FromArgb(30, 30, 30);
		private static readonly Color MetaColor			= Color.FromArgb(120, 120, 120);
		#endregion

		#region Properties

		/// <summary>شناسه‌ی پیام در بانک اطلاعاتی.</summary>
		public long		MessageId	{ get; set; }

		/// <summary>true یعنی پیام ارسالی (سمت راست)، false یعنی دریافتی (سمت چپ).</summary>
		public bool		IsOutgoing	{ get; set; }

		public string	MessageText	{ get; set; }

		/// <summary>ریز اطلاعات: تاریخ، تحویل، تعداد پارت.</summary>
		public string	MetaText	{ get; set; }

		public bool		IsSelected	{ get; set; }
		#endregion

		#region Constructor

		public ChatBubble()
		{
			SetStyle(
				ControlStyles.UserPaint |
				ControlStyles.AllPaintingInWmPaint |
				ControlStyles.OptimizedDoubleBuffer |
				ControlStyles.ResizeRedraw |
				ControlStyles.SupportsTransparentBackColor,
				true);

			BackColor	= Color.Transparent;
			Cursor		= Cursors.Hand;
			Font		= new Font("IRANSans(Small)", 11F);
		}
		#endregion

		#region Layout

		/// <summary>
		/// محاسبه‌ی اندازه‌ی حباب بر اساس حداکثر عرض در دسترس.
		/// پس از فراخوانی، عرض و ارتفاع کنترل تنظیم می‌شود.
		/// </summary>
		public void Relayout(int maxBubbleWidth)
		{
			EnsureMetaFont();

			var available = Math.Min(MaxTextWidth, Math.Max(120, maxBubbleWidth - PadX * 2));

			var textSize = TextRenderer.MeasureText(
				MessageText ?? string.Empty,
				Font,
				new Size(available, int.MaxValue),
				TextFormatFlags.WordBreak | TextFormatFlags.TextBoxControl |
				TextFormatFlags.NoPadding | TextFormatFlags.RightToLeft);

			var metaSize = TextRenderer.MeasureText(
				MetaText ?? string.Empty,
				_metaFont,
				new Size(available + 80, int.MaxValue),
				TextFormatFlags.WordBreak | TextFormatFlags.NoPadding | TextFormatFlags.RightToLeft);

			var width = Math.Max(textSize.Width, metaSize.Width) + PadX * 2;

			width = Math.Max(MinWidth, Math.Min(width, available + PadX * 2));

			_textHeight	= textSize.Height;
			Width		= width;
			Height		= PadY * 2 + textSize.Height + Gap + metaSize.Height;
		}

		private void EnsureMetaFont()
		{
			if (_metaFont != null)
				return;

			_metaFont = new Font(Font.FontFamily, Math.Max(7F, Font.Size - 2.5F));
		}
		#endregion

		#region Painting

		protected override void OnPaint(PaintEventArgs e)
		{
			EnsureMetaFont();

			var graphics = e.Graphics;

			graphics.SmoothingMode = SmoothingMode.AntiAlias;

			var back	= IsOutgoing ? OutgoingBack : IncomingBack;
			var border	= IsSelected ? SelectedBorder : (IsOutgoing ? OutgoingBorder : IncomingBorder);

			var bounds = new Rectangle(0, 0, Width - 1, Height - 1);

			using (var path = CreateRoundedPath(bounds, Radius))
			using (var brush = new SolidBrush(back))
			using (var pen = new Pen(border, IsSelected ? 2F : 1F))
			{
				graphics.FillPath(brush, path);
				graphics.DrawPath(pen, path);
			}

			var textRect = new Rectangle(PadX, PadY, Width - PadX * 2, Math.Max(_textHeight, 0) + 2);

			TextRenderer.DrawText(
				graphics,
				MessageText ?? string.Empty,
				Font,
				textRect,
				TextColor,
				TextFormatFlags.WordBreak | TextFormatFlags.TextBoxControl |
				TextFormatFlags.NoPadding | TextFormatFlags.RightToLeft | TextFormatFlags.Right);

			var metaTop = PadY + _textHeight + Gap;

			var metaRect = new Rectangle(
				PadX,
				metaTop,
				Width - PadX * 2,
				Math.Max(0, Height - PadY - metaTop));

			TextRenderer.DrawText(
				graphics,
				MetaText ?? string.Empty,
				_metaFont,
				metaRect,
				MetaColor,
				TextFormatFlags.WordBreak | TextFormatFlags.NoPadding |
				TextFormatFlags.RightToLeft | TextFormatFlags.Right);
		}

		private static GraphicsPath CreateRoundedPath(Rectangle bounds, int radius)
		{
			var path	= new GraphicsPath();
			var size	= radius * 2;

			path.AddArc(bounds.Left, bounds.Top, size, size, 180, 90);
			path.AddArc(bounds.Right - size, bounds.Top, size, size, 270, 90);
			path.AddArc(bounds.Right - size, bounds.Bottom - size, size, size, 0, 90);
			path.AddArc(bounds.Left, bounds.Bottom - size, size, size, 90, 90);
			path.CloseFigure();

			return path;
		}
		#endregion

		#region Cleanup

		protected override void Dispose(bool disposing)
		{
			if (disposing && _metaFont != null)
			{
				_metaFont.Dispose();
				_metaFont = null;
			}

			base.Dispose(disposing);
		}
		#endregion
	}
}
