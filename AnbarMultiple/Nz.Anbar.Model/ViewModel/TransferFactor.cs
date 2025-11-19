
namespace Nz.Anbar.Model.ViewModel
{
    public class TransferFactor
    {
        public long         ID                  { get; set; }

        public int          Serial              { get; set; }
        public string       PersianStr          { get; set; }
        public string       PersianMonthNo      { get; set; }
        public string       PersianDayInMonth   { get; set; }

        public string       AnbarAz             { get; set; }
        public string       AnbarBe             { get; set; }
        public string       Tahvil_Girande      { get; set; }

        public string       sharh               { get; set; }
        public int          ItemCount           { get; set; }      
    }
}
