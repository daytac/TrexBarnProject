using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrexBarn.FarmAnimals
{
    public class Cow : Animals 
    {
        public Cow(int age,string gender) 
        {
            Species = "İnek";
            Age = age;
            Gender = gender;
            Lifespan = 120;
            AnimalValue = 180;

            CurrentProduct = new Product()
            {
                ProductName = "Süt",
                ProductTime = 10,//10 saniyede bir üretir
                ProgressPerTick=10,//saniyedeki ilerleme 100/10 dan gelir
                ProductValue = 15
            };
        }
        public override void ProduceProduct() => ProductionProgress = 0;
       
    }
}
