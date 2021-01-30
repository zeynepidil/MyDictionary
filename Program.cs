
using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> kıyafetler = new Dictionary<string, int>();
            kıyafetler.Add("etek", 10);
            Console.WriteLine("etek", 10);
            kıyafetler.Add("elbise", 50);
            Console.WriteLine("elbise", 50);
            kıyafetler.Add("gömlek", 5);
            Console.WriteLine("gömlek", 5);
            Console.WriteLine(kıyafetler.Count);
        }

    }
}
    