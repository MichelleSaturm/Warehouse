using System;

namespace BusinessLayer.Modelli
{
    class PerishableGood : Good
    {
        //PROPRIETA'
        public DateTime DataDiScadenza { get; set; }
        public Modalita ModalitaDiConservazione { get; set; }

        //ENUM
        public enum Modalita
        {
            Freezer,
            Fridge,
            Shelf
        }

        //COSTRUTTORI
        public PerishableGood(string codice, string descrizione, decimal prezzo, DateTime dataRicevimento, 
            int quantita, DateTime dataScadenza, Modalita modalitaConservazione) : 
            base(codice, descrizione, prezzo, dataRicevimento, quantita)
        {
            DataDiScadenza = dataScadenza;
            ModalitaDiConservazione = modalitaConservazione;
        }

        //METODI

        public override string ToString()
        {
 
            return $"[{CodiceMerce}] {Descrizione}\t\t\t{DataDiRicevimento.ToString("dd-MMM-yyyy")}\n" +
                $"Modalità di Conservazione: {ModalitaDiConservazione} [Scadenza: {DataDiScadenza}]\n" +
                $"Prezzo: {Prezzo} EUR || Quantità: {Quantita}";
        }
    }
}
