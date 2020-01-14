using System;
using System.Collections.Generic;

namespace _56.uzd_Element_adding_to_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            Console.Write("Enter number 1 to 10: ");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            while (i < n)
            {
                Console.Write("Enter name: ");
                names.Add(Console.ReadLine());
                ++i;
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
// Izveidot tukšu string sarakstu (List). Izmantojot console applikāciju paprasīt lietotājam ievadīt vārdu.
// Ievadītais vārds ir jāpievieno sarakstam. Programmai ir jāļauj ievadīt 1...n vārdus. 
// Ir jābūt iespējai izdrukāt ievadītos vārdus.
