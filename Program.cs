using System;
using System.ComponentModel.Design;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main(string[] args)
    {
       List<string> ostokset = new List<string>();
       List<double> hinnat = new List<double>();
       
       // tulostetaan valikkonäkymä käyttäjälle
       bool kaynnissa = true;
       while (kaynnissa)
       {
       Console.Clear();
       Console.WriteLine("Ostoskorisovellus 1.0");
       Console.WriteLine("Anna valinta: ");
       Console.WriteLine("1 - Kirjoita ostoskoriin");
       Console.WriteLine("2 - Näytä ostoskori");
       Console.WriteLine("3 - Poistu");
       int valikko = Convert.ToInt32(Console.ReadLine());

        if (valikko == 1)
        {
            // tuotteiden lisäys ostoskoriin
            bool ostoskorilisays = true;
            while (ostoskorilisays) 
            {
            Console.WriteLine("Anna tuotteen nimi:");
            string ostos = Console.ReadLine();
            ostokset.Add(ostos);
            Console.WriteLine("Anna tuotteen hinta: € ");
            double hinta = Convert.ToDouble(Console.ReadLine());
            hinnat.Add(hinta);
            while (true)
            {
            Console.WriteLine("Haluatko lisätä uudelleen (y/n)"); // uuden tuotteen lisäys
            string valinta2 = Console.ReadLine();
            if (valinta2 == "y")
            {
                break;
            }
            else if (valinta2 == "n")
            {
                ostoskorilisays = false;
                break;
            }
            else
            {
                Console.WriteLine("Virheellinen valinta!");
            }
            }
            }
        }
        else if (valikko == 2)
        {
            // tulostetaan ostoskorin sisältö
            Console.Clear();
            Console.WriteLine("Ostoskorisi sisältää :");

            for (int i = 0; i < ostokset.Count; i++)
            {
                Console.WriteLine(ostokset[i] + " , hinta: " + hinnat[i] + "eur");
            }
                Console.WriteLine("Ostosten kokonaishinta :");
                Console.Write(Sum(hinnat) + "eur\n");
                Console.WriteLine("Mennäänkö takaisin valikkoon (1) vai suljetaanko ohjelma (2)?");
                int valinta3 = Convert.ToInt32(Console.ReadLine());
                if (valinta3 == 2)
                {
                     // loppusanat jos lähtee ostoskorista pois
                    Console.WriteLine("Kiitos sovelluksen käytöstä!");
                    Console.WriteLine("Tämän sovelluksen kehitti XXXXX");
                    kaynnissa = false;
                
                }
        }

        else if (valikko == 3)
        {
            // loppusanat
            Console.WriteLine("Kiitos sovelluksen käytöstä!");
            Console.WriteLine("Tämän sovelluksen kehitti XXXXX");
            kaynnissa = false;
           
        }

        else
        {
            Console.WriteLine("Virheellinen valinta!");
            Console.ReadLine();
        }
       }
    }
    // summa metodi
    public static double Sum(List<double> hinnat)
      {
    
      double sum = 0;
      foreach(double number in hinnat)
      {
        sum = sum + number;
      }
 
      return sum;
      }
   
}