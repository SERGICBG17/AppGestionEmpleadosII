using AppGestionEmpleadosII.UI.PagesModel;

namespace AppGestionEmpleadosII.UI.Pages;

public partial class SettingsPage : ContentPage
{
	public SettingsPage(SettingsPageModel settingsPageModel)
	{
		BindingContext = settingsPageModel;
		InitializeComponent();
	}
}