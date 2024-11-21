using App_Padaria.Models.Producao;

namespace App_Padaria.Repositories.Interfaces
{
    public interface ITipoMassa
    {
        IEnumerable<TipoMassaModel> TipoMassa { get; }
    }    
}
