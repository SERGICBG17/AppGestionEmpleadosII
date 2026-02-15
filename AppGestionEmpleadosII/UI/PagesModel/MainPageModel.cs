using AppGestionEmpleadosII.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppGestionEmpleadosII.UI.PagesModel;

public partial class MainPageModel : ObservableObject
{
    [ObservableProperty]
    private int totalEmpleados;
    [ObservableProperty]
    private int totalDepartamentos;
    [ObservableProperty]
    private int totalSedes;

    public MainPageModel(EmpleadoService empServ, DepartamentoService depServ, SedeService sedServ)
    {
        // Llamamos a los servicios para obtener los conteos
        TotalEmpleados = empServ.GetAll().Count;
        TotalDepartamentos = depServ.GetAll().Count;
        TotalSedes = sedServ.GetAll().Count;
    }

    [RelayCommand]
    public async Task IrAEmpleados() => await Shell.Current.GoToAsync("///EmpleadosPage");

    [RelayCommand]
    public async Task IrADepartamentos() => await Shell.Current.GoToAsync("///DepartamentosPage");

    [RelayCommand]
    public async Task IrASedes() => await Shell.Current.GoToAsync("///SedesPage");

    [RelayCommand]
    public async Task IrAGraficos() => await Shell.Current.GoToAsync("///GraficosPage");
}
