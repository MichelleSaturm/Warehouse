using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Modelli
{
    //PROPRIETA'
    public class Good
    {
        public string CodiceMerce { get; set; }
        public string Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public DateTime DataDiRicevimento { get; set; }
        public int Quantita { get; set; }

        //COSTRUTTORE
        public Good()
        {

        }
        public Good(string codice, string descrizione, decimal prezzo, DateTime dataRicevimento, int quantita)
        {
            CodiceMerce = codice;
            Descrizione = descrizione;
            Prezzo = prezzo;
            DataDiRicevimento = dataRicevimento;
            Quantita = quantita;
        }

        //METODO
        public override string ToString()
        {
            return $"[{CodiceMerce}] {Descrizione}\t\t\t{DataDiRicevimento.ToString("dd-MMM-yyyy")}\n" +
               $"Prezzo: {Prezzo} EUR || Quantità: {Quantita}";
        }
    }
}
