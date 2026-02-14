using AppGestionEmpleadosII.UI.PagesModel.Detalle;

namespace AppGestionEmpleadosII.UI.Pages.Detalle;

public partial class DetalleSedePage : ContentPage
{
	public DetalleSedePage(DetalleSedePageModel detalleSedePageModel)
	{
		BindingContext = detalleSedePageModel;
		InitializeComponent();
	}
}