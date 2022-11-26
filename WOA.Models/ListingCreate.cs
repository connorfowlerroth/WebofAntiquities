using System;
using System.ComponentModel.DataAnnotations;
using static WOA.Data.ItemEnums;

namespace WOA.Models
{
	public class ListingCreate
	{
        [Required]
        [MinLength(3, ErrorMessage = "There are not enough characters in this description.")]
        [MaxLength(50, ErrorMessage = "There are too many characters in this description.")]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        //[Required]
        //public bool Availability { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        [Display(Name = "Condition")]
        public Condition condition { get; set; }

        [Required]
        [Display(Name = "Time Period")]
        public TimePeriod timePeriod { get; set; }

        [Required]
        public DateTimeOffset DatePosted { get; set; }
    }
}

