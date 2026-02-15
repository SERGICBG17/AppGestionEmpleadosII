using AppGestionEmpleadosII.UI.PagesModel;

namespace AppGestionEmpleadosII.UI.Pages;

public partial class GraficosPage : ContentPage
{
	public GraficosPage(GraficosPageModel graficosPageModel)
	{
		BindingContext = graficosPageModel;
		InitializeComponent();
	}
}