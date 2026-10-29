using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SmsBan.Core
{
	/// <summary>
	/// تجزیه و یکسان‌سازی شماره‌های مرجع پیامک که مودم برمی‌گرداند.
	///
	/// مودم برای یک پیامک چندپارتی، مرجع هر پارت را با قالب متفاوتی می‌دهد:
	///   خروجی S_SMS3      : "R1:56--R2:57--R3:58--"
	///   متن رویداد ارسال  : "All_Part:3 Refrences:56-57-58-"
	///
	/// هر دو با این کلاس به فهرست «56,57,58» تبدیل می‌شوند تا قابل مقایسه باشند.
	/// </summary>
	public static class SmsReferenceParser
	{
		/// <summary>قالب خروجی S_SMS3: «R1:56--R2:57--»</summary>
		private static readonly Regex PartPattern = new Regex(
			@"R\s*\d+\s*:\s*(?<ref>[^\-]+?)\s*--",
			RegexOptions.Compiled | RegexOptions.IgnoreCase);

		/// <summary>قالب متن رویداد: «Refrences:56-57-58-»</summary>
		private static readonly Regex ListPattern = new Regex(
			@"Refrences\s*:\s*(?<list>[0-9\-]+)",
			RegexOptions.Compiled | RegexOptions.IgnoreCase);

		private static readonly Regex DigitPattern = new Regex(@"\d+", RegexOptions.Compiled);

		/// <summary>
		/// استخراج شماره‌های مرجع از یک متن.
		/// خروجی خالی یعنی هیچ مرجعی در متن نبود.
		/// </summary>
		public static List<string> Parse(string text)
		{
			var result = new List<string>();

			if (string.IsNullOrWhiteSpace(text))
				return result;

			// ۱) قالب رویداد: «All_Part:3 Refrences:56-57-58-»
			var list = ListPattern.Match(text);

			if (list.Success)
			{
				foreach (var part in list.Groups["list"].Value.Split('-'))
					Add(result, part);

				if (result.Count > 0)
					return result;
			}

			// ۲) قالب خروجی S_SMS3: «R1:56--R2:57--R3:58--»
			var matches = PartPattern.Matches(text);

			if (matches.Count > 0)
			{
				foreach (Match match in matches)
					Add(result, match.Groups["ref"].Value);

				if (result.Count > 0)
					return result;
			}

			// ۳) تک‌مرجع ساده: «56» یا «Refrence:56»
			foreach (Match match in DigitPattern.Matches(text))
				Add(result, match.Value);

			return result;
		}

		/// <summary>
		/// تبدیل هر قالب مرجع به شکل یکسان «56,57,58».
		/// اگر مرجعی پیدا نشود، متن اصلی برگردانده می‌شود.
		/// </summary>
		public static string Normalize(string text)
		{
			var references = Parse(text);

			if (references.Count == 0)
				return (text ?? string.Empty).Trim();

			return string.Join(",", references);
		}

		/// <summary>
		/// ادغام چند منبع مرجع در یک فهرست یکتا.
		/// خروجی به شکل «56,57,58» است یا null اگر هیچ مرجعی نبود.
		/// </summary>
		public static string Merge(params string[] sources)
		{
			if (sources == null)
				return null;

			var all = new List<string>();

			foreach (var source in sources)
			{
				foreach (var reference in Parse(source))
				{
					if (!all.Contains(reference))
						all.Add(reference);
				}
			}

			return all.Count == 0 ? null : string.Join(",", all);
		}

		/// <summary>
		/// آیا مرجع ذخیره‌شده با یکی از مرجع‌های داده‌شده مشترک است.
		/// مرجع ذخیره‌شده به شکل «56,57,58» است.
		/// </summary>
		public static bool Overlaps(string storedReference, IEnumerable<string> references)
		{
			if (string.IsNullOrWhiteSpace(storedReference) || references == null)
				return false;

			var mine = new HashSet<string>(
				storedReference
					.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(x => x.Trim()),
				StringComparer.Ordinal);

			if (mine.Count == 0)
				return false;

			return references.Any(x => !string.IsNullOrWhiteSpace(x) && mine.Contains(x.Trim()));
		}

		private static void Add(List<string> list, string value)
		{
			if (string.IsNullOrWhiteSpace(value))
				return;

			value = value.Trim();

			if (!list.Contains(value))
				list.Add(value);
		}
	}
}
