using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Resaa.Store.Components
{
	/// <summary>
	/// Settings to control how Warn and WarnAsync events are raised.
	/// </summary>
	public enum WarnSettings
	{
		/// <summary>
		/// Warn and WarnAsync events wil be raised on each Tick once the WarnTime has been reached.
		/// </summary>
		Tick,
		/// <summary>
		/// Warn and WarnAsync events wil be raised once only when the WarnTime is reached.
		/// </summary>
		Once,
		/// <summary>
		/// Warn and WarnAsync events will not be raised.
		/// </summary>
		Off
	}
}
