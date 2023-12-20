using Microsoft.AspNetCore.Mvc;
using GestaoProff.DBConfig;
using GestaoProff.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

public class NotaController : Controller
{
    private readonly AppDbContext _context;

    public NotaController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var notas = await _context.Notas.ToListAsync();
        return View(notas);
    }

    public IActionResult Adicionar()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Adicionar([Bind("IdNota,MatriculaAluno,IdDisciplina,ValorNota,DataLancamento")] NotaModel notaModel)
    {
        if (ModelState.IsValid)
        {
            _context.Add(notaModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(notaModel);
    }
}
