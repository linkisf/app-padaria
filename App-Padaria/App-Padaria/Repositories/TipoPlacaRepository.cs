using App_Padaria.Infra;
using App_Padaria.Models.Producao;
using App_Padaria.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace App_Padaria.Repositories
{
    public class TipoPlacaRepository : ITipoPlaca
    {
        private readonly ApplicationDbContext _context;

        public TipoPlacaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<TipoPlacaModel> TipoPlaca => _context.TipoPlaca;
    }
}
