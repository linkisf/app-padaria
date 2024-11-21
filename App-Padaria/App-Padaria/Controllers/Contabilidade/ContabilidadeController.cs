using Microsoft.AspNetCore.Mvc;

namespace App_Padaria.Controllers.Contabilidade
{
    public class ContabilidadeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
