using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib
{
    public class Enums
    {
        public enum NzKindPrint 
        {
            PaperA4,
            PaperA5,
            PosPrint,
        }
        public enum MenuKind
        {
            BaseInfo = 1,
            Operation,
            Reports,
            Settings,
            Management,
            Sidebar
        }

        public enum NzMiscMountKind : byte
        {
            Off     = 1,
            Extend  = 2,
            Tax     = 3,
        }
        public enum NzFactorKind : byte
        {
            //===========Not Effect
            PishFaktor      = 0,
            SefarshFrosh    = 1,
            SefareshXarid   = 2,

            //=================In
            AvalDore        = 11,
            Xarid           = 12,
            BargshtFrosh    = 13,
            BargshtFrosh_Ba_Mabna = 14,
            XaridBar        = 15,
            EnteqalBeynAnbarVorud =16,
            //=================Out
            Frosh           = 50,
            BargashXarid    = 51,
            BargashXarid_Ba_Mabna=52,
            HavaleZayeat    = 53,
            HavaleMasrafi   = 54,
            EnteqalBeynAnbarXoruj=55,
        }
        public enum MS_System
        {
            General = 1,
            Anbar,
            Aqsat,
            Xazane,
            Cheque,
            Shoraka,
            Archive,
            Mali,
            Bar,
            Machine
        }
        public enum NzAccountKind : byte
        {
            Cache           = 1,
            BankAccount     = 2,
            Income          = 3,
            Cost            = 4,
            Deficit         = 5,
            Fund            = 6,
            Addition        = 7,
        }
        public enum NzPaymentOperatingKind : byte
        {
            Daryaft         = 1,
            Pardaxt         = 2,
            Daramad         = 3,
            Hazine          = 4,
            Naql_Enteqal    = 5,
            Kosurat         = 6,
            Addition        = 7,
            Enteqal_Shaxs   = 8,
            Naqd            = 9,
            Bank_POS        = 10,
            RemaindDebit    = 11,
            RemaindCredit   = 12,
            Cheque          = 13,
            Off             = 14,
            AssignCheque    = 15,
            chequePayBack   = 16,
        }
        public enum NzChequeStateFlag : byte
        {
            Vosul       = 1,
            Vagozari    = 2,
            Bargasht    = 3,
            Nazd_Sanduq = 10,
        }
        public enum NzAccountBankKind : byte
        {
            Jari            = 1,
            SepordeGozari   = 2,
            GharzolHasane   = 3,
            Sayer           = 4,
        }
        public enum NzStorageKind : byte
        {
            Avg=1,
            FiFo,
            LiFo,
        }
        public enum NzObjectKind : byte
        {
            Object=1,
            Service,
        }
        public enum NzObjectSeason : byte
        {
            Spring = 0,
            Summer , 
            Autumn,
            Winter,
            General
        }
        public enum NzSalingKind : byte
        {
            Normal = 0,
            Crumbs,
            Colleague,
            Misc,

        }
        public enum NzUserKind : byte
        {
            Manager=1,
            Captin,
            Normal,
        }
        public enum NzSex :byte
        {
            Male=1,
            Female,
            Other,
        }
        public enum PeopleKind 
        {
            Customer = 1,
            Partner,
            Stockholder

        }
        public enum NzItemState : byte
        {
            NotChanged=1,
            AddedNew,
            Modified,
            Deleted,
        }
        public enum FormOperation: short
        {
            Factors     = 1,
            Transfer    = 2,
            Recieve     = 3,
            Payment     = 4,
            Deficit     = 5,
            Addition    = 6,
            Remaind     = 7,
            Cheque      = 8,
            SaleBack    = 9,
            FactorPaymentList = 10,
            StorageEndYear,
            XazaneEndYear,
            BarcodePayment,
            Bar
        }
        public enum StorageFeatureItem : short
        {
            MultiStorage = 0,
            MainGroup ,
            PriceList2,
            PriceList3,
            PriceList4,
            BarcodeReader,
        }
        public enum XazaneFeatureItem : short
        {
            MultiStorage = 0,
            MainGroup,
            PriceList2,
            PriceList3,
            PriceList4,
            BarcodeReader,
        }
        public enum GeneralFeatureItem : short
        {
            MultiStorage = 0,
            MainGroup,
            PriceList2,
            PriceList3,
            PriceList4,
            BarcodeReader,
        }
        public enum NzMultipleReportKind
        {
            First,
            Separate,
        }

        public enum NzFactoryControlKind : byte
        {
            CachePos,

        }
    }
}
