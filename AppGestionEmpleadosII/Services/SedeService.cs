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
        List<Sede> devolverSedes = new List<Sede>();
        try
        {
            string jsonSedes = client.GetStringAsync("http://localhost:8080/sedes/").Result;
            List<Sede> sedes = JsonSerializer.Deserialize<List<Sede>>(jsonSedes, serializerOptions);

            string jsonDepts = client.GetStringAsync("http://localhost:8080/departamentos/").Result;
            List<Departamento> departamentos = JsonSerializer.Deserialize<List<Departamento>>(jsonDepts, serializerOptions);

            if (sedes != null && departamentos != null)
            {
                foreach (Sede s in sedes)
                {
                    s.Departamentos = new List<Departamento>();
                    foreach (Departamento d in departamentos)
                    {
                        if (d.SedeId == s.Id)
                        {
                            s.Departamentos.Add(d);
                        }
                    }
                }
            }

            if (sedes != null)
            {
                devolverSedes = sedes;
            }

        }
        catch (Exception ex)
        {
            Shell.Current.DisplayAlert("Error", "No se pudieron cargar los datos: " + ex.Message, "Aceptar");
        }
        return devolverSedes;
    }

    public void Update(Sede item)
    {
        throw new NotImplementedException();
    }
}
