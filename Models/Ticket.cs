using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Models
{
    public class Ticket : BaseModel
    {
        public Ticket()
        {

        }
        public Ticket(string assunto, string descricao, Categoria categoria, DateTime dataAbertura, Usuario usuario, Prioridade prioridade, StatusChamado status, Usuario responsavel)
        {
            this.assunto = assunto;
            this.descricao = descricao;
            this.categoria = categoria;
            this.dataAbertura = dataAbertura;
            this.criador = usuario;
            this.prioridade = prioridade;
            this.status = status;
            this.responsavel = responsavel;
        }

        [Required]
        public string assunto { get; set; }
        [Required]
        public string descricao { get; set; }
        [Required]
        public Categoria categoria { get; set; }
        [Required]
        public DateTime dataAbertura { get; set; }
        [Required]
        public Usuario criador { get; set; }
        [Required]
        public Prioridade prioridade { get; set; }
        [Required]
        public StatusChamado status { get; set; }
        [Required]
        public Usuario responsavel { get; set; }

    }
}
