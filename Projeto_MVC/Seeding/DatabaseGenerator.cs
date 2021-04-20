using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_MVC.Models;
using Projeto_MVC.Dados;

namespace Projeto_MVC.Seeding
{
    public class DatabaseGenerator
    {
        public static void Seed()
        {
            using (var ctx = new AppDbContext())
            {
                if (ctx.Database.EnsureCreated())
                {
                    var generator = new ExameRandomGenerator(new Random());
                    var exames = new List<Exame>();
                    for (var i = 1; i <= 200; i++)
                    {
                        exames.Add(generator.NovoExame);
                    }
                    ctx.Exames.AddRange(exames);
                    ctx.SaveChanges();
                }
            }
        }
    }
}
