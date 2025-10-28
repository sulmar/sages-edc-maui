using MyMauiApp.PageModels;

namespace MyMauiApp.Views.Pages;

public partial class ProductsPage : ContentPage
{
	public ProductsPage(ProductsPageModel pageModel)
	{
		InitializeComponent();

		this.BindingContext = pageModel;
	}
}