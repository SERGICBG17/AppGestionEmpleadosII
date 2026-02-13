using AppGestionEmpleadosII.UI.PagesViewModels;

namespace AppGestionEmpleadosII.UI.Pages;

public partial class EmpleadosPage : ContentPage
{
	public EmpleadosPage(EmpleadosPageModel empleadosPageModel)
	{
		BindingContext = empleadosPageModel;
		InitializeComponent();
	}
}