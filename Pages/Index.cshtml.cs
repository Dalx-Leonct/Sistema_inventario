using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Proyecto_1.Models;

namespace Proyecto_1.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public List<Sucursal> Sucursals;
    
    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        SupermercadoContext context = new SupermercadoContext();

        Sucursals = context.Sucursals.Include(x => x.ProductosSucursals).ThenInclude(x => x.IdProductoNavigation).ToList();

        Console.WriteLine(Sucursals[0].Nombre);
    }
}
