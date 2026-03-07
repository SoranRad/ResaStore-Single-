using NZ.General.Business;
using ShareLib.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.General.WinForms.Setting
{
	public class DailyNoteService
	{
		public static DailyNote AddNote(DateTime Date, string Text)
		{
			var item = new DailyNote()
			{
				Date = Date,
				IsChecked = false,
				Msg = Text
			};
			var Mgr = new Manager();
			Mgr.Save(item);

			return item;
		}
	}
}
