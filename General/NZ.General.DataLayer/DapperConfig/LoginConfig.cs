using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;
using ShareLib.ViewModel;

namespace NZ.General.DataLayer.DapperConfig
{
    public class LoginConfig : DapperEntityConfiguration<UserLogin>
    {
        public LoginConfig()
        {
            SetList(@"


");

            SetItem(@"
SELECT 

LTRIM(RTRIM(tu.user_name)) AS Username,
LTRIM(RTRIM(tu.password)) AS Password,
LTRIM(RTRIM(tu.default_password)) AS default_password,
tu.Code,
tu.ID,
tu.is_disable 

FROM General.tbl_User AS tu
WHERE LTRIM(RTRIM(tu.user_name)) LIKE @User
");
        }
    }
}
