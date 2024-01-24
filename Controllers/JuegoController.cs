using APIJuego.Data;
using APIJuego.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIJuego.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JuegoController : Controller
    {
        private readonly AppDBContext _db;

        public JuegoController(AppDBContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Juego> juegos = await _db.fechasganada.ToListAsync();
            return Ok(juegos);
        }
        // GET: JuegoController
        /*public ActionResult Index()
        {
            return View();
        }

        // GET: JuegoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: JuegoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JuegoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: JuegoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JuegoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: JuegoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JuegoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/
    }
}
