using L02P02_2021AA602_2021RA650.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace L02P02_2021AA602_2021RA650.Controllers
{

    public class ConfirmacionController : Controller
    {
        private readonly LibreriaDbContext _context;

        public ConfirmacionController(LibreriaDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var libreriaDbContext = _context.ComentariosLibros.Include(c => c.IdLibroNavigation);
            return View(await libreriaDbContext.ToListAsync());
        }
    }
}
