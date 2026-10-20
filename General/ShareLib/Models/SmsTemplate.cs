using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;

namespace ShareLib.Models
{
	public class SmsTemplate :ISqlQueryMaker
	{
		public short	Id			{ get; set; }
		public byte		Kind		{ get; set; }
		public string	Message		{ get; set; }
		public string GetItem()
		{
			return @"

";
		}

		public string GetList()
		{
			return @"
SELECT Id,Kind,LTRIM(RTRIM(Message)) AS Message FROM General.tbl_SmsTemplate

";
		}
	}
}
