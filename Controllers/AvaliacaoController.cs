using Microsoft.AspNetCore.Mvc;
using GestaoProff.DBConfig;
using GestaoProff.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

public class AvaliacaoController : Controller
{
    private readonly AppDbContext _context;

    public AvaliacaoController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var avaliacoes = await _context.Avaliacoes.ToListAsync();
        return View(avaliacoes);
    }

    public IActionResult Adicionar()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Adicionar([Bind("IdAvaliacao,TipoAvaliacao,DataAvaliacao,IdDisciplina")] AvaliacaoModel avaliacaoModel)
    {
        if (ModelState.IsValid)
        {
            _context.Add(avaliacaoModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(avaliacaoModel);
    }
}
