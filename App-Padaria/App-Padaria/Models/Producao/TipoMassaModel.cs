using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace App_Padaria.Models.Producao
{
    public class TipoMassaModel
    {
        [Key]
        public int TipoMassaId { get; set; }
        [DisplayName("Tipo de Massa")]
        public string NomeTipoMassa { get; set; }
    }
}
