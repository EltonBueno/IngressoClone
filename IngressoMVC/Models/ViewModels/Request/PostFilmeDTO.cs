

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IngressoMVC.Models.ViewModels.Request
{

    public class PostFilmeDTO
    {
          public string Titulo { get; private set; }
        public string Descricao { get; private  set; }
        public decimal Preco { get; private set; }
        public string ImageURL { get; private set; }
        
        public string NomeCinema { get; set; }

        public string NomeProdutor { get; set; }

        public List<string> NomesAtores { get; set; }
        public List<string> Categorias { get; set; }
        public string NomePodutor { get; internal set; }
    }


}