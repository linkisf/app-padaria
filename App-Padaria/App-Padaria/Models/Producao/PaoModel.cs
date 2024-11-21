using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App_Padaria.Models.Producao
{
    public class PaoModel
    {
        [Key]
        public int IdPao { get; set; }
        [DisplayName("Pão")]
        public string NomePao { get; set; }
        public double Peso { get; set; }
        
        public TipoMassaModel TipoMassa { get; set; }
       
        public TipoPlacaModel TipoPlaca { get; set; }
        public DateTime DataAtualizacao { get; set; }

    }
}
