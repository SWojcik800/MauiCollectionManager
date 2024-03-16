using CollectionManager.App.Models;
using CollectionManager.App.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionManager.App.ViewModels
{
    public partial class ItemsListViewModel(IItemService service) : ObservableObject
    {

  

        [ObservableProperty]
        List<ItemModel> items;


        [RelayCommand]
        async Task LoadItems()
        {
            Items = await service.ListItems();
        }
    }
}
