using AppGestionEmpleadosII.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppGestionEmpleadosII.UI.PagesModel.Detalle;
// "EmpleadoObjeto" es el nombre de la "llave" que enviaremos en el diccionario
[QueryProperty(nameof(EmpleadoDetalle), "EmpleadoObjeto")]
public partial class DetalleEmpleadoPageModel : ObservableObject
{
    [ObservableProperty]
    private Empleado empleadoDetalle;

    [RelayCommand]
    public async Task Volver()
    {
        // ".." le indica al Shell que retroceda a la página anterior
        await Shell.Current.GoToAsync("..");
    }

}
