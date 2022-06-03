using Microsoft.AspNetCore.Mvc;
using IngressoMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IngressoMVC.Models.ViewModels.Request;
using IngressoMVC.Models;

namespace IngressoMVC.Controllers
{
    public class ProdutoresController : Controller
    {
        private IngressoDbContext _context;
        public ProdutoresController(IngressoDbContext context)
        {
            _context = context;
        }
       

        public IActionResult Index()
        {
            return View(_context.Produtores);
        }

        public IActionResult Detalhes(int id)
        {

            var result = _context.Produtores.Find(id);
            return View(result);
        }

        public IActionResult Criar()
        {
           return View();     
        }

        [HttpPost]
        public IActionResult Criar(PostProdutorDTO produtorDTO)
        {
            if (!ModelState.IsValid || !produtorDTO.FotoPerfilURL.EndsWith(".jpg"))
            {
                return View(produtorDTO);
            }
            Produtor produtor = new Produtor(produtorDTO.Nome, produtorDTO.Bio, produtorDTO.FotoPerfilURL);
            _context.Produtores.Add(produtor);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Atualizar(int id)
        {
            //buscar o Produtores no banco
            //passar o Produtores na view
            
           return View();     
        }
        
        public IActionResult Deletar(int id)
        {
            //buscar o Categoria no banco
            //passar o Categoria na view
           return View();     
        }
    }
}
