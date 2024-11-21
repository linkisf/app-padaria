using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace App_Padaria.Models.Producao
{
    public class TipoPlacaModel
    {
        [Key]
        public int TipoPlacaId { get; set; }
        [DisplayName("Tipo de Placa")]
        public string NomeTipoPlaca { get; set; }
        [DisplayName("Quantidade de Pães")]
        public int QuantidadePaes { get; set; }
    }
}
