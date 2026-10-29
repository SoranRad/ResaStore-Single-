using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib.Sms
{
	public class FastSendSmsDto
	{
		public string UserName { get; set; }
		public string Password { get; set; }
		public int TemplateID { get; set; }
		public long Mobile { get; set; }
		public TemplateParamDto[] TemplateParams { get; set; }
	}
}
