using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> beverages = new Dictionary<string, string>();
            beverages.Add("coffee", "espresso");
            beverages.Add("coffee", "doppio");
            beverages.Add("coffee", "americano");
            beverages.Add("coffee", "ristretto");
            beverages.Add("coffee", "lungo");
            beverages.Add("tea", "black");
            beverages.Add("tea", "Green");

            string[] values = beverages["coffee"];
            Console.WriteLine("Значения полученные по ключу 'coffee':");
            for (int i = 0; i < values.Length; i++)
                Console.WriteLine(values[i]);
        }
    }
}
