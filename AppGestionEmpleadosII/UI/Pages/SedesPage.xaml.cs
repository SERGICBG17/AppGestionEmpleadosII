using AppGestionEmpleadosII.UI.PagesViewModels;

namespace AppGestionEmpleadosII.UI.Pages;

public partial class SedesPage : ContentPage
{
	public SedesPage(SedesPageModel sedesPageModel)
	{
		BindingContext = sedesPageModel;
		InitializeComponent();
	}
}