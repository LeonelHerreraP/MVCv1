using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoMVC3.Models;
using System.Diagnostics;

namespace ProyectoMVC3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AutorDbContext _context;

        public HomeController(ILogger<HomeController> logger, AutorDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        // Busca los autores dependiendo de los datos que recibe
        public IActionResult BuscarAutores([Bind("id_autor,apellido,nombre,telefono,Genero")] AutorBusqueda autor)
        {
            List<Autor> query = _context.Autores.ToList();
            if (autor.id_autor != null) // En caso de que tenga ID
            {
                query = query.Where(x => x.id_autor == autor.id_autor).ToList();
                autor.AutorLista = query;
                return View(nameof(Index), autor);

            }
            else if (autor.telefono != null)// En caso de que sea por telefono
            {
                query = query.Where(x => x.telefono == autor.telefono).ToList();
                autor.AutorLista = query;
                return View(nameof(Index), autor);
            }
            else // En caso de que sea por nombre, apellido y genero
            {
                if (autor.nombre != null)
                {
                    query = query.Where(x => x.nombre == autor.nombre).ToList();
                }
                if (autor.apellido != null)
                {
                    query = query.Where(x => x.apellido == autor.apellido).ToList();
                }
                if (autor.Genero != null)
                {
                    query = query.Where(x => x.Genero == autor.Genero).ToList();
                }

                autor.AutorLista = query;

                return View(nameof(Index), autor);

            }
        }
        public IActionResult Index()
        {
            return View(new AutorBusqueda());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}