using Microsoft.AspNetCore.Mvc;

namespace App_Padaria.Controllers
{
    public class ProducaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Lancamento()
        {
            return View();
        }
        public IActionResult FechamentoDiario()
        {
            return View();
        }
        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult ProducaoDiariaDePao()
        {
            return View();
        }

        public IActionResult ProducaoDiariaDePao_PaoDaManha()
        {
            return View();
        }

        public IActionResult ProducaoDiariaDePao_PaoDaNoite()
        {
            return View();
        }

        public IActionResult ProducaoDiariaDePao_PaoDoDiaSeguinte()
        {
            return View();
        }

        public IActionResult ProducaoDiariaDePao_ReceitaDiaria()
        {
            return View();
        }
    }
}
