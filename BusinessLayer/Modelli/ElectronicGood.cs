using System;

namespace BusinessLayer.Modelli
{
    public class ElectronicGood : Good
    {
        //PROPRIETA

        public string Produttore { get; set; }

        //COSTRUTTORI
        public ElectronicGood(string codice, string descrizione, decimal prezzo, DateTime dataRicevimento, 
            int quantita, string produttore) : base(codice, descrizione, prezzo, dataRicevimento, quantita)
        {
            Produttore = produttore;
        }

        public ElectronicGood()
        {
        }

        //METODI

        public override string ToString()
        {
            return $"[{CodiceMerce}] {Descrizione}\t\t\t{DataDiRicevimento.ToString("dd-MMM-yyyy")}\n" +
                $"Produttore: {Produttore}\n" +
                $"Prezzo: {Prezzo} EUR || Quantità: {Quantita}";
        }
    }
}
