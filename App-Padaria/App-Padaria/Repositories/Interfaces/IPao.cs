using App_Padaria.Models.Producao;

namespace App_Padaria.Repositories.Interfaces
{
    public interface IPao
    {
        IEnumerable<PaoModel> Pao { get; }
    }    
}
