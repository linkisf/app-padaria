using App_Padaria.Models.Producao;

namespace App_Padaria.Repositories.Interfaces
{
    public interface ITipoPlaca
    {
        IEnumerable<TipoPlacaModel> TipoPlaca { get; }
    }    
}
