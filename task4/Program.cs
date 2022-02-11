using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример с урока 022 с собственным классом ArrayList
            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add((object)2);
            arrayList.Add(new Random());

            int i1 = (int)arrayList[0];

            //for(int i = 0; i < arrayList.Count; i++)
            //    Console.WriteLine((int)arrayList[i]); //ошибка

            for (int i = 0; i < arrayList.Count; i++)
                Console.WriteLine(arrayList[i]);
        }
    }
}
