using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static WOA.Data.ItemEnums;

namespace WOA.Data
{
	public class Listing
	{
		public int ListingId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public bool Availability { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public DateTimeOffset DatePosted { get; set; }

        
        public virtual Item Item { get; set; }
        public ItemEnums.Condition Condition { get; set; }
        public ItemEnums.TimePeriod TimePeriod { get; set; }
    }
}

