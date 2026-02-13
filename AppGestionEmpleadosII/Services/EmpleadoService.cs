
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
        return client.GetFromJsonAsync<List<Empleado>>("http://localhost:8080/empleados/").Result;
    }

    public void Update(Empleado item)
    {
        throw new NotImplementedException();
    }
}
