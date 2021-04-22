using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto_MVC.Models;
using Projeto_MVC.Dados;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;

namespace Projeto_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        AppDbContext _context;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = new AppDbContext();
        }

        public IActionResult Index()
        { 
        var microrganismos = _context.Microrganismos
                .Include(c => c.Exames)
                .Select(c => new MicrorgansimoComInfoExame
                {
                    Id = c.Id,
                    Descricao = c.Descricao,
                    Imagem = c.Imagem,
                    PorAno = c.Exames.Where(l => l.Clinica == Clinica.AMA).Count(),
                 
                });
            return View(microrganismos);
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
}
