using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Models
{
    public class Setor : BaseModel
    {
        public Setor(string descricao)
        {
            this.descricao = descricao;
        }
        public Setor()
        {

        }

        [Required]
        public string descricao { get; set; }
    }
}