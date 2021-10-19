using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Models
{
    public class StatusChamado : BaseModel
    {
        public StatusChamado( string descricao)
        {
            this.descricao = descricao;
        }
        public StatusChamado()
        {

        }

        [Required]
        public string descricao { get; set; }
    }
}