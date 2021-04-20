using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_MVC.Models;

namespace Projeto_MVC.Seeding
{
    public class ExameRandomGenerator
    {
        Random random;
        Microrganismo[] microrganismo = new Microrganismo[6]
        {
            new Microrganismo() { Descricao = "A. BAUMANNII - MDR", Imagem = "images/01.jpeg" },
            new Microrganismo() { Descricao = "CITROBACTER FREUNDII CARBAPENEMASE +", Imagem = "images/02.jpg" },
            new Microrganismo() { Descricao = "E. CLOACAE CARBAPENEMASE +", Imagem = "images/03.webp" },
            new Microrganismo() { Descricao = "E. COLI CARBAPENEMASE +", Imagem = "images/04.png" },
            new Microrganismo() { Descricao = "E. FAECALIS VRE", Imagem = "images/05.jpeg" },
            new Microrganismo() { Descricao = "E. FAECIUM VRE", Imagem = "images/06.jpeg" },
        };

        public ExameRandomGenerator(Random random)
        {
            this.random = random;
        }

        private Microrganismo MicrorganismoQualquer()
        {
            var indiceAleatorio = random.Next(0, 5);
            return microrganismo[indiceAleatorio];
        }

        private DateTime DataAleatoria()
        {
            int diasAleatorios = random.Next(1, 100);
            return DateTime.Now.AddDays(-diasAleatorios);
        }

        public Exame NovoExame
        {
            get
            {
                var exame = new Exame();
                // exame.Id = random.Next(); será definido no loop de geração
                exame.Microrganismo = MicrorganismoQualquer();
                exame.Titulo = $"{leilao.Categoria.Descricao} - Lote nº {random.Next(500)}";
                exame.Dt_resultado = this.DataAleatoria();
                exame.Dt_Cadastro = this.DataAleatoria();
                exame.Contato = $"{leilao.Titulo}. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut consequat semper viverra nam libero justo laoreet. Ut placerat orci nulla pellentesque dignissim enim sit amet. Cras semper auctor neque vitae. Eu lobortis elementum nibh tellus molestie nunc non blandit massa. Penatibus et magnis dis parturient montes nascetur ridiculus. Bibendum enim facilisis gravida neque convallis. At risus viverra adipiscing at in tellus integer feugiat scelerisque. Turpis egestas pretium aenean pharetra magna ac. Suspendisse ultrices gravida dictum fusce ut. Mauris vitae ultricies leo integer. Senectus et netus et malesuada fames ac turpis egestas. Libero volutpat sed cras ornare. Tristique senectus et netus et malesuada fames ac.";
                exame.Clinica = this.SituacaoAleatoria();
             
                var dataAnterior = DateTime.Now.AddDays(-random.Next(10));
                exame.Dt_Ultima_Atualizacao = exame.Dt_resultado.Value.CompareTo(dataAnterior) > 0 ? dataAnterior : exame.Dt_Ultima_Atualizacao.Value;
              
                exame.IdMicrorganismo = exame.Microrganismo.Id;
                return exame;
            }
        }

        private Clinica SituacaoAleatoria()
        {
            int index = random.Next(0, 140);
            var values = Enum.GetValues(typeof(Clinica));
            return (Clinica)values.GetValue(index);
        }
    }
}
}
