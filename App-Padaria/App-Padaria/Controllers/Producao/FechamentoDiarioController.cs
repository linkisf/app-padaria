using Microsoft.AspNetCore.Mvc;

namespace App_Padaria.Controllers.Producao
{
    public class FechamentoDiarioController : Controller
    {
        public IActionResult FechamentoDiario()
        {
            return View();
        }
    }
}
