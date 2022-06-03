

using System.ComponentModel.DataAnnotations;

namespace IngressoMVC.Models.ViewModels.Request
{

    public class PostProdutorDTO
    {

         [Required(ErrorMessage ="Nome Obrigatório")]
         [StringLength(50, MinimumLength = 3, ErrorMessage = "Nome do produtor deve ter no máximo 50 caracteres")]
        public string Nome { get; set; }
         [Required(ErrorMessage ="Biográfia Obrigatório")]
        public string Bio { get; set; }
        [Required(ErrorMessage ="Imagem Obrigátorio")]
        public string FotoPerfilURL { get; set; }
    }


}