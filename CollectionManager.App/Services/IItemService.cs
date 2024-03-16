using CollectionManager.App.Models;

namespace CollectionManager.App.Services
{
    internal interface IItemService
    {
        Task<List<ItemModel>> ListItems();
    }
}