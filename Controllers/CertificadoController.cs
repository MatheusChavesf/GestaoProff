using Microsoft.AspNetCore.Mvc;
using GestaoProff.DBConfig;
using GestaoProff.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

public class CertificadoController : Controller
{
    private readonly AppDbContext _context;

    public CertificadoController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var certificados = await _context.Certificados.ToListAsync();
        return View(certificados);
    }

    public IActionResult Adicionar()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Adicionar([Bind("IdCertificado,MatriculaAluno,IdCurso,DataCertificado")] CertificadoModel certificadoModel)
    {
        if (ModelState.IsValid)
        {
            _context.Add(certificadoModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(certificadoModel);
    }
}
