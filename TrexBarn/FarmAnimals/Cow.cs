using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrexBarn.FarmAnimals
{
    public class Cow:Animals
    {
        public Cow(int age,string gender) 
        {
            Species = "Cow";
            Age = age;
            Gender = gender;
            Lifespan = 365 * 20;
            ProductTime = 10;
            ProductCount = 0;
            ProductValue = 15;
            AnimalValue = 100;



        }

        public override void ProducePoduct()
        {
            ProductionProgres = 0;
        }
    }
}
