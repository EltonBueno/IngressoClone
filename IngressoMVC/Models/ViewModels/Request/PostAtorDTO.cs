

using System.ComponentModel.DataAnnotations;

namespace IngressoMVC.Models.ViewModels.Request
{

    public class PostAtorDTO
    {
        [Required(ErrorMessage ="Nome Obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Nome do ator deve ter no máximo 50 caracteres")]
        public string Nome { get; set; }

        public string Bio { get; set; }

        [Required(ErrorMessage ="Imagem Obrigatório")]
        public string FotoPerfilURL { get; set; }
    }


}