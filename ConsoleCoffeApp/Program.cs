using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoffeApp
{
    class Program
    {
        public const string Accesso = "BENVENUTO!";
        public const string Errore = "ERROR: Voce selezionata inesistente!";
        public const string GuidaMenuUno = "Digita la voce desiderata: ";
        public const string GuidaMenuProdotto = "Digita il prodotto richiesto: ";
        public enum TipoMenu { SNACK, DRINK, CAFFETTERIA };
        public enum Drink { VINO_ROSSO, VINO_BIANCO, APEROL, CAMPARI, BIRRA}
        public enum Snack { TOAST, PIADINA, PANINO }
        public enum Caffetteria { CAFFE, THE_BIANCO, THE_VERDE, CIOCCOLATA }


        static void Main(string[] args)
        {
            
            Console.WriteLine(Accesso);
            Console.WriteLine("\n");

            foreach (var tipo in Enum.GetValues(typeof(TipoMenu)))
            {
                Console.WriteLine(tipo.ToString());
                
            }

            Console.WriteLine("\n");
            Console.Write(GuidaMenuUno);
            string selezione = Console.ReadLine();

            switch (selezione)
            {
                case "drink":
                    foreach (var prodotto in Enum.GetValues(typeof(Drink)))
                    {
                        Console.WriteLine(prodotto.ToString());
                        

                    }                    
                    Console.WriteLine(GuidaMenuProdotto);
                    Console.ReadLine();

                    break;

                case "snack":
                    foreach (var prodotto in Enum.GetValues(typeof(Snack)))
                    {
                        Console.WriteLine(prodotto.ToString());
                        Console.ReadLine();
                        
                    }
                    Console.WriteLine(GuidaMenuProdotto);
                    Console.ReadLine();
                    break;

                case "caffetteria":
                    foreach (var prodotto in Enum.GetValues(typeof(Caffetteria)))
                    {
                        Console.WriteLine(prodotto.ToString());
                        Console.ReadLine();

                    }
                    Console.WriteLine("\n");
                    Console.WriteLine(GuidaMenuProdotto);
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine(Errore);
                    Console.ReadLine();
                    break;
            }





        }
    }
}
