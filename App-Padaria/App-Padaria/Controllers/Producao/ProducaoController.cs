using App_Padaria.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace App_Padaria.Controllers.Producao
{
    public class ProducaoController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        }             

    }
}
