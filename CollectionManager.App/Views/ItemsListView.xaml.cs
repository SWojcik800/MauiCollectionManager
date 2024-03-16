using CollectionManager.App.ViewModels;

namespace CollectionManager.App.Views;

public partial class ItemsListView : ContentPage
{
	public ItemsListView()
	{
        InitializeComponent();
		BindingContext = new ItemsListViewModel();

	}
}