using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppGestionEmpleadosII.UI.PagesModel;

public partial class SettingsPageModel : ObservableObject
{
    [ObservableProperty]
    private List<AppTheme> _temas = new() { AppTheme.Unspecified, AppTheme.Light, AppTheme.Dark };

    [ObservableProperty]
    private AppTheme _temaSeleccionado = Application.Current.UserAppTheme;

    [RelayCommand]
    private void SaveSettings() => Application.Current.UserAppTheme = TemaSeleccionado;
}