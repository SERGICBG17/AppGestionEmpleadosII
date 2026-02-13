using AppGestionEmpleadosII.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace AppGestionEmpleadosII.Services;

public class SedeService : IService<Sede>
{
    private HttpClient client = new HttpClient();
    private JsonSerializerOptions serializerOptions = new JsonSerializerOptions
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    };
    public void Add(Sede item)
    {
        throw new NotImplementedException();
    }

    public void Delete(Sede item)
    {
        throw new NotImplementedException();
    }

    public Sede Get(int id)
    {
        throw new NotImplementedException();
    }

    public List<Sede> GetAll()
    {
        return client.GetFromJsonAsync<List<Sede>>("http://localhost:8080/sedes/").Result;
    }

    public void Update(Sede item)
    {
        throw new NotImplementedException();
    }
}
