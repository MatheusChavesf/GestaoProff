using Microsoft.AspNetCore.Mvc;
using GestaoProff.DBConfig;
using GestaoProff.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

public class PeriodoLetivoController : Controller
{
    private readonly AppDbContext _context;

    public PeriodoLetivoController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var periodosLetivos = await _context.PeriodosLetivos.ToListAsync();
        return View(periodosLetivos);
    }

    public IActionResult Adicionar()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Adicionar([Bind("IdPeriodoLetivo,DataInicioPL,DataFimPL,AtivoPL")] PeriodoLetivoModel periodoLetivoModel)
    {
        if (ModelState.IsValid)
        {
            _context.Add(periodoLetivoModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(periodoLetivoModel);
    }
}
