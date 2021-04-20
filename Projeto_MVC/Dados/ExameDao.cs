using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_MVC.Models;


namespace Projeto_MVC.Dados
{
    public class ExameDao
    {
        AppDbContext _context;

        public ExameDao()
        {
            _context = new AppDbContext();
        }

        public Exame BuscarExamePorId(int id)
        {
            return _context.Exames.Find(id);
        }

        public IEnumerable<Exame> BuscarTodosExames() => _context.Exames.Include(l => l.Microrganismo);

        public IEnumerable<Microrganismo> BuscarTodasMicrorganismos() => _context.Microrganismos;

        public void IncluirExame(Exame obj)
        {
            _context.Exames.Add(obj);
            _context.SaveChanges();
        }

        public void AlterarExame(Exame obj)
        {
            _context.Exames.Update(obj);
            _context.SaveChanges();
        }

        public void ExcluirExame(Exame exame)
        {
            _context.Exames.Remove(exame);
            _context.SaveChanges();
        }

    }
}
