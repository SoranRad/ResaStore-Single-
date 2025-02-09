namespace NZ.Anbar.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public class StorageAccess
    {
        public int      ID              { get; set; }
        public short    FK_Salmali      { get; set; }
        public byte     FK_Anbar        { get; set; }
        public short    FK_User         { get; set; }

        //public Storage  Storage         { get; set; }
    }
}
