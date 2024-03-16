using CollectionManager.App.Models;

namespace CollectionManager.App.Services
{
    public interface IItemService
    {
        Task<List<ItemModel>> ListItems();
    }
}