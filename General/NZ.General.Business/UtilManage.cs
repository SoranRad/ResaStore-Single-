using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ShareLib.Utils;

namespace NZ.General.Business
{
    public class UtilManage
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private DbConnection _Connection;

        #endregion
        #region Constructor
        public UtilManage()
        {
            _Connection = ConnectionManager.Create();
        }
        #endregion
        #region Property
        public DbConnection Connection      { get { return _Connection; } set { _Connection = value; } }
        #endregion
        #region Methods
        public void         CreateBackUp    (string Path, out bool BackUp, out bool Zip)
        {
            var p = new DynamicParameters();
            p.Add("@Path",          Path);
            p.Add("@BackCreated",   dbType: DbType.Boolean, direction: ParameterDirection.Output);
            p.Add("@ZipCreated",    dbType: DbType.Boolean, direction: ParameterDirection.Output);

            _Connection.Execute("General.CreateBackup", p, commandType: CommandType.StoredProcedure);

            BackUp      = p.Get<bool>("@BackCreated");
            Zip         = p.Get<bool>("@ZipCreated");
        }
        public void         RestoreDB       (string BackupPath)
        {
            var command = Connection
                .ExecuteScalar<string>
                ("Select General.RestoteDB(@BackupPath) ",
                    new
                    {
                        BackupPath,
                    }
                );
            Connection.Execute(command);
        }
        public bool         DataBaseExist   ()
        {
            //SqlConnectionStringBuilder cr   = new SqlConnectionStringBuilder();
            //cr.ConnectionString             = _Connection.ConnectionString;
            //cr.InitialCatalog               = String.Empty;

            //var con                 = ConnectionManager.Create();
            //con.ConnectionString    = cr.ToString();
            var SqlCmd              = "Select db_id('" + _Connection.Database + "')";
            
            log.Info(SqlCmd);
            using (var con =ConnectionManager.Create())
            {
                var result = con.ExecuteScalar<int?>(SqlCmd);
                log.Info("result is "+result);
                return result != null;
            }
            
        }
        #endregion
    }
}
