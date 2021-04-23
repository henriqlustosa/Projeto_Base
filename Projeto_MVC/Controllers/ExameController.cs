using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto_MVC.Models;
using Projeto_MVC.Dados;

namespace Projeto_MVC.Controllers
{
    public class ExameController : Controller
    {
        AppDbContext _context;
        ExameDao _dao;

        public ExameController()
        {
            _context = new AppDbContext();
            _dao = new ExameDao();
        }

        public IActionResult Index()
        {
            var exames = _dao.BuscarTodosExames();
            return View(exames);
        }
        public IActionResult Pesquisa(string termo)
        {
            ViewData["termo"] = termo;
            var exames = _dao.BuscarTodosExames()
                .Where(l => string.IsNullOrWhiteSpace(termo) ||
                    l.Usuario.ToUpper().Contains(termo.ToUpper()) ||
                    l.Contato.ToUpper().Contains(termo.ToUpper()) ||
                    l.Microrganismo.Descricao.ToUpper().Contains(termo.ToUpper())
                );
            return View("Index", exames);


        }
    }
}
