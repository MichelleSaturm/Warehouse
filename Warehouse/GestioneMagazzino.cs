using BusinessLayer;
using BusinessLayer.Modelli;
using System;
using System.Collections.Generic;

namespace WarehouseEsercitazione
{


    public static class GestioneMagazzino
    {
       
        public static void DatiMagazzino()
        {
            Console.Clear();
            //magazzino creato
            string codice = "C0002";
            string indirizzo = "Via Fasulla, 123";
            decimal importo = 120;

            Warehouse magazzino = new(codice, indirizzo, importo);


            Console.WriteLine(magazzino.StockList());

            Console.WriteLine();
            Console.WriteLine("Premi un tasto qualsiasi per tornare al menù principale");
            Console.ReadLine();
        }

        

        public static void Stampa()
        {
            Console.Clear();
            Console.WriteLine("==== STAMPA ====");

           

            Console.WriteLine();
            Console.WriteLine("Premi un tasto qualsiasi per tornare al menù principale");
            Console.ReadLine();
        }
    }
}