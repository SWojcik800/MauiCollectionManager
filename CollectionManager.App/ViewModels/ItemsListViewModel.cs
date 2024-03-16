using CollectionManager.App.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionManager.App.ViewModels
{
    public partial class ItemsListViewModel : ObservableObject
    {
        [ObservableProperty]
        List<ItemModel> items;
    }
}
