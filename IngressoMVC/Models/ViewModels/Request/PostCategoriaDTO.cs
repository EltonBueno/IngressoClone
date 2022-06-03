

using System.ComponentModel.DataAnnotations;

namespace IngressoMVC.Models.ViewModels.Request
{

    public class PostCategoriaDTO
    {
        [Required (ErrorMessage ="Nome Obrigatório")] 
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Nome da categoria deve ter no máximo 50 caracteres")]
        public string Nome { get; set; }
    }


}