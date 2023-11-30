using System;
namespace uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            int slut = 0;
            Console.WriteLine("skriv in ett heltal");
            int heltal = int.Parse(Console.ReadLine());
            int Största = heltal;

            while (slut == 0)
            {
                Console.WriteLine("Mata in ett heltal till");
                heltal = int.Parse(Console.ReadLine());
                if (heltal > Största)
                {
                    Största = heltal;
                }
                else
                {
                    // ingenting
                }
                Console.WriteLine("vill du fortsätta svara Ja eller Nej");
                string svar = Console.ReadLine();
                if (svar == "ja" || svar == "Ja")
                {
                    Console.WriteLine("skriv in ett heltal");
                    heltal = int.Parse(Console.ReadLine());
                    if (heltal > Största)
                    {
                        Största = heltal;
                    }
                    else
                    {
                        // ingenting
                    }

                }
                else
                {
                    break;
                }


            }
            Console.WriteLine("största tal är " + Största);

        }
    }
}
