using AppGestionEmpleadosII.Models;
using AppGestionEmpleadosII.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppGestionEmpleadosII.UI.PagesModel;

public partial class SedesPageModel : ObservableObject
{
    [ObservableProperty]
    private List<Sede> sedes;
    public SedesPageModel(SedeService sedeService)
    {
        LoadData(sedeService);
    }
    private async void LoadData(SedeService sedeService)
    {
        var datos = sedeService.GetAll();
        if (datos != null)
        {
            Sedes = new List<Sede>(datos);
        }
    }

    [RelayCommand]
    public async Task IrADetalle(Sede sedeSeleccionada)
    {
        if (sedeSeleccionada == null) return;

        var parametros = new Dictionary<string, object>{{ "SedeObjeto", sedeSeleccionada }};

        await Shell.Current.GoToAsync("DetalleSedePage", parametros);
    }

}
