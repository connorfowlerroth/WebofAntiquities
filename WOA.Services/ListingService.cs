using System;
using WOA.Data;
using WOA.Contracts;
using WOA.Models;
using static WOA.Data.ItemEnums;

namespace WOA.Services
{
    public class ListingService : IListingService
    {
        private readonly ApplicationDbContext _context;
        private Guid _userId;
        //private Item item;

        public ListingService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void SetUserId(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateListing(ListingCreate model)
        {
            var entity =
                new Listing()
                {
                    UserId = _userId,
                    Description = model.Description,
                    Price = model.Price,
                    City = model.City,
                    State = model.State,
                    Condition = model.condition,
                    TimePeriod = model.timePeriod,
                    DatePosted = DateTimeOffset.Now
                };

            _context.Listings.Add(entity);
            return _context.SaveChanges() == 1;
        }

        public IEnumerable<ListingListItem> GetListingsByUserId(int id)
        {
            var query = _context.Listings
                .Where(e => e.UserId == _userId)
                .Select(
                    e =>
                        new ListingListItem
                        {
                            ListingId = e.ListingId,
                            Description = e.Description,
                            Price = e.Price,
                            condition = e.Item.condition,
                            timePeriod = e.Item.timePeriod,
                            DatePosted = e.DatePosted
                        }

                     );

            return query.ToArray();
        }
    }
}
	


