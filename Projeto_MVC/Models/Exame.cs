using System;
using System.ComponentModel.DataAnnotations;
namespace Projeto_MVC.Models
{
    public class Exame
    {
        public int Id { get; set; }
        [Display(Name = "Resultado do Exame")]
        [DataType(DataType.DateTime, ErrorMessage = "Data inválida")]
        public DateTime? Dt_resultado { get; set; }
        public Microrganismo Microrganismo { get; set; }
        public int Material { get; set; }
        public long Rh { get; set; }
        public int IdMicrorganismo { get; set; }
        public String Contato { get; set; }
        public Clinica Clinica { get; set; }
        [Display(Name = "Cadastro do Exame")]
        [DataType(DataType.DateTime, ErrorMessage = "Data inválida")]
        public DateTime? Dt_Cadastro { get; set; }
        [Display(Name = "Última Atualização")]
        [DataType(DataType.DateTime, ErrorMessage = "Data inválida")]
        public DateTime? Dt_Ultima_Atualizacao { get; set; }
        public String  Usuario { get; set; }

        public string PosterUrl => $"images/poster-{Id}.jpg";
    }
}
