using System;
namespace Uppgift_4_26
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Skriv in ett heltal tack :");
            string heltal = Console.ReadLine();

            for (int i = 0; i < heltal.Length; i++)
            {
                string tecken = heltal[i].ToString();
                int siffra = int.Parse(tecken);

                switch(siffra)
                {
                    case 9:
                        siffra = 0;
                        break;

                    default: 
                        siffra++;
                        break;

                }
                Console.WriteLine(siffra); 
            }

        }
    }
}
