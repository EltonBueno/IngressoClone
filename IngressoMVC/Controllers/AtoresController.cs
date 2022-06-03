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
   
    public class AtoresController : Controller
    {

        private IngressoDbContext _context;
        public AtoresController(IngressoDbContext context)
        {
            _context = context;
        }
       

        public IActionResult Index()
        {
            return View(_context.Atores);
        }

        public IActionResult Detalhes(int id)
        {

            var result = _context.Atores.Find(id);
            return View(result);
        }


        public IActionResult Criar()
        {
           return View();     
        }

        [HttpPost]
        public IActionResult Criar(PostAtorDTO atorDTO)
        {
            Ator ator = new Ator(atorDTO.Nome, atorDTO.Bio, atorDTO.FotoPerfilURL);
            
            if (!ModelState.IsValid || !atorDTO.FotoPerfilURL.EndsWith(".jpg") )
            {
                return View(atorDTO);
            }
            
            _context.Atores.Add(ator);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Atualizar(int id)
        {
            //buscar o ator no banco
            //passar o ator na view
            
           return View();     
        }
        
        public IActionResult Deletar(int id)
        {
            var result = _context.Atores.FirstOrDefault(a => a.Id == id);
            if (result == null) return View();
            
            //buscar o ator no banco
            //passar o ator na view
           return View(result);     
        }

        [HttpDelete]
        public IActionResult ConfirmarDeletar(int id)
        {
            var result = _context.Atores.FirstOrDefault(a => a.Id == id);
            _context.Atores.Remove(result);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }



    }
}
