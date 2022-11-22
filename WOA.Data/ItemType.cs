using System;
using System.ComponentModel.DataAnnotations;

namespace WOA.Data
{
	public class ItemType
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		public ICollection<Item> ListOfItems { get; set; }
	}
}

