using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
   public interface ICarBuilder
    {

        Car Car { get; }

        void CarName();
        void CarModel();
        void CarKM();
        void CarVites();

    }
}
