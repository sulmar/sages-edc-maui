using MyMauiApp.PageModels;

namespace MyMauiApp.Views.Pages;

public partial class ProductsPage : ContentPage
{
	public ProductsPage()
	{
		InitializeComponent();

		this.BindingContext = new ProductsPageModel();
	}
}