using IngressoMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public abstract class Artista : IEntidade
    {
        protected Artista(string nome, string fotoPerfilURL, string bio)
        {
            DataCadastro = DateTime.Now;
            DataAlteracao = DataAlteracao;
            Nome = nome;
            FotoPerfilURL = fotoPerfilURL;
            Bio = bio;
        }

        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; private set; }

        [Display(Name = "Foto")]
        public string FotoPerfilURL { get; private set; }

        [Display(Name = "Biografia")]
        public string Bio { get; private set; }
    }
}
