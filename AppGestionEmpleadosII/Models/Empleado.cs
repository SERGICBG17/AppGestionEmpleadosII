using System.Text.Json.Serialization;

namespace AppGestionEmpleadosII.Models;
public class Empleado
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Genero { get; set; }
    public int Edad { get; set; }

    [JsonPropertyName("imagen_uri")]
    public string ImagenUri { get; set; }
    public float sueldo { get; set; }
    public string Correo { get; set; }
    public int Telefono { get; set; }

    [JsonPropertyName("departamento_id")]
    public int DepartamentoId { get; set; }

    public Departamento Departamento { get; set; }

}
