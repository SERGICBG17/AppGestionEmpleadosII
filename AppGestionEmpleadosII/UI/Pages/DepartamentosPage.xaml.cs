using AppGestionEmpleadosII.UI.PagesModel;

namespace AppGestionEmpleadosII.UI.Pages;

public partial class DepartamentosPage : ContentPage
{
	public DepartamentosPage(DepartamentosPageModel departamentosPageModel)
	{
		BindingContext = departamentosPageModel;
		InitializeComponent();
	}
}