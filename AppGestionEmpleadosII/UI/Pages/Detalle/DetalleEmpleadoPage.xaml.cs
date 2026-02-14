using AppGestionEmpleadosII.UI.PagesModel.Detalle;

namespace AppGestionEmpleadosII.UI.Pages.Detalle;

public partial class DetalleEmpleadoPage : ContentPage
{
	public DetalleEmpleadoPage(DetalleEmpleadoPageModel detalleEmpleadoPageModel)
	{
		BindingContext = detalleEmpleadoPageModel;
		InitializeComponent();
	}
}