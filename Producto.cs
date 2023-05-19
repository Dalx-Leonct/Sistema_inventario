using System;
using System.Collections.Generic;

namespace Proyecto_1.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int Precio { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<ProductosSucursal> ProductosSucursals { get; set; } = new List<ProductosSucursal>();
}
