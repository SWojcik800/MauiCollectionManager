using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CollectionManager.App.ViewModels
{
    public partial class YeetViewModel : ObservableObject
    {
        [ObservableProperty]
        private int counter;

        [RelayCommand]
        public async Task Increment()
        {
            Counter += 1;
        }

    }
}
