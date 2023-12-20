using Microsoft.AspNetCore.Mvc;
using GestaoProff.DBConfig;
using GestaoProff.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

public class DisciplinaController : Controller
{
    private readonly AppDbContext _context;

    public DisciplinaController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var disciplinas = await _context.Disciplinas.ToListAsync();
        return View(disciplinas);
    }

    public IActionResult Adicionar()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Adicionar([Bind("IdDisciplina,NomeDisciplina,IdCurso")] DisciplinaModel disciplinaModel)
    {
        if (ModelState.IsValid)
        {
            _context.Add(disciplinaModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(disciplinaModel);
    }
}
