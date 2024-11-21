using App_Padaria.Repositories;
using App_Padaria.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace App_Padaria.Controllers.Producao
{
    public class CadastroProducaoController : Controller
    {
        private readonly ITipoMassa _tipoMassaRepository;
        private readonly IPao _paoRepository;
        private readonly ITipoPlaca _tipoPlacaRepository;
        public CadastroProducaoController(IPao paoRepository, ITipoPlaca tipoPlacaRepository, ITipoMassa tipoMassaRepository)
        {
            _paoRepository = paoRepository;
            _tipoPlacaRepository = tipoPlacaRepository;
            _tipoMassaRepository = tipoMassaRepository;
        }
        public IActionResult Cadastro()
        {
            return View();
        }
        public IActionResult CadastroTipoDeMassa()
        {
            var tipoMassa = _tipoMassaRepository.TipoMassa;
            return View(tipoMassa);
        }
        public IActionResult CadastroReceita()
        {
            return View();
        }
        public IActionResult CadastroPao()
        {
            var pao = _paoRepository.Pao;
            return View(pao);
        }
        public IActionResult CadastroProduto()
        {
            return View();
        }
        public IActionResult CadastroTipoDePlaca()
        {
            var tipoPlaca = _tipoPlacaRepository.TipoPlaca;
            return View(tipoPlaca);
        }
    }
}
