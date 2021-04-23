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


    }
}
