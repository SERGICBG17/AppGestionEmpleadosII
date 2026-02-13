using AppGestionEmpleadosII.Models;
using AppGestionEmpleadosII.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AppGestionEmpleadosII.UI.PagesViewModels;

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
}
