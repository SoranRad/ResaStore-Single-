using ShareLib.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ShareLib.Models.Report
{
	public class PartnerStatus
	{
		public decimal		SumFroshKalaAmani		{ get; set; }
		public decimal		SumFroshKalaAdi			{ get; set; }
		public decimal		SumSoodKala				{ get; set; }
		public decimal		MandeKalaAdi			{ get; set; }
		public decimal		MandeKalaAmani			{ get; set; }
	}

	public class HazineHa
	{
		public decimal		SumHazineHa				{ get; set; }
	}

	public class PartnerBardasht
	{
		public long			ID						{ get; set; }
		public int			code					{ get; set; }
		public string		title					{ get; set; }
		public decimal		Balance					{ get; set; }
		public decimal		PartnerPercent			{ get; set; }
		public decimal		MalaqSahm				{ get; set; }
		public decimal		Mande					{ get; set; }
	}

	public class Hazine
	{
		public long			ID			{ get; set; }
		public short		Code		{ get; set; }
		public string		title		{ get; set; }
	}

	public class KalaXadamat
	{
		public long ID { get; set; }
		public short FK_GroupKala_2th { get; set; }
		public short FK_Vahed { get; set; }
		public byte kind { get; set; }
		public int Code { get; set; }
		public decimal? point_bohrani { get; set; }
		public bool is_disabled { get; set; }
		public decimal nerkh_frosh { get; set; }
		public decimal? nerkh_frosh1 { get; set; }
		public decimal? nerkh_frosh2 { get; set; }
		public decimal? nerkh_frosh3 { get; set; }
		public long? FK_Image { get; set; }

		public string WebSiteProductKind { get; set; }
		public long? WebSiteProductId1 { get; set; }
		public long? WebSiteProductId2 { get; set; }

		public bool IsOffActive { get; set; }
		public bool IsOffPercent { get; set; }
		public decimal OffAmount { get; set; }
		public bool ShowInBarcodeForm { get; set; }
		 
		public string title { get; set; }
		public string barcode { get; set; }
		public string nameFani { get; set; }
		public string codeFani { get; set; }
		public string keshvarSazande { get; set; }

		public short? FK_Brand { get; set; }
		public short? FK_BasteBandi { get; set; }
		public decimal? Height { get; set; }
		public decimal? Width { get; set; }
		public decimal? Length { get; set; }
		public byte? Season { get; set; }
		public string Gender { get; set; }
		public int? Color { get; set; }
		public string Size { get; set; }

		public decimal Zarib { get; set; }
		public short? FK_Vahed_Fari { get; set; }

		public string UnitTitle { get; set; }
		public string MainGroupTitle { get; set; }
		public string SubGroupTitle { get; set; }

		public string KindTitle => ((Enums.NzObjectKind)this.kind).NzTostring();
		public string WebSiteProductKindTitle => (WebSiteProductKind).NzWebsiteProductTypeToPersian();
		public string StateTitle => this.is_disabled ? "غیر فعال " : "فعال";
		public string BrandTitle { get; set; }
		public string BastebandiTitle { get; set; }
		public string SeasonTitle => Season == null ? string.Empty : ((Enums.NzObjectSeason)this.Season).NzTostring();

		public string OffTitle
		{
			get
			{
				if (!this.IsOffActive)
					return null;

				return this.OffAmount.ToString("0,0.##;(0,0.##); ") + " " + (this.IsOffPercent ? "%" : SystemConstant.ActiveYear.Money);
			}
		}

	}
}
