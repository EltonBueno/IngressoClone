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
    public class CinemasController : Controller
    {

        
        private IngressoDbContext _context;
        public CinemasController(IngressoDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Cinemas);
        }

        public IActionResult Detalhes(int id)
        {

            var result = _context.Cinemas.Find(id);
            return View(result);
        }

        public IActionResult Criar()
        {
           return View();     
        }

        [HttpPost]
        public IActionResult Criar(PostCinemaDTO cinemaDTO)
        {
            Cinema cinema = new Cinema(cinemaDTO.Nome, cinemaDTO.Descricao, cinemaDTO.LogoURL);

            if (!ModelState.IsValid || !cinemaDTO.LogoURL.EndsWith(".jpg"))
            {
                return View(cinemaDTO);
            }

            _context.Cinemas.Add(cinema);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Atualizar(int id)
        {
            //buscar o Cinema no banco
            //passar o Cinema na view
            
           return View();     
        }

        public IActionResult Deletar(int id)
        {
            var result = _context.Cinemas.FirstOrDefault(a => a.Id == id);
            if (result == null) return View();


            return View(result);
        }

        [HttpPost, ActionName("Deletar")]
        public IActionResult ConfirmarDeletar(int id)
        {
            var result = _context.Cinemas.FirstOrDefault(a => a.Id == id);
            _context.Cinemas.Remove(result);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
