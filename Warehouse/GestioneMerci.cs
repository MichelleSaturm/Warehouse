using BusinessLayer;
using BusinessLayer.Modelli;
using System;
using System.Collections.Generic;

namespace WarehouseEsercitazione
{

    public static class GestioneMerci
    {
        public static List<Good> listaMerci = new List<Good>();

        internal static bool Aggiungi(Warehouse wh)
        {
            bool continuare = true;
            do
            {
                Console.Clear();
                Console.WriteLine("==== SCEGLI LA TIPOLOGIA DI PRODOTTO ====");
                Console.WriteLine("[1] Electronic");
                Console.WriteLine("[2] Perishable");
                Console.WriteLine("[3] Spirits Drink");
                Console.WriteLine();
                Console.WriteLine("[0] Esci");
                Console.WriteLine();
                Console.Write("Inserisci la tua scelta: ");

                int choice;
                bool isInt;
                do
                {
                    isInt = int.TryParse(Console.ReadLine(), out choice);
                } while (!isInt);


                switch (choice)
                {
                    case 1:
                        ElectronicGood electronic = new();
                        Console.WriteLine("Inserisci Codice Prodotto");
                        electronic.CodiceMerce = Console.ReadLine();

                        Console.WriteLine("Inserisci Descrizione Prodotto");
                        electronic.Descrizione = Console.ReadLine();

                        Console.WriteLine("Inserisci Prezzo Prodotto");
                        decimal.TryParse(Console.ReadLine(), out decimal prezzo);
                        electronic.Prezzo = prezzo;

                        electronic.DataDiRicevimento = DateTime.Now;

                        Console.WriteLine("Inserisci Quantità");
                        int.TryParse(Console.ReadLine(), out int qnt);
                        electronic.Quantita = qnt;

                        Console.WriteLine("Inserisci Produttore");
                        electronic.Produttore = Console.ReadLine();

                        listaMerci.Add(electronic);

                        wh += electronic;

                        Console.Clear();
                        break;
                    case 2:
                    
                        Console.Clear();
                        break;
                    case 3:
                    
                        Console.Clear();
                        break;
                    case 0:
                        Console.Clear();
                        Menu.MenuPrincipale();
                        continuare = false;
                        break;
                    default:
                        Console.WriteLine("La scelta è sbagliata. Riprova.");
                        break;
                }
            } while (continuare);
            return false;
        }

        internal static void Vendi()
        {
            throw new NotImplementedException();
        }
    }
}
