using Microsoft.AspNetCore.Mvc;
using GestaoProff.DBConfig;
using GestaoProff.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

public class AlunoController : Controller
{
    private readonly AppDbContext _context;

    public AlunoController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var alunos = await _context.Alunos.ToListAsync();
        return View(alunos);
    }

    public IActionResult Adicionar()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Adicionar([Bind("MatriculaAluno,NomeAluno,IdCurso,EmailAluno,TelefoneAluno")] AlunoModel alunoModel)
    {
        if (ModelState.IsValid)
        {
            _context.Add(alunoModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(alunoModel);
    }
}
