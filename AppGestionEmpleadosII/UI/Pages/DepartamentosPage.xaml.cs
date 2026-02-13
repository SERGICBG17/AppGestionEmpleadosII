using AppGestionEmpleadosII.UI.PagesViewModels;

namespace AppGestionEmpleadosII.UI.Pages;

public partial class DepartamentosPage : ContentPage
{
	public DepartamentosPage(DepartamentosPageModel departamentosPageModel)
	{
		BindingContext = departamentosPageModel;
		InitializeComponent();
	}
}