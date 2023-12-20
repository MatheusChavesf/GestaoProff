using Microsoft.AspNetCore.Mvc;
using GestaoProff.DBConfig;
using GestaoProff.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

public class UsuarioController : Controller
{
    private readonly AppDbContext _context;

    public UsuarioController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var usuarios = await _context.Usuarios.ToListAsync();
        return View(usuarios);
    }

    public IActionResult Adicionar()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Adicionar([Bind("IdUsuario,NomeUsuario,SenhaUsuario,TipoUsuario")] UsuarioModel usuarioModel)
    {
        if (ModelState.IsValid)
        {
            _context.Add(usuarioModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(usuarioModel);
    }
}
