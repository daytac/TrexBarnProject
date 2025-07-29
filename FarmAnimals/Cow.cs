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
            Species = "Cow";
            Age = age;
            Gender = gender;
            Lifespan = 365 * 20;
            AnimalValue = 200;

            CurrentProduct = new Product()
            {
                ProductName = "Süt",
                ProductTime = 10,
                ProductValue = 15
            };
        }
        public override void ProducePoduct() => ProductionProgres = 0;
        //public override void ProducePoduct()
        //{
        //    ProductionProgres = 0;
        //}
    }
}
