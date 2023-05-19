using System;
using System.Collections.Generic;

namespace Proyecto_1.Models;

public partial class Sucursal
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<ProductosSucursal> ProductosSucursals { get; set; } = new List<ProductosSucursal>();
}
