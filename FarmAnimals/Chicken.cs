using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrexBarn.FarmAnimals
{
    public class Chicken : Animals
    {
        public Chicken(int age, string gender)
        {
            Species = "Chicken";
            Age = age;
            Gender = gender;
            Lifespan = 365 * 10;
            ProductTime = 5;
            ProductCount = 0;
            ProductValue = 5;
            AnimalValue = 50;
        }
           
        public override void ProducePoduct()
        {
            ProductionProgres = 0;
        }
    }
}
