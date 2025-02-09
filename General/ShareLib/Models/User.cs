
using ShareLib.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;

namespace ShareLib.Models
{
    public class User : ISqlQueryMaker, ICodeEntity
    {
        private string      _OriginalPass, 
                            _OriginalDefPass, 
                            _OriginalAccess;

        public User()
        {
            DialogsEdit     = new HashSet<Dialog>();
            DialogsInsert   = new HashSet<Dialog>();
        }

        public short        ID              { get; set; }
        public short        Code            { get; set; }
        public short        kind            { get; set; }
        public bool         is_disable      { get; set; }
        public byte[]       picture         { get; set; }
        [Required]
        [StringLength(100)]
        public string       title           { get; set; }
        [Required]
        [StringLength(50)]
        public string       user_name       { get; set; }
        [Required]
        [StringLength(100)]
        public string       password        
        {
            get
            {
                return _OriginalPass;
            }
            set {
                _OriginalPass = value;
            }
        }
        [Required]
        [StringLength(100)]
        public string       default_password
        {
            get
            {
                return _OriginalDefPass;
            }
            set
            {
                _OriginalDefPass = value;
            }
        }
        public string       dastressi       
        {
            get { return _OriginalAccess; }
            set { _OriginalAccess = value; }
        }

        [NotMapped]
        public string       KindTitle       => ((Enums.NzUserKind)this.kind).NzTostring();
        [NotMapped]
        public string       StateTitle      => this.is_disable ? "غیر فعال " : "فعال";
        #region Encrypt Methods
        [NotMapped]
        public string OriginalPassword        
        {
            get
            {
                try
                {
                    return MS_Control.MS_Util.MS_Hash_To_Str(_OriginalPass, SystemConstant.NzPasswordHash+this.Code);
                }
                catch (Exception)
                {
                    return string.Empty;
                }
            }

            set
            {
                _OriginalPass = MS_Control.MS_Util.MS_Str_To_Hash(value, SystemConstant.NzPasswordHash + this.Code);
            }
        }
        [NotMapped]
        public string OriginalDefaultPassword 
        {
            get
            {
                try
                {
                    return MS_Control.MS_Util.MS_Hash_To_Str(_OriginalDefPass, SystemConstant.NzPasswordHash + this.Code);
                }
                catch (Exception)
                {
                    return string.Empty;
                }
            }

            set
            {
                _OriginalDefPass = MS_Control.MS_Util.MS_Str_To_Hash(value, SystemConstant.NzPasswordHash + this.Code);
            }
        }
        [NotMapped]
        public string OriginalAccess          
        {
            get
            {
                try
                {
                    return MS_Control.MS_Util.MS_Hash_To_Str(_OriginalAccess, SystemConstant.NzPasswordHash + this.Code);
                }
                catch (Exception)
                {
                    return string.Empty;
                }
            }

            set
            {
                _OriginalAccess = MS_Control.MS_Util.MS_Str_To_Hash(value, SystemConstant.NzPasswordHash + this.Code);
            }
        }

        public ICollection<Dialog> DialogsInsert    { get; set; }
        public ICollection<Dialog> DialogsEdit      { get; set; }

        #endregion
        #region Interface Methods
        public string       GenerateCode    ()
        {
            return @"select max(tu.Code) from General.tbl_User as tu ";
        }
        public string       GetItem         ()
        {
            return @"
select 
                     ID ,
                     Code ,
                     Rtrim(Ltrim( title )) as title,
                     kind ,
                     Rtrim(Ltrim( user_name)) as user_name ,
                     Rtrim(Ltrim( password )) as password,
                     Rtrim(Ltrim( default_password )) as  default_password,
                     Rtrim(Ltrim( dastressi )) as dastressi,
                     is_disable ,
                     picture 
                     from General.tbl_User
where ID=@ID
";
        }
        public string       GetList         ()
        {
            return @"select 
                     ID ,
                     Code ,
                     Rtrim(Ltrim( title )) as title,
                     kind ,
                     Rtrim(Ltrim( user_name)) as user_name ,
                     Rtrim(Ltrim( password )) as password,
                     Rtrim(Ltrim( default_password )) as  default_password,
                     Rtrim(Ltrim( dastressi )) as dastressi,
                     is_disable ,
                     picture 
                     from General.tbl_User ";
        }
        public string       UniqueCode      ()
        {
            return @"select Count(tu.Code )
                            from      General.tbl_User as tu 
                            where     tu.Code=@Code ";
        }
        #endregion

    }
}
