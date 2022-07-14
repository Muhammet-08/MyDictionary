using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> names1 = new MyDictionary<string>();
            names1.Add("Muhammet");
            names1.Add("Recep");
            names1.Add("Kerem");
            names1.Add("Barış");
            names1.Add("Ahmet");
            names1.Add("Mehmet");

            Console.WriteLine(names1.Count);
        }
    }
}
