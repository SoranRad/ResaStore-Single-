using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using NZ.Xazane.Model;
using ShareLib.Interfaces;
using ShareLib.Models;

namespace NZ.Xazane.DataLayer.Repo
{
    public class QueryRepository : IQueryRepository
    {

        #region Fields
        private DbConnection _Conection;
        #endregion
        #region Consructor
        public QueryRepository(DbConnection Connection)
        {
            _Conection = Connection;
        }
        #endregion
        #region Item
        public T            GetItem<T>      (T Item)
        {
            if (typeof(T) == typeof(Accounts))
                return (T)Convert.ChangeType(GetItem(Item as Accounts), typeof(T));

            return default(T);
        }
        private Accounts    GetItem         (Accounts Account)
        {
            var StrCommand = @"
                    SELECT  thx.ID ,
                            thx.FK_Salmali ,
                            thx.FK_Bank ,
                            thx.Code ,
                            thx.Kind ,
                            thx.title ,
                            thx.mojudi_avalie ,
                            thx.is_disable ,
                            thx.shobe ,
                            thx.has_POS ,
                            thx.Shomare_Hesab ,
                            thx.Kind_Hesab

                        FROM DB_NzResaaStore.Xazane.tbl_Hesab_Xazaneh AS thx
                        WHERE FK_Salmali=@FK_Salmali AND ID=@ID ";

            return _Conection
                .QuerySingleOrDefault<Accounts>
                (StrCommand, new { Account.ID});
        }
        #endregion
        #region List
        public  IEnumerable<T>              GetList<T>      (long Parent, Company CurrentCompany, Year CurrentYear, User CurrentUser)
        {
            if (typeof(T) == typeof(Accounts))
                return (IEnumerable<T>)ListAccounts(Parent,CurrentYear);

            return null;
        }
        private IEnumerable<Accounts>       ListAccounts    (long Kind,Year CurrentYear)
        {
            var StrCommand = @"
                    SELECT  thx.ID ,
                            thx.FK_Salmali ,
                            thx.FK_Bank ,
                            thx.Code ,
                            thx.Kind ,
                            Ltrim(Rtrim( thx.title)) as title,
                            thx.mojudi_avalie ,
                            thx.is_disable ,
                            Ltrim(Rtrim(thx.shobe))as shobe ,
                            thx.has_POS ,
                            thx.Shomare_Hesab ,
                            Ltrim(Rtrim(thx.Kind_Hesab))as Kind_Hesab

                        FROM DB_NzResaaStore.Xazane.tbl_Hesab_Xazaneh AS thx
                        WHERE FK_Salmali=@FK_Salmali AND thx.Kind=@Kind ";

            return _Conection
                .Query<Accounts>(StrCommand, 
                new
                {
                    FK_Salmali=CurrentYear.Salmali ,
                    Kind
                });
        }
        #endregion

    }
}
