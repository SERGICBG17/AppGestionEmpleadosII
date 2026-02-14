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
        List<Departamento> devolverDepartamentos = new List<Departamento>();
        try
        {
            string jsonDepts = client.GetStringAsync("http://localhost:8080/departamentos/").Result;
            List<Departamento> departamentos = JsonSerializer.Deserialize<List<Departamento>>(jsonDepts, serializerOptions);

            string jsonSedes = client.GetStringAsync("http://localhost:8080/sedes/").Result;
            List<Sede> sedes = JsonSerializer.Deserialize<List<Sede>>(jsonSedes, serializerOptions);

            string jsonEmpleados = client.GetStringAsync("http://localhost:8080/empleados/").Result;
            List<Empleado> empleados = JsonSerializer.Deserialize<List<Empleado>>(jsonEmpleados, serializerOptions);

            if (departamentos != null)
            {
                foreach (Departamento d in departamentos)
                {
                    if (sedes != null)
                    {
                        foreach (Sede s in sedes)
                        {
                            if (d.SedeId == s.Id)
                            {
                                d.Sede = s;
                                break;
                            }
                        }
                    }

                    d.Empleados = new List<Empleado>();
                    if (empleados != null)
                    {
                        foreach (Empleado e in empleados)
                        {
                            if (e.DepartamentoId == d.Id)
                            {
                                d.Empleados.Add(e);
                            }
                        }
                    }
                }
            }

            if(departamentos != null)
            {
                devolverDepartamentos = departamentos;
            }

        }
        catch(Exception ex){ }

        return devolverDepartamentos;
    }

    public void Update(Departamento item)
    {
        throw new NotImplementedException();
    }
}
