using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("BMW X5", 2000);
            Car car2 = new Car("Audi TT", 2000);
            Car car3 = new Car("Volkswagen CC", 2016);

            CarCollection<Car> carCollection = new CarCollection<Car>();
            carCollection.Add(car1);
            carCollection.Add(car2);
            carCollection.Add(car3);

            for (int i = 0; i < carCollection.Count; i++)
                Console.WriteLine(carCollection[i]);

            Console.WriteLine(new string('-', 50));

            carCollection.Remove(car2);

            for (int i = 0; i < carCollection.Count; i++)
                Console.WriteLine(carCollection[i]);
        }
    }
}
