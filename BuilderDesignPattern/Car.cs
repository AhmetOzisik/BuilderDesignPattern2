using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
   public class Car
    {
        public string Marka { get; set; }
        public int ModelYil { get; set; }
        public double KM { get; set; }
        public Vites.vites vites { get; set; }
        public string ArabaBilgi()
        {
            return $"{Marka} marka araba {ModelYil} modelinde {KM} kilometrede {vites} vites olarak üretilmiştir.";
        }
    }

}
    

