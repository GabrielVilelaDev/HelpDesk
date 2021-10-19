using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Models
{
    public class Prioridade : BaseModel
    {
        public Prioridade(string descricao, int peso)
        {
            this.descricao = descricao;
            this.peso = peso;
        }
        public Prioridade()
        {

        }

        [Required]
        public string descricao { get; set; }
        [Required]
        public int peso { get; set; }
    }
}