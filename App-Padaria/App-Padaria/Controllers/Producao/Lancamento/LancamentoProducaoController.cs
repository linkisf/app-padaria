using Microsoft.AspNetCore.Mvc;

namespace App_Padaria.Controllers.Producao.Lancamento
{
    public class LancamentoProducaoController : Controller
    {
        public IActionResult Lancamento()
        {
            return View();
        }

        public IActionResult OpcoesLancamentoProducaoDiariaoDePao()
        {
            return View();
        }
        public IActionResult LancamentoProducaoRegular()
        {
            return View();
        }
    }
}
