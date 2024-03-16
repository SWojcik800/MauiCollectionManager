using CollectionManager.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionManager.App.Services
{
    internal sealed class ItemService : IItemService
    {
        private readonly List<ItemModel> _items = new()
        {
            new ()
            {
                Id = 1,
                Name = "PC",
                Description = "PC"
            }
        };

        public async Task<List<ItemModel>> ListItems()
            => _items;
    }
}
