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
    public class CodeGenerationRepository : ICodeQueryRepository
    {
        #region Fields
        private DbConnection _Connection;
        #endregion
        #region Consructor
        public CodeGenerationRepository(DbConnection Connection)
        {
            _Connection = Connection;
        }
        #endregion
        
        public int      GenerateCode<T>         (Company CurrentCompany, Year CurrentYear, User CurrentUser)
        {
            throw new NotImplementedException();
        }
        public int      GenerateCode<T>         (int ParentCode, Company CurrentCompany, Year CurrentYear, User CurrentUser)
        {
            throw new NotImplementedException();
        }
        public short    GenerateCode<T>         (short ParentCode, Company CurrentCompany, Year CurrentYear, User CurrentUser)
        {
            if (typeof(T) == typeof(Accounts))
                return GenerateAccountCode(ParentCode, CurrentYear);
            return 0;
        }
        private short   GenerateAccountCode     (short Kind, Year CurrentYear)
        {
            var StrCommand = @" SELECT MAX(thx.Code) 
                                FROM Xazane.tbl_Hesab_Xazaneh AS thx
                                WHERE FK_Salmali=@Salmali AND thx.Kind=@Kind";

            var max = _Connection.ExecuteScalar(StrCommand, new { CurrentYear.Salmali,Kind });
            return max == null
                ? Convert.ToInt16(1)
                : Convert.ToInt16(Convert.ToInt16(max) + 1);
        }

        public bool     IsCodeUnique<T>         (int Code,   Company CurrentCompany, Year CurrentYear, User CurrentUser)
        {
            throw new NotImplementedException();
        }
        public bool     IsCodeUnique<T>         (short Code, Company CurrentCompany, Year CurrentYear, User CurrentUser)
        {
            throw new NotImplementedException();
        }
        public bool     IsCodeUnique<T>         (byte Code,  Company CurrentCompany, Year CurrentYear, User CurrentUser)
        {
            throw new NotImplementedException();
        }

        public  bool    IsCodeUnique<T>         (object Code, object Kind, Company CurrentCompany, Year CurrentYear, User CurrentUser)
        {
            if (typeof(T) == typeof(Accounts))
                return IsAccountCodeUnique(Convert.ToInt16(Code),Convert.ToByte(Kind),CurrentYear);

            return false;
        }
        private bool    IsAccountCodeUnique     (short Code,byte Kind , Year CurrentYear)
        {
            var StrCommand = @"SELECT TOP(1) thx.Code 
                                    FROM Xazane.tbl_Hesab_Xazaneh AS thx
                                    WHERE thx.FK_Salmali=@Salmali AND thx.Kind=@Kind And thx.Code=@Code";

            var item = _Connection
                .QueryFirstOrDefault<Accounts>
                (StrCommand, new
                {
                    Code ,
                    CurrentYear.Salmali ,
                    Kind
                });
            return item == null;
        }

    }
}
