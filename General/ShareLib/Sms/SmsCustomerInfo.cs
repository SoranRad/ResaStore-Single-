using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib.Sms
{
    public class SmsCustomerInfo
    {
	    public string			Code				{ get; set; }
	    public string			Title				{ get; set; }
	    public string			Mobile				{ get; set; }
	    public DateTime			ExpiredDate			{ get; set; }
	    public decimal			SmsCount			{ get; set; }
	    public decimal			ChargeAmount		{ get; set; }
	     
	}
}
