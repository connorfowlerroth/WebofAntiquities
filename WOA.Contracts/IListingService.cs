using WOA.Models;

namespace WOA.Contracts;

public interface IListingService
{
    bool CreateListing(ListingCreate model);
    IEnumerable<ListingListItem> GetListingsByUserId(int id);
    void SetUserId(Guid userId);
}