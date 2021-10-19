using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Models
{
    public class Credencial : BaseModel
    {
        public Credencial(string email, string senha, string nome)
        {
            this.email = email;
            this.senha = senha;
            this.nome = nome;
        }
        public Credencial()
        {

        }

        [Required]
        public string email { get; set; }
        [Required]
        public string senha { get; set; }
        [Required]
        public string nome { get; set; }
    }
}