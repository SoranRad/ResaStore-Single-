using System;
using Nz.Anbar.Model.Model;

namespace Nz.Anbar.WinForms.Component
{
	public class SubGroupEventArgs : EventArgs
	{
		public SubGroup SubGroup { get; private set; }

		public SubGroupEventArgs(SubGroup subGroup)
		{
			this.SubGroup = subGroup;
		}
	}
}