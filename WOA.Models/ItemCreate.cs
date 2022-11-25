using System;
using System.ComponentModel.DataAnnotations;
using WOA.Data;

namespace WOA.Models
{
	public class ItemCreate
	{
		public decimal Length { get; set; }

		public decimal Height { get; set; }

		public decimal Width { get; set; }

        [Required]
        public Condition Condition { get; set; }

        [Required]
        public TimePeriod TimePeriod { get; set; }
	}
}

