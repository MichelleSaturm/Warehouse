using System;

namespace BusinessLayer.Modelli
{
    class SpiritDrinkGood : Good
    {
        //PROPRIETA'       
        public Tipo TipoAlcolico { get; set; }
        public int Gradazione { get; set; }

        //ENUM
        public enum Tipo
        {
            Whisky,
            Vodka,
            Grappa,
            Gin,
            Altro
        }

        //COSTRUTTORI
        public SpiritDrinkGood(string codice, string descrizione, decimal prezzo, DateTime dataRicevimento, 
            int quantita, Tipo tipoAlcolico, int gradazione) : 
            base(codice, descrizione, prezzo, dataRicevimento, quantita)
        {
            TipoAlcolico = tipoAlcolico;
            Gradazione = gradazione;

        }

        //METODI

        public override string ToString()
        {

            return $"[{CodiceMerce}] {Descrizione}\t\t\t{DataDiRicevimento.ToString("dd-MMM-yyyy")}\n" +
                $"Tipo di Alcolico: {TipoAlcolico} [Gradazione: {Gradazione}]\n" +
                $"Prezzo: {Prezzo} EUR || Quantità: {Quantita}";
        }
    }
}
