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

        public IActionResult Atualizar(int? id)
        {
            if (id == null)
                return NotFound();

            var result = _context.Produtores.FirstOrDefault(p => p.Id == id);

            if (result == null)
                return View();

            return View(result);
        }

        [HttpPost]
        public IActionResult Atualizar(int id, PostProdutorDTO produtorDTO)
        {
            var produtor = _context.Produtores.FirstOrDefault(p => p.Id == id);

            if (!ModelState.IsValid)
                return View(produtor);

            produtor.AtualizarDados(produtorDTO.Nome, produtorDTO.Bio, produtorDTO.FotoPerfilURL);

            _context.Update(produtor);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Deletar(int id)
        {
            var result = _context.Produtores.FirstOrDefault(p => p.Id == id);

            if (result == null)
                return View();

            return View(result);
        }

        [HttpPost]
        public IActionResult ConfirmarDeletar(int id)
        {
            var result = _context.Produtores.FirstOrDefault(p => p.Id == id);

            _context.Produtores.Remove(result);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
