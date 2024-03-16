using CollectionManager.App.ViewModels;
using CollectionManager.App.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionManager.App.Services
{
    internal static class AppInstaller
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IItemService, ItemService>();
        }

        public static void RegisterViewModels(this IServiceCollection services)
        {
            services.AddSingleton<ItemsListViewModel>();
        }

        public static void RegisterViews(this IServiceCollection services)
        {
            services.AddTransient<ItemsListView>();
        }
    }
}
