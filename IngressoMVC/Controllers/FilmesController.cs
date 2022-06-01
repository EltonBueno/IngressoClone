﻿using IngressoMVC.Data;
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

        public IActionResult Criar()
        {
           return View();     
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
