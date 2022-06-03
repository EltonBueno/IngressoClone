﻿using IngressoMVC.Data;
using IngressoMVC.Models;
using IngressoMVC.Models.ViewModels.Request;
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

        [HttpPost]
        public IActionResult Criar(PostCategoriaDTO categoriaDTO)
        {
            
            Categoria categoria = new Categoria(categoriaDTO.Nome);
            if (!ModelState.IsValid)
            {
                return View(categoriaDTO);
            }

            _context.Categorias.Add(categoria);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
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
