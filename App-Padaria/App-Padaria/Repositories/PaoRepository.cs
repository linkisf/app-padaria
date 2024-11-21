using App_Padaria.Infra;
using App_Padaria.Models.Producao;
using App_Padaria.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace App_Padaria.Repositories
{
    public class PaoRepository : IPao
    {
        private readonly ApplicationDbContext _context;

        public PaoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<PaoModel> Pao => _context.Pao.Include(co => co.TipoMassa).Include(co => co.TipoPlaca);
    }
}
