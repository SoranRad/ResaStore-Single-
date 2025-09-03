using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nz.Aqsat.Bussiness;

namespace Nz.Aqsat.Winforms.App
{
	public partial class FormAqsatKind : Form
	{
		#region Logging
		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
					(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		#endregion
		private Manager             _Manager;

		public FormAqsatKind()
		{
			InitializeComponent();
			_Manager = new Manager();

		}
	}
}
