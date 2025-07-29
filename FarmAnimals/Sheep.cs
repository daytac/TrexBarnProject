using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrexBarn.FarmAnimals
{
    public class Sheep:Animals
    {
        public Sheep(int age, string gender)
        {
            Species = "Sheep";
            Age = age;
            Gender = gender;
            Lifespan = 365 * 12;
            AnimalValue = 120;

            CurrentProduct=new Product() 
            {
                ProductName ="Yün",
                ProductTime = 15,
                ProductValue = 20
            };
        }
        public override void ProducePoduct() => ProductionProgres = 0;

        //public override void ProducePoduct()
        //{
        //    ProductionProgres = 0;
        //}
    }
}
