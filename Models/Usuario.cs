using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Models
{
    public class Usuario : BaseModel
    {
        public Usuario(Setor setor, Credencial credencial)
        {
            this.setor = setor;
            this.credencial = credencial;
        }
        public Usuario()
        {

        }
        [Required]
        public Setor setor { get; set; }
        [Required]
        public Credencial credencial { get; set; }

    }
}