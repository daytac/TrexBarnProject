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
            Species = "Koyun";
            Age = age;
            Gender = gender;
            Lifespan = 120;
            AnimalValue = 120;

            CurrentProduct=new Product() 
            {
                ProductName ="Yün",
                ProductTime = 5,
                ProgressPerTick =20,// 100/5
                ProductValue = 5
            };
        }
        public override void ProduceProduct() => ProductionProgress = 0;
    }
}
