using IngressoMVC.Data;
using IngressoMVC.Models;
using IngressoMVC.Models.ViewModels.Request;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Controllers
{
    public class FilmesController : Controller
    {

        
        private IngressoDbContext _context;
        public FilmesController(IngressoDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Filmes);
        }

        public IActionResult Detalhes(int id)
        {

            var result = _context.Filmes.Find(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult Criar(PostFilmeDTO filmeDto)
        {
            var cinema = _context.Cinemas.FirstOrDefault(c => c.Nome == filmeDto.NomeCinema);
            if (cinema == null) return View();

            var produtor = _context.Produtores.FirstOrDefault(p => p.Nome == filmeDto.NomePodutor);
            if (produtor == null) return View();

            Filme filme = new Filme
                (
                    filmeDto.Titulo,
                    filmeDto.Descricao,
                    filmeDto.Preco,
                    filmeDto.ImageURL,
                    cinema.Id,
                    produtor.Id
                );

            _context.Add(filme);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Atualizar(int id)
        {
            //buscar o filme no banco
            //passar o filme na view
            
           return View();     
        }
        
        public IActionResult Deletar(int id)
        {
            //buscar o filmes no banco
            //passar o filmes na view
           return View();     
        }
    }
}
