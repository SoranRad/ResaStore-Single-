using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using NZ.Xazane.Model;
using ShareLib.Interfaces;
using ShareLib.Models;

namespace NZ.Xazane.DataLayer.Repo
{
    public class CommandRepository : ICommandRepository
    {
        #region Fields
        private DbConnection _Connection;
        #endregion
        #region Constructor
        public CommandRepository        (DbConnection Connection)
        {
            _Connection = Connection;
        } 
        #endregion
        public  void        Delete<T>   (long ID, Company CurrentCompany, Year CurrentYear, User CurrentUser) where T : class
        {
            if(typeof(T) == typeof(Accounts))
                Delete(new Accounts() { ID = Convert.ToInt32(ID) });
        }
        private void        Delete      (Accounts          Account)
        {

            //var strCommand = "DELETE FROM Xazane.tbl_Hesab_Xazaneh WHERE ID = "+Account.ID;
            //_Connection.Execute(strCommand);

            using (var db = new XazaneContext(_Connection, false))
            {
                db.tbl_Hesab_Xazaneh.Attach(Account);
                db.Entry(Account).State = EntityState.Deleted;
                //db.tbl_Hesab_Xazaneh.Remove(Account);
                db.SaveChanges();
            }
        }
        #region SaveMethods
        public  long        Save<T>     (T Item, Company CurrentCompany, Year CurrentYear, User CurrentUser) where T : class
        {
            if (typeof(T) == typeof(Accounts))
                return Save(Item as Accounts);

           

            return 0;
        }
        private long        Save        (Accounts          Account)
        {
            using (var db = new XazaneContext(_Connection,false))
            {
                db.tbl_Hesab_Xazaneh.AddOrUpdate(Account);
                db.SaveChanges();
                return Account.ID;
            }
        }
        #endregion
    }
}
