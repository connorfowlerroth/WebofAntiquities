using System;
namespace WOA.Models
{
	public class ListingListItem
	{
		public int ListingId { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool Availability { get; set; }

        public DateTimeOffset DatePosted { get; set; }
    }
}

