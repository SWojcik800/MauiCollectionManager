using CollectionManager.App.Consts;
using CollectionManager.App.Views;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using Windows.UI.ApplicationSettings;
using ShellItem = Microsoft.Maui.Controls.ShellItem;

namespace CollectionManager.App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            BindingContext = this;

            RegisterRoutes();

        }

        void RegisterRoutes()
        {
            Routing.RegisterRoute(AppRoutes.ItemsListRoute, typeof(ItemsListView));
        }

    }
}
