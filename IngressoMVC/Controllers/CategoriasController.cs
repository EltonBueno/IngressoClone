using IngressoMVC.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Controllers
{
    public class CategoriasController : Controller
    {
       
  
        private IngressoDbContext _context;
        public CategoriasController(IngressoDbContext context)
        {
            _context = context;
        }
       

        public IActionResult Index()
        {
            return View(_context.Categorias);
        }

        public IActionResult Detalhes(int id)
        {

            var result = _context.Categorias.Find(id);
            return View(result);
        }

        public IActionResult Criar()
        {
           return View();     
        }

        public IActionResult Atualizar(int id)
        {
            //buscar o Categoria no banco
            //passar o Categoria na view
            
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
