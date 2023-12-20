using Microsoft.AspNetCore.Mvc;
using GestaoProff.DBConfig;
using GestaoProff.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

public class FaltaController : Controller
{
    private readonly AppDbContext _context;

    public FaltaController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var faltas = await _context.Faltas.ToListAsync();
        return View(faltas);
    }

    public IActionResult Adicionar()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Adicionar([Bind("IdFalta,MatriculaAluno,IdDisciplina,QuantidadeFalta,DataFalta")] FaltaModel faltaModel)
    {
        if (ModelState.IsValid)
        {
            _context.Add(faltaModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(faltaModel);
    }
}
