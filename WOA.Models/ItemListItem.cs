using System;
using System.ComponentModel.DataAnnotations;
using WOA.Data;

namespace WOA.Models
{
	public class ItemListItem
	{
		public int ItemId { get; set; }

		public decimal Length { get; set; }

		public decimal Height { get; set; }

		public decimal Width { get; set; }

		public Condition Condition { get; set; }

		[Display(Name="Time Period")]
		public TimePeriod TimePeriod { get; set; }
    }
}

