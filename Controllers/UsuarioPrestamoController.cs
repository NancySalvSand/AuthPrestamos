using AuthPrestamos.Areas.Identity.Data;
using AuthPrestamos.Data;
using AuthPrestamos.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthPrestamos.Controllers
{
    [Authorize]
    public class UsuarioPrestamoController : Controller
    {

        private UserManager<ApplicationUser> _userManager;
        private readonly APrestamosContext _context;
        private List<Abono> abonos;
        //constructor 
        public UsuarioPrestamoController(UserManager<ApplicationUser> userManager, APrestamosContext context)
        {
            _userManager = userManager;
            _context = context;
            abonos = new List<Abono>();
        }

        //retorna vista de prestamos-- validamos edad
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);

            var age = (DateTime.Now - currentUser.FechaNacimientoUser).TotalDays / 360;

            List<int> amountsValid = new List<int>() { 1000, 2000, 3000 };

            if (age > 30 && age < 50)
            {
                amountsValid.Add(4000);
                amountsValid.Add(5000);
            }

            ViewBag.AmountsValid = amountsValid;

            return View();
        }

        //http post Create un nuevo prestamo
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync(Prestamo prestamo)
        {
            
            var userName = HttpContext.User.Identity.Name!;
            var user = await _userManager.FindByNameAsync(userName);

            var userprestamo = _context.Prestamo.Where(x => x.IdUsuario == user.Id).FirstOrDefault();

            if (userprestamo == null)
            {
                var newPrestamo = new Prestamo
                {

                    Cantidad = prestamo.Cantidad,
                    IdUsuario = user.Id,
                    CantidadInteres = prestamo.Cantidad + ((prestamo.Cantidad / 100) * 5),



                };

                _context.Prestamo.Add(newPrestamo);
                _context.SaveChanges();

                TempData["mensaje"] = "Prestamo Autorizado...";
                return RedirectToAction("Index", "Home");
            }
            else
                if (userprestamo.Cantidad == 0)
            {
                var newPrestamoA = new Prestamo
                {

                    Cantidad = prestamo.Cantidad,
                    IdUsuario = user.Id,
                    CantidadInteres = prestamo.Cantidad + ((prestamo.Cantidad / 100) * 5),


                };

                _context.Prestamo.Update(newPrestamoA);
                _context.SaveChanges();
            }
            else if (userprestamo.CantidadInteres > 0)
            {
                TempData["mensaje"] = "Tienes un Prestamo Activo...";
                return RedirectToAction("Index", "Home");

            }



            return RedirectToAction("Index", "Home");

        }




        [HttpPost]
        public async Task<IActionResult> AddAbono(Abono abono)
        {
            var userName = HttpContext.User.Identity.Name!;
            var user = await _userManager.FindByNameAsync(userName);
            var prestamo = _context.Prestamo.Where(x => x.IdUsuario == user.Id).FirstOrDefault();

            if (prestamo.CantidadInteres == 0)
            {
                
                _context.Prestamo.Remove(prestamo);
                _context.SaveChanges();
                TempData["mensaje"] = "No Puedes Abonar, Préstamo Liquidado... Exito!";
                return RedirectToAction("Index", "Home");
               
             

            }
            else
            {
                var newAbono = new Abono
                {
                    CantidadAbono = abono.CantidadAbono,
                    Saldo = prestamo.CantidadInteres - abono.CantidadAbono,
                    Fecha = DateTime.Now,
                    PrestamoId = prestamo.Id,

                };

                _context.Abono.Add(newAbono);
                _context.SaveChanges();


                prestamo.CantidadInteres = prestamo.CantidadInteres - abono.CantidadAbono;
                _context.Prestamo.Update(prestamo);
                _context.SaveChanges();

                TempData["mensaje"] = "Abono Realizado... Exito!";
                return RedirectToAction("Index", "Home");
            }




        }

        //retornavista Abonar
        public IActionResult Abonar()
        {
            return View();
        }


        //leer detalle abonos------------
        public async Task<IActionResult> ObtenerAbonos()
        {
            var userName = HttpContext.User.Identity.Name!;
            var user = await _userManager.FindByNameAsync(userName);

            var prestamoUser = _context.Prestamo.Include(x => x.Abonos)
                .Where(x => x.IdUsuario == user.Id).FirstOrDefault();

            if (prestamoUser == null)
            {
                return View();
            }
           
            return View(prestamoUser);

        }
    }
}