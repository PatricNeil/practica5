using System;
using System.Collections.Generic;

namespace practica5.Models;

public partial class Ventum
{
    public int IdVenta { get; set; }

    public DateOnly? Fecha { get; set; }

    public int? IdCliente { get; set; }

    public int? IdEmpleado { get; set; }

    public decimal? Total { get; set; }

    public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual Empleado? IdEmpleadoNavigation { get; set; }
}
