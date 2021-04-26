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
        private static Random random_2 = new Random((int)DateTime.Now.Ticks);
        long maximo = 1120991L;
        long minimo = 4575881L;
        Microrganismo[] microrganismo = new Microrganismo[6]
        {
            new Microrganismo() { Descricao = "A. BAUMANNII - MDR", Imagem = "images/01.jpeg" },
            new Microrganismo() { Descricao = "CITROBACTER FREUNDII CARBAPENEMASE +", Imagem = "images/02.jpg" },
            new Microrganismo() { Descricao = "E. CLOACAE CARBAPENEMASE +", Imagem = "images/03.webp" },
            new Microrganismo() { Descricao = "E. COLI CARBAPENEMASE +", Imagem = "images/04.png" },
            new Microrganismo() { Descricao = "E. FAECALIS VRE", Imagem = "images/05.jpeg" },
            new Microrganismo() { Descricao = "E. FAECIUM VRE", Imagem = "images/06.jpeg" },
        };


        Material[] material = new Material[6]
      {
            new Material() { Descricao = "COLEÇÃO INTRAPERITONIAL", Imagem = "images/Intraperitoneal.jpeg" },
            new Material() { Descricao = "CATETER", Imagem = "images/Cateter.webp" },
            new Material() { Descricao = "CATETER DUPLO J BILATERAL", Imagem = "images/CateterDuploJ.jpg" },
            new Material() { Descricao = "CATETER VENOSO CENTRAL", Imagem = "images/CateterVenoso.png" },
            new Material() { Descricao = "COLEÇÃO DE INCISÃO CIRÚRGICA", Imagem = "images/IncisaoCirugica.jpeg" },
            new Material() { Descricao = "ASPIRADOR  DE HEMATOMA MAMA", Imagem = "images/HematomaMama.jpeg" },
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

        private Material MaterialQualquer()
        {
            var indiceAleatorio = random.Next(0, 5);
            return material[indiceAleatorio];
        }

        private DateTime DataAleatoria()
        {
            int diasAleatorios = random.Next(1, 100);
            return DateTime.Now.AddDays(-diasAleatorios);
        }
      

        public long LongBetween(long maxValue, long minValue)
        {
            return (long)Math.Round(random_2.NextDouble() * (maxValue - minValue - 1)) + minValue;
        }
        public Exame NovoExame
        {
            get
            {
                var exame = new Exame();
                //exame.Id = random.Next();// será definido no loop de geração
                exame.Microrganismo = MicrorganismoQualquer();

                exame.Material = MaterialQualquer();

                exame.Contato = "Lorem ipsum dolor sit amet.";
                exame.Clinica = this.SituacaoAleatoria();
                var dataPosterior = DateTime.Now.AddDays(random.Next(10));
                exame.Dt_resultado = this.DataAleatoria();
                exame.Dt_Cadastro = this.DataAleatoria();
                exame.Dt_Ultima_Atualizacao = exame.Dt_resultado.Value.CompareTo(dataPosterior) < 0 ? dataPosterior : exame.Dt_Ultima_Atualizacao.Value;
               
                exame.Rh = LongBetween(maximo, minimo);
                exame.IdMaterial = exame.Material.Id;
                exame.IdMicrorganismo = exame.Microrganismo.Id;

                exame.Usuario = "Usuario";
                return exame;
            }
        }

        private Clinica SituacaoAleatoria()
        {
            int index = random.Next(0, 8);
            var values = Enum.GetValues(typeof(Clinica));
            return (Clinica)values.GetValue(index);
        }
    }
}

