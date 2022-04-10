using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
   public class MercesedBuilder : ICarBuilder
    {
        
        private Car car;

        public Car Car
        {
            get
            {
                return car;
            }
        }
        public MercesedBuilder()
        {
            car = new Car();
           
        }

        public void CarKM()
        {
            car.KM = 0;
        }

        public void CarModel()
        {
            car.ModelYil = 2022;
        }

        public void CarName()
        {
            car.Marka = "Mercedes";
        }

        public void CarVites()
        {
            car.vites = Vites.vites.Manuel;
        }

    }
}
