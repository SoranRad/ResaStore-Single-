using ShareLib.Interfaces;
using ShareLib.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.General.DataLayer.DapperConfig
{
    public class DataBaseListConfig : DapperEntityConfiguration<DataBaseList>
    {
        public DataBaseListConfig()
        {
            SetList(@"SELECT name AS DbName 
                        FROM master.dbo.sysdatabases
                        WHERE name LIKE 'DB_NzResaaStore%'");
        }

    }
}
