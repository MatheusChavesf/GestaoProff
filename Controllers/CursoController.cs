using Microsoft.AspNetCore.Mvc;
using GestaoProff.DBConfig;
using GestaoProff.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

public class CursoController : Controller
{
    private readonly AppDbContext _context;

    public CursoController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var cursos = await _context.Cursos.ToListAsync();
        return View(cursos);
    }

    public IActionResult Adicionar()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Adicionar([Bind("IdCurso,NomeCurso,IdPeriodoLetivo")] CursoModel cursoModel)
    {
        if (ModelState.IsValid)
        {
            _context.Add(cursoModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(cursoModel);
    }
}
