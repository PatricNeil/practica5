using System;
using System.Collections.Generic;

namespace practica5.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Cargo { get; set; }

    public decimal? Salario { get; set; }

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}
