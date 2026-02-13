using AppGestionEmpleadosII.Models;
using AppGestionEmpleadosII.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AppGestionEmpleadosII.UI.PagesViewModels;

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
}
