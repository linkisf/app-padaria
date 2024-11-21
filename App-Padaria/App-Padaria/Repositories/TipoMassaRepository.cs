using App_Padaria.Infra;
using App_Padaria.Models.Producao;
using App_Padaria.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace App_Padaria.Repositories
{
    public class TipoMassaRepository : ITipoMassa
    {
        private readonly ApplicationDbContext _context;

        public TipoMassaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<TipoMassaModel> TipoMassa => _context.TipoMassa;
    }
}
