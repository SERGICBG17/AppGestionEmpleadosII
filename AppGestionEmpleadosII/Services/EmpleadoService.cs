
using AppGestionEmpleadosII.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace AppGestionEmpleadosII.Services;

public class EmpleadoService : IService<Empleado>
{
    private HttpClient client = new HttpClient();
    private JsonSerializerOptions serializerOptions = new JsonSerializerOptions
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    };

    public void Add(Empleado item)
    {
        throw new NotImplementedException();
    }

    public void Delete(Empleado item)
    {
        throw new NotImplementedException();
    }

    public Empleado Get(int id)
    {
        throw new NotImplementedException();
    }

    public List<Empleado> GetAll()
    {
        List<Empleado> devolverEmpleados = new List<Empleado>();
        try
        {
            string empJson = client.GetStringAsync("http://localhost:8080/empleados/").Result;
#if ANDROID
            empJson = client.GetStringAsync("http://10.0.2.2:8080/empleados/").Result;
#endif
            
            List<Empleado> empleados = JsonSerializer.Deserialize<List<Empleado>>(empJson, serializerOptions);

            string deptJson = client.GetStringAsync("http://localhost:8080/departamentos/").Result;

#if ANDROID
            deptJson = client.GetStringAsync("http://10.0.2.2:8080/departamentos/").Result;
#endif

            List<Departamento> departamentos = JsonSerializer.Deserialize<List<Departamento>>(deptJson, serializerOptions);

            
            if (empleados != null && departamentos != null)
            {
                foreach (Empleado emp in empleados)
                {
                    foreach (Departamento dept in departamentos)
                    {
                        if (dept.Id == emp.DepartamentoId)
                        {
                            emp.Departamento = dept;
                            break;
                        }
                    }
                }
            }

            if (empleados != null)
            {
                devolverEmpleados = empleados;
            }

        }
        catch (Exception ex)
        {
            Shell.Current.DisplayAlert("Error", "No se pudieron cargar los datos: " + ex.Message, "Aceptar");
        }

        return devolverEmpleados;
    }

    public void Update(Empleado item)
    {
        throw new NotImplementedException();
    }
}
