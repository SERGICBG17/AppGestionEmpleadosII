using AppGestionEmpleadosII.Models;
using AppGestionEmpleadosII.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AppGestionEmpleadosII.UI.PagesViewModels;
public partial class EmpleadosPageModel : ObservableObject
{
    [ObservableProperty]
    private List<Empleado> empleados;
    public EmpleadosPageModel(EmpleadoService empleadoService)
    {
        LoadData(empleadoService);
    }
    private void LoadData(EmpleadoService empleadoService)
    {
        var datos = empleadoService.GetAll();
        if (datos != null)
        {
            Empleados = new List<Empleado>(datos);
        }
    }
}
