using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klaseiobjekti1SinozicSebastian
{
    class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov x380 = new Zrakoplov();
            x380.setNaziv("Airbus");
            x380.setDosegLeta(6000);
            x380.setSnagaMotora(2000);

            Console.WriteLine ("Naziv" + x380.getNaziv() + " \nSnaga: " + x380.getSnagaMotora() +"kW"
                + "\nDoseg leta: " + x380.getDosegLeta()+ "kW");



            Zrakoplov PU123RO = new Zrakoplov("Cessna", 350, 125);

            Console.WriteLine(PU123RO.ToString());

            Zrakoplov x328 = new Zrakoplov("MeanMachine",5000);
            string unos;
            int domet;
            try
            {
                Console.WriteLine("\nUpiši doseg leta aviona" + x328.getNaziv)
                Console.ReadLine();
                domet = Convert.ToInt32(unos);
                x328.setDosegLeta(domet);

                x328.setDosegLeta(Convert.ToInt32(Console.ReadLine()));
            }
            catch(Exception e)
            {
                Console.WriteLine("Nisi upisao brojcanu vrijednost");
            }
                    Console.WriteLine x380.setDosegLeta();



            Console.ReadKey();
                
        }
    }
}

