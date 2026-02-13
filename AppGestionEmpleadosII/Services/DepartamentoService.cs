using AppGestionEmpleadosII.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace AppGestionEmpleadosII.Services;

public class DepartamentoService : IService<Departamento>
{
    private HttpClient client = new HttpClient();
    private JsonSerializerOptions serializerOptions = new JsonSerializerOptions
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    };
    public void Add(Departamento item)
    {
        throw new NotImplementedException();
    }

    public void Delete(Departamento item)
    {
        throw new NotImplementedException();
    }

    public Departamento Get(int id)
    {
        throw new NotImplementedException();
    }

    public List<Departamento> GetAll()
    {
        return client.GetFromJsonAsync<List<Departamento>>("http://localhost:8080/departamentos/").Result;
    }

    public void Update(Departamento item)
    {
        throw new NotImplementedException();
    }
}
