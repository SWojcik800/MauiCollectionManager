using CollectionManager.App.Services;
using CollectionManager.App.ViewModels;

namespace CollectionManager.App.Views;

public partial class ItemsListView : ContentPage
{
	public ItemsListView(ItemsListViewModel viewModel)
	{
        InitializeComponent();
		viewModel.LoadItemsCommand.ExecuteAsync(null);
		BindingContext = viewModel;

	}
}