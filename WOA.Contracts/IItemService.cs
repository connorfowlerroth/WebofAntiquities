using WOA.Models;

namespace WOA.Contracts
{
    public interface IItemService
    {
        bool CreateItem(ItemCreate model);
        void SetItemId(int itemId);
    }
}