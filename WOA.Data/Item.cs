using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WOA.Data
{
	public class Item
	{
        [ForeignKey("Listing")]
		public int ItemId { get; set; }

        public virtual Listing Listing { get; set; }

        public decimal Length { get; set; }

		public decimal Height { get; set; }

		public decimal Width { get; set; }

        [ForeignKey(nameof(ItemType))]
        public int ItemTypeId { get; set; }
        public virtual ItemType ItemType { get; set; }

        [ForeignKey(nameof(MaterialType))]
        public int MaterialTypeId { get; set; }
        public virtual MaterialType MaterialType { get; set; }

    }

	public enum Condition { Rough = 1, Fair, Good, Mint }


	public enum TimePeriod
	{
		[Display(Name = "William and Mary - 1685-1720")]
        WilliamandMary =1,

        [Display(Name = "Queen Anne/Louis XV - 1720-1760")]
        QueenAnneLouisXV,

        [Display(Name = "Chippendale - 1755-1790")]
        Chippendale,

        [Display(Name = "Federal/ Hepplewhite - 1790-1815")]
        FederalHepplewhite,

        [Display(Name = "Sheraton - 1790-1810")]
        Sheraton,

        [Display(Name = "Empire - 1805-1830")]
        Empire,

        [Display(Name = "Victorian - 1830-1901")]
        Victorian,

        [Display(Name = "Rococo Revival - 1845-1870")]
        RococoRevival,

        [Display(Name = "Naturalistic/Aesthetic - 1850-1914")]
        NaturalisticAesthetic,

        [Display(Name = "Neo-Greek/Eastlake - 1855-1890")]
        NeoGreekEastlake,

        [Display(Name = "Arts and Crafts - 1895-1915")]
        ArtsandCrafts,

        [Display(Name = "Art Nouveau - 1896-1914")]
        ArtNouveau,

        [Display(Name = "Art Deco - 1920-1945")]
        ArtDeco,

        [Display(Name = "Mid-Century Modernism - 1945-1970")]
        MidCenturyModernism,
    }
}

