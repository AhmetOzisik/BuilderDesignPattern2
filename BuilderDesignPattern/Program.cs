using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarBuilder carBuilder = new MercesedBuilder();
            CarMake carMake = new CarMake();
            carMake.Make(carBuilder);
            Console.WriteLine(carBuilder.Car.ArabaBilgi());

            Console.ReadLine();
        }
    }
}
