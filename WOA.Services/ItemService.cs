using System;
using WOA.Data;
using WOA.Contracts;
using WOA.Models;

namespace WOA.Services
{
    public class ItemService : IItemService
    {
        private readonly ApplicationDbContext _context;

        public int _itemId;

        public void SetItemId(int itemId)
        {
            _itemId = itemId;
        }

        public ItemService(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool CreateItem(ItemCreate model)
        {
            var entity =
                new Item()
                {
                    Length = model.Length,
                    Height = model.Height,
                    Width = model.Width
                };

            _context.Items.Add(entity);
            return _context.SaveChanges() == 1;

        }

        public IEnumerable<ItemListItem> GetItemById()
        {
            var query = _context.Items
                .Where(e => e.ItemId == _itemId)
                .Select(
                    e =>
                        new ItemListItem
                        {
                            ItemId = e.ItemId,
                            Length = e.Length,
                            Height = e.Height,
                            Width = e.Width

                        });

            return query.ToArray();
        }
    }
}

