namespace App_Padaria.Models.Producao
{
    public class PaoModel
    {
        public int Id { get; set; }
        public string NomePao { get; set; }
        public double Peso { get; set; }
        public TipoMassaModel TipoMassa { get; set; }
        public TipoPlacaModel TipoPlaca { get; set; }

    }
}
