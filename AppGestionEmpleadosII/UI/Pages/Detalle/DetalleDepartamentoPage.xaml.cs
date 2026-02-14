using AppGestionEmpleadosII.UI.PagesModel.Detalle;

namespace AppGestionEmpleadosII.UI.Pages.Detalle;

public partial class DetalleDepartamentoPage : ContentPage
{
	public DetalleDepartamentoPage(DetalleDepartamentoPageModel detalleDepartamentoPageModel)
	{
		BindingContext = detalleDepartamentoPageModel;
		InitializeComponent();
	}
}