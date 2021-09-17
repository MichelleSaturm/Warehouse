using BusinessLayer.Modelli;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class Warehouse : IEnumerable<Good>
    {
        //PROPRIETA'
        public string IndirizzoMagazzino { get; set; }
        public string CodiceMagazzino { get; set; }
        public DateTime UltimaOperazione { get; set; }
        public decimal ImportoTotale { get; set; }

        private List<Good> _merce = new List<Good>();

        //COSTRUTTORI
        public Warehouse(string codice, string indirizzo) : this(codice, indirizzo, 0) { }

        public Warehouse(string codice, string indirizzo, decimal importo)
        {
            if (string.IsNullOrEmpty(codice))
                throw new ArgumentException("Codice non valido");
            if (string.IsNullOrEmpty(indirizzo))
                throw new ArgumentException("Indirizzo non valido");
            if (importo < 0)
                throw new ArgumentException("Importo non può essere in negativo.");

            _merce = new List<Good>();
            UltimaOperazione = DateTime.Now;
            CodiceMagazzino = codice;
            IndirizzoMagazzino = indirizzo;
            ImportoTotale = importo;
        }

        public Warehouse()
        {
        }

        //METODI

        //•	Realizzare un metodo StockList() che stampi i dati del Magazzino, inclusa la lista delle Merci in giacenza
        public string StockList()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"=== DATI DEL MAGAZZINO N° {CodiceMagazzino.ToUpper()} ===");
            sb.AppendLine($"Indirizzo: {IndirizzoMagazzino}");
            sb.AppendLine($"Importo totale merci in giacenza: {ImportoTotale} EUR || Ultima Operazione: {UltimaOperazione.ToString("dd-MMM-yyyy")}");
            sb.AppendLine("\n== MERCI IN GIACENZA ==");
            foreach (Good merce in _merce)
            {
                sb.AppendLine(merce.ToString());
            }
            sb.AppendLine("\n");

            return sb.ToString();
        }

        public static Warehouse operator +(Warehouse warehouse, Good merce)
        {
            if (merce.Quantita <= 0)
                throw new ArgumentException("Non può essere minore di zero");

            warehouse._merce.Add(merce);

            //AGGIORNO IMPORTO E ULTIMA OPERAZIONE
            warehouse.ImportoTotale += merce.Prezzo;
            warehouse.UltimaOperazione = merce.DataDiRicevimento;

            return warehouse;
        }

        public static Warehouse operator -(Warehouse warehouse, Good merce)
        {
            if (merce.Quantita <= 0)
                throw new ArgumentException("Non può essere minore di zero");

            warehouse._merce.Add(merce);

            //AGGIORNO IMPORTO E ULTIMA OPERAZIONE
            warehouse.ImportoTotale -= merce.Prezzo;
            warehouse.UltimaOperazione = merce.DataDiRicevimento;

            return warehouse;
        }


        public IEnumerator<Good> GetEnumerator()
        {
            foreach (Good merce in _merce)
                yield return merce;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
