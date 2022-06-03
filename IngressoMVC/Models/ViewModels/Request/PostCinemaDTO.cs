

using System.ComponentModel.DataAnnotations;

namespace IngressoMVC.Models.ViewModels.Request
{

    public class PostCinemaDTO
    {
        [Required(ErrorMessage ="Nome Obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Nome do Cinema deve ter no máximo 50 caracteres")]

        public string Nome { get; set; }

        
        [Required(ErrorMessage ="Descrição Obrigatório")]
        public string Descricao { get; set; }
        [Required(ErrorMessage ="Imagem .jpg Obrigátorio")]
        public string LogoURL { get; set; }
    }


}