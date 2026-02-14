using AppGestionEmpleadosII.Models;
using AppGestionEmpleadosII.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppGestionEmpleadosII.UI.PagesModel;
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

    [RelayCommand]
    public async Task IrADetalle(Empleado empleadoSeleccionado)
    {
        if (empleadoSeleccionado != null)
        {
            // Crea el diccionario de parámetros como dice el PDF del profesor (Pág. 26)
            var parametros = new Dictionary<string, object>{{ "EmpleadoObjeto", empleadoSeleccionado }};

            // Navega. Asegúrate de que el nombre coincide con el registro en AppShell
            await Shell.Current.GoToAsync("DetalleEmpleadoPage", parametros);
        }
    }

}
