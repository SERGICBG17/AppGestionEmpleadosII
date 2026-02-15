using AppGestionEmpleadosII.Models;
using AppGestionEmpleadosII.Services;
using CommunityToolkit.Mvvm.ComponentModel;

public partial class GraficosPageModel : ObservableObject
{
    [ObservableProperty]
    private List<Departamento> _departamentos;

    public GraficosPageModel(DepartamentoService service)
    {
        Departamentos = service.GetAll();
    }
}