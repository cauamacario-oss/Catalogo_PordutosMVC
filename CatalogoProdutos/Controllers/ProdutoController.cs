using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CatalogoProdutos.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            
            List<string> nomes = new List<string>
            {
                "Teclado Mecânico",
                "Mouse Óptico",
                "Monitor 24'",
                "Cabo HDMI",
                "Mousepad Gamer"
            };

            
            List<double> precos = new List<double>
            {
                350.00,
                89.90,  
                1200.00,
                45.00,  
                79.90   
            };

            
            ViewBag.NomesProdutos = nomes;
            ViewBag.PrecosProdutos = precos;

            return View();
        }
    }
}