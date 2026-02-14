using CommunityToolkit.Mvvm.ComponentModel;

namespace AppGestionEmpleadosII.UI.PagesModel;
public partial class MainPageModel : ObservableObject
{
    [ObservableProperty]
    private string _mensaje = "Hola Esto es una prueba";
}
