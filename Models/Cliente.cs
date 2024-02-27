using System;
using System.Collections.Generic;

namespace practica5.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}
