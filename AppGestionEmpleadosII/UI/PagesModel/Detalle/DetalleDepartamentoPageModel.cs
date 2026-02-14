using AppGestionEmpleadosII.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppGestionEmpleadosII.UI.PagesModel.Detalle;

[QueryProperty(nameof(DepartamentoDetalle), "DepartamentoObjeto")]
public partial class DetalleDepartamentoPageModel : ObservableObject
{
    [ObservableProperty]
    private Departamento departamentoDetalle;

    [RelayCommand]
    public async Task Volver() => await Shell.Current.GoToAsync("..");
}