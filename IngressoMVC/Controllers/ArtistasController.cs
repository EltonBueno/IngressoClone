using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Controllers
{
    public class ArtistasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
