using MyMauiApp.PageModels;

namespace MyMauiApp.Views.Pages;

public partial class ProductsPage : ContentPage
{
	public ProductsPage(ProductsPageModel pageModel)
	{
		InitializeComponent();

		this.BindingContext = pageModel;
	}

    private void ContentPage_Appearing(object sender, EventArgs e)
    {

    }

    //private void VerticalStackLayout_Loaded(object sender, EventArgs e)
    //{
    //    var vm = BindingContext as ProductDetailPageModel;
       
    //}
}