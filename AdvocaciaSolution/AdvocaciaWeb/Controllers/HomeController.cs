using AdvocaciaPrincipal.Modelo;
using AdvocaciaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AdvocaciaWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Advogado ad= new Advogado();
            ad.Codigo = 1;
            ad.Nome = "Vinicius";
            ad.Idade = 39;
                     

            if (ad.verificarSeAdovagdoEMaiorIdade())
            {
                ViewBag.textoIdade = "é maior de idade";
            }
            else
            {
                ViewBag.textoIdade = "é menor de idade";
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
