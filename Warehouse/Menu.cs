using BusinessLayer;
using BusinessLayer.Modelli;
using System;
using System.Collections.Generic;

namespace WarehouseEsercitazione
{
    public static class Menu
    {
        
        public static void MenuPrincipale()
        {
            bool continuare = true;
            do
            {
                Console.Clear();
                Console.WriteLine("==== BENVENUTO ====");
                Console.WriteLine("[1] Stampa dati Magazzino");
                Console.WriteLine("[2] Gestione merci");
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
                        //GestioneMagazzino.DatiMagazzino();
                        string codice = "C0002";
            string indirizzo = "Via Fasulla, 123";
            decimal importo = 120;

            Warehouse magazzino = new(codice, indirizzo, importo);


            Console.WriteLine(magazzino.StockList());

            Console.WriteLine();
            Console.WriteLine("Premi un tasto qualsiasi per tornare al menù principale");
            Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Menu.GestioneMerciMenu();
                        Console.Clear();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Grazie per aver usufruito dei nostri servizi!\n" +
                            "A presto!");
                        continuare = false;
                        break;
                    default:
                        Console.WriteLine("La scelta è sbagliata. Riprova.");
                        break;
                }
            } while (continuare);
        }

        private static void GestioneMerciMenu()
        {
            bool continuare = true;
            do
            {
                Console.Clear();
                Console.WriteLine("==== GESTIONE MERCI ====");
                Console.WriteLine("[1] Aggiungi Prodotto");
                Console.WriteLine("[2] Vendi Prodotto");
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
                        //GestioneMerci.Aggiungi();
                        
                      
                        Console.Clear();
                        break;
                    case 2:
                        GestioneMerci.Vendi();
                        Console.Clear();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Grazie per aver usufruito dei nostri servizi!\n" +
                            "A presto!");
                        continuare = false;
                        break;
                    default:
                        Console.WriteLine("La scelta è sbagliata. Riprova.");
                        break;
                }
            } while (continuare);
        }
    }
}