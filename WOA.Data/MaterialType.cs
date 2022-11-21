﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WOA.Data
{
	public class MaterialType
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }
	}
}

