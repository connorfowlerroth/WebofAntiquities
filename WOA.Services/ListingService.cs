using System;
using WOA.Data;
using WOA.Models;

namespace WOA.Services
{
	public class ListingService
	{
        private readonly ApplicationDbContext _context;
        private readonly Guid _userId;

		public ListingService(Guid userId)
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
                    DatePosted = DateTimeOffset.Now
                };

            _context.Listings.Add(entity);
            return _context.SaveChanges() == 1;
        }

        public IEnumerable<ListingListItem> GetListingsByUserId()
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
                            DatePosted = e.DatePosted
                        }

                     );

            return query.ToArray();
        }
    }
}
	


