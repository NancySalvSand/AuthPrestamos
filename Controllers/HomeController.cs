using AuthPrestamos.Areas.Identity.Data;
using AuthPrestamos.Data;
using AuthPrestamos.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AuthPrestamos.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly APrestamosContext _context;

        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager,
            APrestamosContext context)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {

            var user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);


             Prestamo prestamo = _context.Prestamo.Where(p => p.IdUsuario == user.Id).FirstOrDefault();
            if (prestamo == null)
            {
                ViewBag.CantidadPrestamo = 0.00;
                ViewBag.CantidadPrestamoInteres =0.00;
            }
            else
            {
                ViewBag.CantidadPrestamo = prestamo.Cantidad;
                ViewBag.CantidadPrestamoInteres = prestamo.CantidadInteres;
            }
                


                return View();
          
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
