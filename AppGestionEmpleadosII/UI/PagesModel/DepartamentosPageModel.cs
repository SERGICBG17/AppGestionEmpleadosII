using AppGestionEmpleadosII.Models;
using AppGestionEmpleadosII.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppGestionEmpleadosII.UI.PagesModel;

public partial class DepartamentosPageModel : ObservableObject
{
    [ObservableProperty]
    private List<Departamento> departamentos;
    public DepartamentosPageModel(DepartamentoService departamentoService)
    {
        LoadData(departamentoService);
    }
    private async void LoadData(DepartamentoService departamentoService)
    {
        var datos = departamentoService.GetAll();
        if (datos != null)
        {
            Departamentos = new List<Departamento>(datos);
        }
    }

    [RelayCommand]
    public async Task IrADetalle(Departamento deptoSeleccionado)
    {
        if (deptoSeleccionado == null) return;

        var parametros = new Dictionary<string, object>{{ "DepartamentoObjeto", deptoSeleccionado }};

        await Shell.Current.GoToAsync("DetalleDepartamentoPage", parametros);
    }
}
