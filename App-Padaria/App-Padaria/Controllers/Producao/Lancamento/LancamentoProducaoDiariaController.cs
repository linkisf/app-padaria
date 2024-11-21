using Microsoft.AspNetCore.Mvc;

namespace App_Padaria.Controllers.Producao.Lancamento
{
    public class LancamentoProducaoDiariaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OpcoesProducaoDiariaDePao()
        {
            return View();
        }

        public IActionResult ProducaoDiariaPaoDaManha()
        {
            return View();
        }

        public IActionResult ProducaoDiariaPaoDaNoite()
        {
            return View();
        }

        public IActionResult ProducaoDiariaPaoDoDiaSeguinte()
        {
            return View();
        }

        public IActionResult ReceitaDiariaPao()
        {
            return View();
        }
    }
}
