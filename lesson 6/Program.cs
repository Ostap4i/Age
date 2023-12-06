using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lesson_6
{







    internal class Program
    {
        static void Main(string[] args)
        {
            List<Man> mans = new List<Man>();
            mans.Add(new Man("Ostap", 14));
            mans.Add(new Man("Artur", 24));
            mans.Add(new Man("Maks", 23));
            mans.Add(new Man("Bogdan", 30));

            mans.ForEach((man) =>
            {
                if (man.Age <= 25)
                {
                    Console.WriteLine(man.Name);
                }

            });
            mans.RemoveAll((man) => man.Age <= 18);


            Console.WriteLine("\nBefore sort:");
            foreach (Man aMan in mans)
            {
                Console.WriteLine(aMan.Name);
            }

            mans.Sort();

            Console.WriteLine("\nAfter sort by part number:");
            foreach (Man aMan in mans)
            {
                Console.WriteLine(aMan.Name);
            }


            mans.Sort( (Man x, Man y) =>
               x.Name.CompareTo(y.Name)
            );

            Console.WriteLine("\nAfter sort by name:");
            foreach (Man aMan in mans)
            {
                Console.WriteLine(aMan.Name);
            }

      



        }
    }
}

