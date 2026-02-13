using CommunityToolkit.Mvvm.ComponentModel;

namespace AppGestionEmpleadosII.UI.PagesViewModels;
public partial class MainPageModel : ObservableObject
{
    [ObservableProperty]
    private string _mensaje = "Hola Esto es una prueba";
}
