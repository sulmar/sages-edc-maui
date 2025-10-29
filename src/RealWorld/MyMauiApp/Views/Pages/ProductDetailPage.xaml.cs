using MyMauiApp.PageModels;

namespace MyMauiApp.Views.Pages;

public partial class ProductDetailPage : ContentPage
{
	public ProductDetailPage(ProductDetailPageModel pageModel)
	{
		InitializeComponent();

		this.BindingContext = pageModel;	
	}
}