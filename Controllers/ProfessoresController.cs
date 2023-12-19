

using Microsoft.AspNetCore.Mvc;
using GestaoProff.Models; 
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

public class ProfessoresController : Controller
{
    private readonly SeuDbContext _context;

    public ProfessoresController(SeuDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var professores = await _context.Professores.ToListAsync();
        return View(professores);
    }

    public IActionResult Adicionar()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Adicionar([Bind("Id,NomeProfessor,Disciplina")] ProfessorModel professorModel)
    {
        if (ModelState.IsValid)
        {
            _context.Add(professorModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(professorModel);
    }

    
}

