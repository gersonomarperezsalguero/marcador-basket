using Microsoft.AspNetCore.Mvc;
using BackendMarcador.Data;
using BackendMarcador.Models;

namespace BackendMarcador.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PartidosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PartidosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetPartidos() => Ok(_context.Partidos.ToList());

        [HttpPost]
        public IActionResult GuardarPartido(Partido partido)
        {
            _context.Partidos.Add(partido);
            _context.SaveChanges();
            return Ok(partido);
        }
    }
}
