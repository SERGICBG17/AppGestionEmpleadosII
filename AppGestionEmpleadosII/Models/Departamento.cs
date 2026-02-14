using System.Text.Json.Serialization;

namespace AppGestionEmpleadosII.Models;
public class Departamento
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Correo { get; set; }
    public int Telefono { get; set; }
    public float Ganancias { get; set; }

    [JsonPropertyName("sede_id")]
    public int SedeId { get; set; }

    public Sede Sede { get; set; }

    public List<Empleado> Empleados { get; set; } = [];
}
