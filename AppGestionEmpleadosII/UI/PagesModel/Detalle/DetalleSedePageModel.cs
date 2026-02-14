using AppGestionEmpleadosII.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppGestionEmpleadosII.UI.PagesModel.Detalle;

[QueryProperty(nameof(SedeDetalle), "SedeObjeto")]
public partial class DetalleSedePageModel : ObservableObject
{
    [ObservableProperty]
    private Sede sedeDetalle;

    [RelayCommand]
    public async Task Volver() => await Shell.Current.GoToAsync("..");
}
