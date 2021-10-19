using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Models
{
    public class Categoria : BaseModel
    {
        public Categoria(string descricao)
        {
            this.descricao = descricao;
        }
        public Categoria()
        {

        }

        [Required]
        public string descricao { get; set; }
    }
}