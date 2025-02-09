using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib.Utils
{
    public static class ConnectionManager
    {
        #region Fields
        public static string ConStr = "";
        #endregion
        #region Methods
        public static DbConnection  Create() =>new SqlConnection(ConStr);
        #endregion
    }
}
