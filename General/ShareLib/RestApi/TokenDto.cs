using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib.RestApi
{
	public class TokenDto
	{
		public string Token { get; set; }
		public string RefreshToken { get; set; }
	}
}
