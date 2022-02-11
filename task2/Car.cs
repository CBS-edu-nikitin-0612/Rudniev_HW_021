using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Car
    {
        private string model;
        private int releaseYear;

        public string Model { get => model; set => model = value; }
        public int ReleaseYear { get => releaseYear; set => releaseYear = value; }

        public Car(string model, int releaseYear)
        {
            this.model = model;
            this.releaseYear = releaseYear;
        }
        public override string ToString()
        {
            return $"Model: {this.model}, year: {this.releaseYear};";
        }
    }
}
