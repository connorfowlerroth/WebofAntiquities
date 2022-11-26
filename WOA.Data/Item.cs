using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static WOA.Data.ItemEnums;

namespace WOA.Data
{
    public class Item
    {
        [ForeignKey("Listing")]
        public int ItemId { get; set; }

        public virtual Listing Listing { get; set; }

        public Condition condition { get; set; }

        public TimePeriod timePeriod { get; set; }

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

}
