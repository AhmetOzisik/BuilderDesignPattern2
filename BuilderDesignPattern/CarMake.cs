using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class CarMake
    {
        public void Make(ICarBuilder carBuilder)
        {
            carBuilder.CarName();
            carBuilder.CarModel();
            carBuilder.CarKM();
            carBuilder.CarVites();
        }

    }
}
