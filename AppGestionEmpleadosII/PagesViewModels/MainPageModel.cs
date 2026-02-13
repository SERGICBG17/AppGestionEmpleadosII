using CommunityToolkit.Mvvm.ComponentModel;

namespace AppGestionEmpleadosII.PagesViewModels;
public partial class MainPageModel : ObservableObject
{
    [ObservableProperty]
    private string _mensaje = "Hola Esto es una prueba";
}
