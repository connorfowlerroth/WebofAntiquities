using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using WOA.Data;
using static WOA.Data.ItemEnums;

namespace WOA.Models
{
	public class ListingListItem
	{
		public int ListingId { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool Availability { get; set; }

        public DateTimeOffset DatePosted { get; set; }

        [Display(Name = "Condition")]
        public Condition condition { get; set; }

        [Display(Name = "Time Period")]
        public TimePeriod timePeriod { get; set; }

        //public virtual Item Item { get; set; }
        //public object Condition { get; set; }
    }
}

