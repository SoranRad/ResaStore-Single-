using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib.Utils
{
	public class StateNotificationChangedEventArgs : EventArgs
	{
		public Enums.StateNotificationKind		Kind				{ get; set; }
		public string							Message				{ get; set; }   
		public DateTime							OccurredAt			{ get; set; }
		public string							DisplayText			{ get; set; }
	}
}
