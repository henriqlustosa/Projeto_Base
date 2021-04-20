using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_MVC.Models
{
    public class Microrganismo
    {

        public Microrganismo()
        {
            Exames = new List<Exame>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public IList<Exame> Exames { get; set; }
    }

    public class MicrorgansimoComInfoExame : Microrganismo
    {
        public int PorAno { get; set; }

    }
}

