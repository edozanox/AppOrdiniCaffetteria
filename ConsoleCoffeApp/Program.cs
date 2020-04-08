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
        public const string AnotherTimeReq = "Vuoi effettuare un'altra scelta? (Y/N)";
        public const string GuidaMenuUno = "Digita la voce desiderata: ";
        public const string GuidaMenuProdotto = "Digita il prodotto richiesto: ";
        
        public enum TipoMenu { SNACK, DRINK, CAFFETTERIA };
    


        static void Main(string[] args)
        {
            string[] drink = { "VINO ROSSO", "VINO BIANCO", "APEROL", "CAMPARI", "BIRRA" };
            string[] snack = { "TOAST", "PIADINA", "PANINO" };
            string[] caffetteria = { "CAFFE", "THE BIANCO", "THE VERDE", "CIOCCOLATA" };
            List<string> ProdottiSelezionati = new List<string>();
            bool AnotherTime = false;
            bool IsOK = false;
            string selezione;            
            int NumProdSel = 0;

            Console.WriteLine(Accesso);
            Console.WriteLine("\n");

            do
            {
                foreach (var tipo in Enum.GetValues(typeof(TipoMenu)))
                {
                    Console.WriteLine(tipo.ToString());

                }

                Console.WriteLine("\n");
                Console.Write(GuidaMenuUno);
                selezione = Console.ReadLine();

                switch (selezione)
                {
                    case "DRINK":

                        for(int i = 0; i < drink.Length; i++)                        
                            Console.WriteLine(drink[i]);
                        
                        do
                        {
                            Console.WriteLine("\n");
                            Console.Write(GuidaMenuProdotto);
                            selezione = Console.ReadLine();
                            for (int j = 0; j < drink.Length; j++)
                            {
                                if (selezione == drink[j])
                                {
                                    ProdottiSelezionati.Add(drink[j]);
                                    IsOK = true;
                                }
                            }
                        } while (!IsOK);

                        break;

                    case "SNACK":
                        for(int k = 0; k< snack.Length; k++)                        
                            Console.WriteLine(snack[k]);                            
                        
                        do
                        {
                            Console.WriteLine("\n");
                            Console.Write(GuidaMenuProdotto);
                            selezione = Console.ReadLine();

                            for (int j = 0; j < snack.Length; j++)
                            {
                                if (selezione == snack[j])
                                {
                                    ProdottiSelezionati.Add(snack[j]);
                                    IsOK = true;
                                }
                            }                            
                        } while (!IsOK);

                        break;

                    case "CAFFETTERIA":
                        for(int j = 0; j < caffetteria.Length; j++)                        
                            Console.WriteLine(caffetteria[j]); 
                        do
                        {

                            Console.WriteLine("\n");
                            Console.Write(GuidaMenuProdotto);
                            selezione = Console.ReadLine();

                            for (int j = 0; j < caffetteria.Length; j++)
                            {
                                if (selezione == caffetteria[j])
                                {
                                    ProdottiSelezionati.Add(caffetteria[j]);
                                    IsOK = true;
                                }
                            }
                        } while (!IsOK);
                     
                        break;

                    default:
                        Console.WriteLine(Errore);
                        Console.ReadLine();
                        break;
                }
                Console.WriteLine("\n");
                Console.Write(AnotherTimeReq);
                selezione = Console.ReadLine();

                if (selezione == "y" || selezione == "Y")
                {
                    AnotherTime = true;
                    Console.WriteLine($"------------------------------------");
                }
                else
                    AnotherTime = false;               

            } while (AnotherTime);

            NumProdSel = ProdottiSelezionati.Count;
            Console.WriteLine($"------------------------------------");
            Console.WriteLine("RIEPILOGO PRODOTTI:");
            foreach (var elem in ProdottiSelezionati)
            {
                Console.WriteLine($">>[{elem}]");
            }

            Console.WriteLine("\n");
            Console.WriteLine($"TOT:  00{NumProdSel} PRODOTTI.");            
            Console.WriteLine("ARRIVEDERCI");
            Console.ReadLine();
        }
    }
}
