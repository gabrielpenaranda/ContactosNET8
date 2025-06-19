using System.Diagnostics;
using ContactosNET8.Data;
using ContactosNET8.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContactosNET8.Controllers;

public class InicioController : Controller
{
    private readonly ApplicationDbContext _contexto;

    public InicioController(ApplicationDbContext contexto)
    {
        _contexto = contexto;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _contexto.Contactos.ToListAsync());
    }

    public IActionResult Crear()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
