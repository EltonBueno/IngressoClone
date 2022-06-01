using IngressoMVC.Data;
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

        public IActionResult Atualizar(int id)
        {
            //buscar o Cinema no banco
            //passar o Cinema na view
            
           return View();     
        }
        
        public IActionResult Deletar(int id)
        {
            //buscar o Cinema no banco
            //passar o Cinema na view
           return View();     
        }
    }
}
